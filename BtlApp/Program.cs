using BtlApp.Individual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BtlApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form_Login());
            //Application.Run(new Form_Manager());

            Form_Login loginForm = new Form_Login();

            // Sử dụng vòng lặp while(true) để xử lý việc logout
            while (true)
            {
                // 1. Hiển thị Form_Login bằng ShowDialog()
                // Chương trình sẽ dừng ở đây cho đến khi Form_Login đóng lại
                loginForm.ShowDialog();

                // 2. Kiểm tra xem user đã đăng nhập thành công hay chưa
                if (loginForm.IsLoggedIn())
                {
                    // 3. Lấy UserId ra
                    string userId = loginForm.getUserId();

                    // 4. Tạo Form_Manager với UserId đó
                    Form_Manager managerForm = new Form_Manager(userId);

                    // 5. Chạy Form_Manager
                    // Application.Run() sẽ giữ app chạy cho đến khi managerForm đóng
                    Application.Run(managerForm);

                    // 6. (Sau khi Form_Manager đóng) Kiểm tra xem có phải user nhấn "Logout" không
                    if (managerForm.IsLogout())
                    {
                        // Nếu đúng là logout, tạo lại form login để vòng lặp chạy lại
                        loginForm = new Form_Login();
                        // Tiếp tục vòng lặp (continue)
                    }
                    else
                    {
                        // Nếu Form_Manager đóng mà không phải do logout (ví dụ: nhấn nút X)
                        // thì thoát khỏi vòng lặp và đóng ứng dụng
                        break;
                    }
                }
                else
                {
                    // 7. Nếu user đóng Form_Login mà không đăng nhập
                    // thì thoát khỏi vòng lặp và đóng ứng dụng
                    break;
                }
            }
        }
    }
}
