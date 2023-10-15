using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Database
{
    public class PriceServices
    {
        static ModelBadmintonManage contextDB = new ModelBadmintonManage();

        public static List<PRICE> GetAllPrice()
        {
            return contextDB.PRICE.ToList();
        }

        public static PRICE GetPrice(string priceID)
        {
            return contextDB.PRICE.Find(priceID);
        }

        public static bool IsPriceExist(string priceID) { 
            return contextDB.PRICE.Any(p=>p.PriceID==priceID);
        }
        public static void AddPrice(PRICE price)
        {
            try
            {
                if(IsPriceExist(price.PriceID))
                    throw new Exception("Mã Giá đã tồn tại");
                contextDB.PRICE.Add(price);
                contextDB.SaveChanges();
                MessageBox.Show(" Thêm giá thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateStatusPrice(PRICE price) {
            try
            {
                if (!IsPriceExist(price.PriceID))
                    throw new Exception("Mã giá này không tồn tại");
                contextDB.PRICE.Add(price);
                contextDB.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
