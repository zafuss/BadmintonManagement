using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Database
{
    public class CustomerServices
    {
        static ModelBadmintonManage context = new ModelBadmintonManage();
        public static List<CUSTOMER> GetAllService()
        {
            return context.CUSTOMER.ToList();
        }

        public static CUSTOMER GetCustomer(string phoneNumber)
        {

            return context.CUSTOMER.FirstOrDefault(x => x.PhoneNumber == phoneNumber);
        }

        public static bool IS_PhoneNumbeExist(string phoneNumber)
        {
            return context.CUSTOMER.Any(x => x.PhoneNumber == phoneNumber);
        }
        
        public static void AddCustomer(CUSTOMER customer)
        { 
            context.CUSTOMER.Add(customer);
            context.SaveChanges();
            MessageBox.Show("Thêm thành công!", "Thông báo");
        }

        public static void UpdateCustomer(CUSTOMER customer)
        {
           
            context.CUSTOMER.AddOrUpdate(customer);
            context.SaveChanges();
            MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo");
        }
    }
}
