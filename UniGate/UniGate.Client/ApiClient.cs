using System.Net.Http;
using System.Text;
using Newtonsoft.Json;   // <<< CHỈ DÙNG NEWTONSOFT
using UniGate.Shared;

namespace UniGate.Client
{
    public static class ApiClient
    {
        private static readonly HttpClient _http = new HttpClient
        {
            BaseAddress = new Uri(SharedConfig.ApiBaseUrl)
        };

        // ============================
        //              GET
        // ============================
        public static async Task<T> GetAsync<T>(string url)
        {
            var response = await _http.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(json);
        }

        // ============================
        //              POST
        // ============================
        public static async Task<string> PostAsync(string url, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _http.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        // ============================
        //              PUT
        // ============================
        public static async Task<string> PutAsync(string url, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _http.PutAsync(url, content);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        // ============================
        //           DELETE
        // ============================
        public static async Task<string> DeleteAsync(string url)
        {
            var response = await _http.DeleteAsync(url);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
