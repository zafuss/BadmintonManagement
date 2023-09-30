using BadmintonManagement.Database;
using BadmintonManagement.Forms.AuthorizationForms;
using BadmintonManagement.Models;
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

        public static string mailTrailing = "\n---------------------------------------\r\nCông Ty Cổ Phần TOD\r\nPhone: 0823 216 213\r\nEmail: todreamscompany@gmail.com";
        public static string htmlMailTrailing = "<br>---------------------------------------<br><br>Công Ty Cổ Phần TOD<br>Phone: 0823 216 213<br>Email: todreamscompany@gmail.com";

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
        public static void SendFirstEmail(C_USER user, string password, Action callback)
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(sendEmail);
                mail.To.Add(user.Email);
                mail.Subject = "[TOD] Công ty Theatre Of Dreams";
                int code = RandomOTPCode();
                mail.IsBodyHtml = true; // Đánh dấu nội dung email là HTML

                mail.Body = $@"Chào {user.C_Name},<br><br>
                Chúng tôi rất vui mừng thông báo rằng bạn đã được chấp nhận tham gia vào đội ngũ của chúng tôi tại TOD Company. 
                Chúng tôi rất mong chờ sự đóng góp và thành công của bạn trong công việc mới này.<br><br>
                Dưới đây là thông tin đăng nhập của bạn vào hệ thống của chúng tôi:<br><br>
                <b>Tên người dùng (Username): {user.Username}</b><br>
                <b>Mật khẩu (Password):  {password}</b><br>
                 - <i style=""color: red;"">Lưu ý: Hãy bảo mật thông tin này và không chia sẻ với người khác</i><br><br>
                Vui lòng sử dụng thông tin đăng nhập trên để truy cập vào hệ thống của chúng tôi tại ứng dụng Badminton Management.<br><br>
                Nếu bạn gặp bất kỳ vấn đề nào trong quá trình đăng nhập hoặc cần sự hỗ trợ, xin vui lòng liên hệ với đội ngũ admin tại {sendEmail} hoặc số điện thoại 0823216213.<br><br>
                Chúng tôi hy vọng bạn sẽ có một trải nghiệm làm việc thú vị và có ích tại TOD Company, và chúng tôi rất mong được làm việc cùng bạn.<br><br>
                Xin chân thành cảm ơn và chúc mừng bạn thêm một lần nữa!<br>
                {htmlMailTrailing}";


                SmtpServer.EnableSsl = true;
                SmtpServer.Port = 587;
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.Credentials = new System.Net.NetworkCredential(sendEmail, appPassword);
                SmtpServer.Send(mail);

                callback.Invoke();
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
