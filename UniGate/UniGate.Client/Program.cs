using System;
using System.Windows.Forms; // Dòng này quan trọng

// Xóa các using dư thừa nếu cần
using UniGate.Client.Forms;
// using UniGate.Client.Forms.Auth; // Giữ lại nếu bạn dùng Form đăng nhập

namespace UniGate.Client
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Tắt ApplicationConfiguration.Initialize() để tránh lỗi
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            System.Windows.Forms.Application.Run(new SuggestForm());
        }
    }
}