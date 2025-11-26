using System;
using System.IO;
using Newtonsoft.Json;

namespace UniGate.Client.Utils
{
    public static class SessionManager
    {
        private static readonly string SessionPath =
            Path.Combine(AppContext.BaseDirectory, "session.client.json");

        public static Guid UserId { get;  set; }
        public static string Email { get; private set; }
        public static string Token { get; private set; }

        // =============================
        //   LƯU SESSION SAU KHI LOGIN
        // =============================
        public static void SaveSession(Guid userId, string email, string token)
        {
            UserId = userId;
            Email = email;
            Token = token;

            var obj = new
            {
                UserId = userId,
                Email = email,
                Token = token
            };

            File.WriteAllText(SessionPath, JsonConvert.SerializeObject(obj, Formatting.Indented));
        }

        // =============================
        //   LOAD SESSION KHI MỞ APP
        // =============================
        public static void LoadSession()
        {
            if (!File.Exists(SessionPath))
                return;

            var text = File.ReadAllText(SessionPath);

            try
            {
                dynamic data = JsonConvert.DeserializeObject(text);
                UserId = Guid.Parse((string)data.UserId);
                Email = data.Email;
                Token = data.Token;
            }
            catch
            {
                // file lỗi thì bỏ qua
            }
        }

        // =============================
        //   XOÁ SESSION KHI LOGOUT
        // =============================
        public static void Clear()
        {
            UserId = Guid.Empty;
            Email = null;
            Token = null;

            if (File.Exists(SessionPath))
                File.Delete(SessionPath);
        }

        // =============================
        //   KIỂM TRA ĐÃ ĐĂNG NHẬP?
        // =============================
        public static bool IsLoggedIn => UserId != Guid.Empty;
    }
}
