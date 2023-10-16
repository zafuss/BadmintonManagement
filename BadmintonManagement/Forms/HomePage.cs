using BadmintonManagement.Database;
using BadmintonManagement.Forms;
using BadmintonManagement.Forms.Court;
using BadmintonManagement.Forms.Customer;
using BadmintonManagement.Forms.Price;
using BadmintonManagement.Forms.Receipt;
using BadmintonManagement.Forms.Report;
using BadmintonManagement.Forms.ReservationCourt;
using BadmintonManagement.Forms.ReservationCourt.BookingForm;
using BadmintonManagement.Forms.Service;
using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.AuthorizationForms
{
    public partial class HomePage : Form
    {
        //private Form activeForm = null;
        Image closeImage, closeImageAct;
        public HomePage()
        {
            InitializeComponent();
        }

        
        // Đóng ứng dụng khi form HomePage được đóng.
        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        // Kiểm tra xem một tab với cùng tiêu đề như form đã tồn tại chưa.
        private int CheckExist(Form form)
        {
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                if (tabControl.TabPages[i].Text == form.Text.Trim())
                    return i;

            }
            return -1;
        }
        // Thêm trang tab mới cho form hoặc chuyển đến tab hiện tại nếu nó đã tồn tại.
        private void AddTabPages(Form form)
        {
            int checkExist = CheckExist(form);
            if (checkExist >= 0)
            {
                if (tabControl.SelectedTab == tabControl.TabPages[checkExist])
                {

                }
                else
                {
                    tabControl.SelectedTab = tabControl.TabPages[checkExist];
                }
            }
            else
            {
                TabPage newTab = new TabPage(form.Text.Trim());
                tabControl.TabPages.Add(newTab);
                form.TopLevel = false;
                form.Parent = newTab;
                tabControl.SelectedTab = tabControl.TabPages[tabControl.TabCount - 1];
                form.Show();
                form.Dock = DockStyle.Fill;

            }
        }
        // Đóng một tab khi nút đóng được nhấn trên tab đó. 
        private void tabControl_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                Rectangle rect = tabControl.GetTabRect(i);
                Rectangle imageRect = new Rectangle(rect.Right - closeImage.Width, rect.Top + (rect.Height - closeImage.Height) / 2, closeImage.Width, closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    tabControl.TabPages.Remove(tabControl.SelectedTab);
                }
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // Khởi tạo form và hiển thị các yếu tố giao diện người dùng liên quan dựa vào vai trò của người dùng.
            Size mySize = new System.Drawing.Size(20, 20);
            Bitmap bitmap = new Bitmap(Properties.Resources.closeAct);
            Bitmap btm = new Bitmap(bitmap, mySize);
            closeImageAct = btm;

            Bitmap bitmap1 = new Bitmap(Properties.Resources.close);
            Bitmap btm2 = new Bitmap(bitmap1, mySize);
            closeImage = btm2;
            tabControl.Padding = new Point(30);
            if (Properties.Settings.Default.Role == "Admin")
            {
                btnUser.Visible = true;
                btnPrice.Visible = true;
                toolStripSeparator1.Visible = true;
            }
            else
            {
                btnUser.Visible = false;
                btnPrice.Visible = false;
                toolStripSeparator1.Visible = false;
            }
            lblEmployeeName.Text = "Nhân viên: " + Properties.Settings.Default._Name;
            // kiểm tra và cập nhật trạng thái đặt sân thời gian thực
            bool t = RealTimeCaptureStatusReservation();
            AddTabPages(new CourtForm());
            ApplyFactor.LoadFile();
            ModelBadmintonManage context = new ModelBadmintonManage();
            PriceForm.GBPriceID = context.PRICE.FirstOrDefault(p => p.C_Status == 1).PriceID;
            Booking.LoadFileBooking();

        }

        // mở form quản lý user
        private void btnUser_Click(object sender, EventArgs e)
        {
            AddTabPages(new ManageUser());
        }
        // mở form quản lý sân
        private void btnCourt_Click(object sender, EventArgs e)
        {
            AddTabPages(new CourtForm());
        }
        // mở form quản lý khách hàng
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AddTabPages(new CustomerForm());
        }
        // mở form quản lý dịch vụ
        private void btnService_Click_1(object sender, EventArgs e)
        {
            AddTabPages(new ServiceForm());
        }
        // mở form quản lý  đặt sân
        private void btnReservation_Click(object sender, EventArgs e)
        {
            AddTabPages(new ReservationForm());
        }
        // mở form xem hóa đơn
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            AddTabPages(new ReceiptForm());
        }
        // mở form quản lý bảng giá
        private void btnPrice_Click(object sender, EventArgs e)
        {
            AddTabPages(new PriceForm());
        }
        // mở form báo cáo thống kê
        private void btnReport_Click_1(object sender, EventArgs e)
        {
            AddTabPages(new ReportForm());

        }
        private void trungTâmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTabPages(new AccountCenterForm());
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            UserServices.LogoutUser();
        }
        

        // kiểm tra xem có sự thay đổi trong trạng thái đặt sân không
        private bool RealTimeCaptureStatusReservation()
        {
            ModelBadmintonManage context = new ModelBadmintonManage();
            bool change = false;
            List<RESERVATION> listRev = context.RESERVATION.ToList();
            foreach (RESERVATION rev in listRev)
            {
                DateTime d = rev.StartTime;
                int s = DateTime.Compare(d.Date, DateTime.Now.Date);
                if (rev.C_Status == 2 && DateTime.Compare(rev.EndTime, DateTime.Now) <= 0)
                {
                    rev.C_Status = 3;
                    if (Application.OpenForms["CourtForm"] != null && !Application.OpenForms["CourtForm"].IsDisposed)
                    {
                        CourtForm.Instance.ReLoad();
                    }
                }
                else
                if (s > 0 || rev.C_Status > 1)
                    continue;
                if (s == 0)
                {
                    if ((d.Hour * 60 + d.Minute - DateTime.Now.Hour * 60 - DateTime.Now.Minute) < -30)
                    {
                        if (rev.C_Status == 0)
                            rev.C_Status = 5;
                        else if (rev.C_Status == 1)
                            rev.C_Status = 6;
                        context.RESERVATION.AddOrUpdate(rev);
                        context.SaveChanges();
                        change = true;
                    }
                }
                else if (s < 0)
                {
                    if (rev.C_Status == 0)
                        rev.C_Status = 5;
                    else if (rev.C_Status == 1)
                        rev.C_Status = 6;
                    context.RESERVATION.AddOrUpdate(rev);
                    context.SaveChanges();
                    change = true;
                }
            }
            return change;
        }
        // Cập nhật thời gian thực trạng thái đặt sân
        private void timerRealTimeStatusCapture_Tick(object sender, EventArgs e)
        {
           
            bool t = RealTimeCaptureStatusReservation();
        }
        // Cập nhật hiển thị thời gian trên Homepage
        public void tmrRload_Tick(object sender, EventArgs e)
        {
            lblTime.Text = String.Format("{0}  {1}", DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("bạn có muốn thoát?","YES/NO",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Vẽ giao diện của các tab trên tabControl
            Rectangle rect = tabControl.GetTabRect(e.Index);
            Rectangle imageRect = new Rectangle(rect.Right - closeImage.Width, rect.Top + (rect.Height - closeImage.Width) / 2, closeImage.Width, closeImage.Height);
            rect.Size = new Size(rect.Width + 24, 38);
            Font font;
            Brush brush = Brushes.Black;
            StringFormat strFormat = new StringFormat(StringFormat.GenericDefault);
            // Kiểm tra xem tab hiện tại có được chọn hay không
            if (tabControl.SelectedTab == tabControl.TabPages[e.Index])
            {
                // Nếu tab được chọn, vẽ một hình ảnh đóng tab và sử dụng font đậm
                e.Graphics.DrawImage(closeImage, imageRect);
                font = new Font("Segoe UI", 12, FontStyle.Bold);
                e.Graphics.DrawString(tabControl.TabPages[e.Index].Text, font, brush, rect, strFormat);
            }
            else
            {
                // Nếu tab không được chọn, vẽ hình ảnh đóng tab và sử dụng font thường
                e.Graphics.DrawImage(closeImage, imageRect);
                font = new Font("Segoe UI", 11, FontStyle.Regular);
                e.Graphics.DrawString(tabControl.TabPages[e.Index].Text, font, brush, rect, strFormat);
            }

        }



    }
}
