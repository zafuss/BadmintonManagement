using BadmintonManagement.Database;
using BadmintonManagement.Forms.AuthorizationForms;
using BadmintonManagement.Models;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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

        public static void SendDisabledMail(string receiveEmail)
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(sendEmail);
                mail.To.Add(receiveEmail);
                mail.Subject = "[TOD] Công ty Theatre Of Dreams";
                mail.IsBodyHtml = true; // Đánh dấu nội dung email là HTML
                var user = UserServices.GetUserByEmail(receiveEmail);
                mail.Body = $@"Chào {user.C_Name},<br><br>
                Tài khoản của bạn đã bị vô hiệu hoá!.<br><br>
                Nếu bạn không yêu cầu thực hiện thay đổi này, vui lòng liên hệ admin để được hỗ trợ. <br></br>
                {htmlMailTrailing}";

                SmtpServer.EnableSsl = true;
                SmtpServer.Port = 587;
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.Credentials = new System.Net.NetworkCredential(sendEmail, appPassword);

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static void SendChangedInformationMail(string receiveEmail, string newPassword)
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(sendEmail);
                mail.To.Add(receiveEmail);
                mail.Subject = "[TOD] Công ty Theatre Of Dreams";
                mail.IsBodyHtml = true; // Đánh dấu nội dung email là HTML
                var user = UserServices.GetUserByEmail(receiveEmail);
                string mailBody = $@"Chào {user.C_Name},<br><br>
                Một số thông tin cá nhân của bạn đã được thay đổi.<br><br>
                Nếu bạn không yêu cầu thực hiện thay đổi này, vui lòng liên hệ admin để được hỗ trợ. <br></br>
                ";
                if (newPassword != null)
                    mailBody += $@"Dưới đây là mật khẩu đăng nhập mới của bạn vào hệ thống của chúng tôi:<br><br>
                <b>Mật khẩu (Password): {newPassword}</b><br>
                 - <i style=""color: red;"">Lưu ý: Hãy bảo mật thông tin này và không chia sẻ với người khác</i><br><br>
                Vui lòng sử dụng thông tin đăng nhập trên để truy cập vào hệ thống của chúng tôi tại ứng dụng Badminton Management.<br><br>
                Nếu bạn gặp bất kỳ vấn đề nào trong quá trình đăng nhập hoặc cần sự hỗ trợ, xin vui lòng liên hệ với đội ngũ admin tại {sendEmail} hoặc số điện thoại 0823216213.<br><br>
                Chúng tôi hy vọng bạn sẽ có một trải nghiệm làm việc thú vị và có ích tại TOD Company, và chúng tôi rất mong được làm việc cùng bạn.<br><br>
               <br>
               ";
                mail.Body = mailBody + $@" {htmlMailTrailing}";
                SmtpServer.EnableSsl = true;
                SmtpServer.Port = 587;
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.Credentials = new System.Net.NetworkCredential(sendEmail, appPassword);

                SmtpServer.Send(mail);
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
                var forgotUser = UserServices.GetUserByEmail(receiveEmail);
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(sendEmail);
                mail.To.Add(receiveEmail);
                mail.Subject = "[TOD] Công ty Theatre Of Dreams";
                int code = RandomOTPCode();
                mail.IsBodyHtml = true;
                mail.Body = @$"Chào {forgotUser.C_Name}, <br></br>

                Chúng tôi đã nhận được yêu cầu của bạn để cập nhật mật khẩu cho tài khoản của mình. Để tiếp tục quá trình này, vui lòng sử dụng mã <strong>OTP (One-Time Password)</strong> sau đây để xác thực tài khoản của bạn:<br></br>

                Mã OTP: <strong>{RandomOTPCode()} </strong><br></br>

                Mã OTP này chỉ có giá trị trong một thời gian ngắn và sẽ hết hạn sau <strong>1 phút</strong>. Vui lòng không chia sẻ mã OTP này với bất kỳ ai khác và không điền nó trên bất kỳ trang web hoặc ứng dùng nào khác ngoài ứng dụng Badminton Management.<br></br>

                Sau khi nhập mã OTP, bạn sẽ được định hướng đến cửa sổ khác để đặt lại mật khẩu mới cho tài khoản của bạn. Xin lưu ý rằng bạn sẽ cần tuân theo các hướng dẫn trên ứng dụng để hoàn tất quá trình cập nhật mật khẩu.<br></br>

                Nếu bạn không yêu cầu cập nhật mật khẩu hoặc có bất kỳ câu hỏi hoặc thắc mắc nào, xin vui lòng liên hệ với bộ phận hỗ trợ của chúng tôi tại {sendEmail}.<br></br>

                Xin cảm ơn bạn đã duy trì an toàn cho tài khoản của mình.<br></br> {htmlMailTrailing}
                ";
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
