using BadmintonManagement.Models;
using BadmintonManagement.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Database
{
    class DatabaseInitial
    {
        private static string defaultConnectionString = "Data Source=localhost; Initial Catalog=BadmintonManagementDB;integrated security=true";
        public static bool CheckDBExists()
        {
            List<C_USER> list = UserServices.GetAllUser();
            if (list.Count == 0)
                return false;
            return true;
        }

        public static void CreateDatabase()
        {
            string connectionString = "Data Source=localhost;integrated security=true;";
            string databaseName = "BadmintonManagementDB";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string createDatabaseQuery = $"CREATE DATABASE {databaseName}";

                using (SqlCommand command = new SqlCommand(createDatabaseQuery, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine($"Cơ sở dữ liệu '{databaseName}' đã được tạo.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi tạo cơ sở dữ liệu: {ex.Message}");
                    }
                }
            }
        }

        public static void RunSqlScriptFile(string pathStoreProceduresFile)
        {
            try
            {
                string script = File.ReadAllText(pathStoreProceduresFile);

                // split script on GO command
                System.Collections.Generic.IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$",
                                         RegexOptions.Multiline | RegexOptions.IgnoreCase);
                using (SqlConnection connection = new SqlConnection(defaultConnectionString))
                {
                    connection.Open();
                    foreach (string commandString in commandStrings)
                    {
                        if (commandString.Trim() != "")
                        {
                            using (var command = new SqlCommand(commandString, connection))
                            {
                                try
                                {
                                    command.ExecuteNonQuery();
                                }
                                catch (SqlException ex)
                                {
                                    string spError = commandString.Length > 100 ? commandString.Substring(0, 100) + " ...\n..." : commandString;
                                    MessageBox.Show(string.Format("Please check the SqlServer script.\nFile: {0} \nLine: {1} \nError: {2} \nSQL Command: \n{3}", pathStoreProceduresFile, ex.LineNumber, ex.Message, spError), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
