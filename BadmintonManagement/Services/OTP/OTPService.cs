using BadmintonManagement.Database;
using BadmintonManagement.Forms.AuthorizationForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement
{
    class OTPService
    {
        private static string sendEmail = "todreamscompany@gmail.com";
        private static string appPassword = "jjxhyssvqdczhhdb";

        public static string mailTrailing = "\n--------------------------------------------------------------------------\r\nCông Ty Cổ Phần TOD\r\nPhone: 0823 216 213\r\nEmail: todreamscompany@gmail.com";

        private static int RandomOTPCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999);
        }


        public static void SendActiveOTP(string receiveEmail, Action callback)
        {

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(sendEmail);
                mail.To.Add(receiveEmail);
                mail.Subject = "[TOD] Công ty Theatre Of Dreams";
                int code = RandomOTPCode();
                mail.Body = "Xin chào,\n\n"
                            + "Để hoàn tất việc trở thành thành viên của Công ty TOD, hãy nhập mã ở dưới để kích hoạt tài khoản của bạn:\n\n"
                            + RandomOTPCode().ToString()
                            + mailTrailing;
                
                SmtpServer.EnableSsl = true;
                SmtpServer.Port = 587;
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.Credentials = new System.Net.NetworkCredential(sendEmail, appPassword);

                SmtpServer.Send(mail);
                EnterOTP enterActiveOTP = new EnterOTP(receiveEmail, code.ToString(), callback);
                enterActiveOTP.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void SendForgotPasswordOTP(string receiveEmail)
        {

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(sendEmail);
                mail.To.Add(receiveEmail);
                mail.Subject = "[TOD] Công ty Theatre Of Dreams";
                int code = RandomOTPCode();
                mail.Body = "Xin chào,\n\n"
                            + "Để cập nhật mật khẩu mới cho tài khoản, hãy nhập mã dưới đây:\n\n"
                            + RandomOTPCode().ToString()
                            + mailTrailing;
                SmtpServer.EnableSsl = true;
                SmtpServer.Port = 587;
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.Credentials = new System.Net.NetworkCredential(sendEmail, appPassword);

                SmtpServer.Send(mail);
                var user = UserServices.GetUserByEmail(receiveEmail);

                EnterOTP enterActiveOTP = new EnterOTP(receiveEmail, code.ToString(), () =>
                {
                    ResetPasswordForm resetPasswordForm = new ResetPasswordForm(user, receiveEmail);
                    resetPasswordForm.Show();

                });
                enterActiveOTP.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
