using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Database
{
    class ServiceReceiptServices
    {
        static ModelBadmintonManage context = new ModelBadmintonManage();

        public static List<SERVICE_RECEIPT> GetAllServiceReceipt()
        {
            return context.SERVICE_RECEIPT.ToList();
        }

        public static SERVICE_RECEIPT GetServiceReceipt(string serviceReceiptNo)
        {

            return context.SERVICE_RECEIPT.FirstOrDefault(x => x.ServiceReceiptNo == serviceReceiptNo);
        }

        public static bool IS_ServiceReceiptNoExist(string serviceReceiptNo)
        {
            return context.SERVICE_RECEIPT.Any(x => x.ServiceReceiptNo == serviceReceiptNo);
        }
        public static void AddSerivceReceipt(SERVICE_RECEIPT serviceReceipt, Action bindGrid)
        {
            try
            {
                if (IS_ServiceReceiptNoExist(serviceReceipt.ServiceReceiptNo))
                {
                    throw new Exception("Hoá đơn đã tồn tại");
                }
                context.SERVICE_RECEIPT.Add(serviceReceipt);
                context.SaveChanges();
                MessageBox.Show("Thêm hoá đơn dịch vụ thành công!", "Thông báo");
                bindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }

        //public static void UpdateService(SERVICE_RECEIPT service, string selectedServiceID, string selectedServiceName)
        //{
        //    if (!IS_ServiceIDExist(service.ServiceID))
        //        throw new Exception("Không tồn tại dịch vụ này trong hệ thống");
        //    if (IS_ServiceIDExist(service.ServiceID) && service.ServiceID != selectedServiceID)
        //        throw new Exception("Mã dịch vụ đã tồn tại!");
        //    if (IS_ServiceNameExist(service.ServiceName) && service.ServiceName != selectedServiceName)
        //        throw new Exception("Tên dịch vụ đã tồn tại!");
        //    context.SERVICE_RECEIPT.AddOrUpdate(service);
        //    MessageBox.Show("Chỉnh sửa dịch vụ thành công!", "Thông báo");
        //    context.SaveChanges();
        //}

        //public static void DeleteService(string serviceName)
        //{
        //    var delService = GetService(serviceName);
        //    if (!IS_ServiceIDExist(delService.ServiceID))
        //    {
        //        throw new Exception("Không tìm thấy dịch vụ cần xoá");
        //    }
        //    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá dịch vụ này?", "Cảnh báo", MessageBoxButtons.YesNo);
        //    if (dialogResult == DialogResult.Yes)
        //    {
        //        context.SERVICE_RECEIPT.Remove(delService);
        //        context.SaveChanges();
        //        MessageBox.Show("Thêm user thành công!", "Thông báo");
        //    }
        //}


    }
}
