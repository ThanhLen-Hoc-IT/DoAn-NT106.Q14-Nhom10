using System;
using System.Windows.Forms;
using YourProjectNamespace;

// Đảm bảo tên namespace này trùng khớp với namespace bạn đã đặt trong ResultsMajor.cs
// Dựa trên hình ảnh Solution Explorer của bạn, tôi tạm đặt là FormResult
namespace FormResult
{
    static class Program
    {
        /// <summary>
        /// Điểm vào chính của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Cài đặt hiển thị mặc định của WinForms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ************************************************************
            // DÒNG CODE QUAN TRỌNG NHẤT: Khởi tạo và chạy Form chính
            // ************************************************************
            // Thay vì chạy Form mặc định (ví dụ: Form1), chúng ta chạy Form ResultsMajor.
            Application.Run(new ResultsMajor());
        }
    }
}