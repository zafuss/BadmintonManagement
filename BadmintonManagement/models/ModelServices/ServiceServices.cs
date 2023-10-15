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
    public class ServiceServices
    {
        static ModelBadmintonManage context = new ModelBadmintonManage();

        public static List<C_SERVICE> GetAllService()
        {
            return context.C_SERVICE.ToList();
        }

        public static C_SERVICE GetService(string serviceName)
        {
            return context.C_SERVICE.FirstOrDefault(x => x.ServiceName == serviceName);
        }

        public static C_SERVICE GetServiceID(string serviceID)
        {
            return context.C_SERVICE.FirstOrDefault(x => x.ServiceID == serviceID);
        }

        public static bool IS_ServiceNameExist(string serviceName)
        {
            return context.C_SERVICE.Any(x => x.ServiceName == serviceName);
        }
        public static bool IS_ServiceIDExist(string id)
        {
            return context.C_SERVICE.Any(x => x.ServiceID == id);
        }
        public static void AddSerivce(C_SERVICE service, Action bindGrid)
        {
            try
            {
                if (IS_ServiceIDExist(service.ServiceID) || IS_ServiceNameExist(service.ServiceName))
                {
                    throw new Exception("Dịch vụ này đã tồn tại trong hệ thống");
                }
                context.C_SERVICE.Add(service);
                context.SaveChanges();
                MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo");
                bindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }

        public static void UpdateService(C_SERVICE service, string selectedServiceID, string selectedServiceName)
        {
            if (!IS_ServiceIDExist(service.ServiceID))
                throw new Exception("Không tồn tại dịch vụ này trong hệ thống");       
            if (IS_ServiceIDExist(service.ServiceID) && service.ServiceID != selectedServiceID)
                throw new Exception("Mã dịch vụ đã tồn tại!");
            if (IS_ServiceNameExist(service.ServiceName) && service.ServiceName != selectedServiceName)            
                throw new Exception("Tên dịch vụ đã tồn tại!");            
            context.C_SERVICE.AddOrUpdate(service);
            MessageBox.Show("Chỉnh sửa dịch vụ thành công!", "Thông báo");
            context.SaveChanges();
        }

        public static void DeleteService(string serviceName)
        {
            var delService = GetService(serviceName);
            if (!IS_ServiceIDExist(delService.ServiceID))
            {
                throw new Exception("Không tìm thấy dịch vụ cần xoá");
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá dịch vụ này?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                context.C_SERVICE.Remove(delService);
                context.SaveChanges();
                MessageBox.Show("Thêm user thành công!", "Thông báo");
            }
        }

        //public static void DisableService(string username)
        //{
        //    C_SERVICE tmpService = GetService(username);
        //    if (tmpService.C_Status == "Enabled")
        //        tmpService.C_Status = "Disabled";
        //    else tmpService.C_Status = "Enabled";
        //    context.C_SERVICE.AddOrUpdate(tmpService);
        //    context.SaveChanges();
        //}

        public static void DisableServiceID(string serviceID)
        {
            C_SERVICE tmpService = GetServiceID(serviceID);
            if (tmpService.C_Status == "Enabled")
                tmpService.C_Status = "Disabled";
            else tmpService.C_Status = "Enabled";
            context.C_SERVICE.AddOrUpdate(tmpService);
            context.SaveChanges();
        }



    }

}

