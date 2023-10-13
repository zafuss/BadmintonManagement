using BadmintonManagement.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace BadmintonManagement
{
    public partial class EnterOTP : Form
    {
        string receiveEmail;
        string otpCode;
        Action callback;
        private static int validityOTPperiod = 60;
        private Timer timer;

        private void EnterActiveOTP_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Mã xác nhận đã được gửi vào email " + receiveEmail + "\nHãy nhập mã xác nhận vào ô bên dưới: \n";
            TimerInit();
            btnSendAgain.Enabled = false;
        }
        public EnterOTP(string receiveEmail, string otpCode, Action callback)
        {
            this.receiveEmail = receiveEmail;
            this.otpCode = otpCode;
            this.callback = callback;

            InitializeComponent();
        }

        private void TimerInit()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(Timer_Tick); //Tạo sự kiện aTimer_Tick
            timer.Interval = 1000; // thời gian ngắt quãng của Timer là 1 giây
            timer.Start(); //Bắt đầu khởi động Timer
        }

        private void btnSendAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            validityOTPperiod = 60;
            var user = UserServices.GetUserByEmail(receiveEmail);
            OTPService.SendFirstEmail(user, receiveEmail, callback);
        }

        private void Timer_Tick(object sender, EventArgs e)// hàm đếm ngược thời gian

        {

            validityOTPperiod--;
            if (validityOTPperiod == 0)
            {
                btnEnterOTP.Enabled = false;
                btnSendAgain.Enabled = true;
                timer.Stop();
                btnSendAgain.Text = "Gửi lại";
            }

            btnSendAgain.Text = "Gửi lại (" + validityOTPperiod.ToString() + ")";

        }

        private void btnEnterOTP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOTPCode.Text == otpCode && validityOTPperiod > 0)
                {
                    callback.Invoke();
                    this.Close();
                }
                else if (validityOTPperiod == 0)
                    throw new Exception("Hết thời gian chờ! Vui lòng bấm gửi lại OTP");
                else if (txtOTPCode.Text != otpCode)
                    throw new Exception("Sai mã OTP");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void EnterOTP_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnEnterOTP.Enabled = true;
            btnSendAgain.Enabled = false;
            timer.Stop();
            validityOTPperiod = 60;

        }
    }
}
