using Newtonsoft.Json;
using System.Net.Http.Json;
using UniGate.Shared;

public static class ApiClient
{
    private static readonly string BaseUrl = SharedConfig.ApiBaseUrl;

    public static async Task<T> GetAsync<T>(string url)
    {
        using var client = new HttpClient();
        var res = await client.GetAsync(BaseUrl + url);
        res.EnsureSuccessStatusCode();

        string json = await res.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(json);
    }

    public static async Task<string> PostAsync(string url, object data)
    {
        using var client = new HttpClient();
        var res = await client.PostAsJsonAsync(BaseUrl + url, data);
        return await res.Content.ReadAsStringAsync();
    }

    public static async Task<string> PutAsync(string url, object data)
    {
        using var client = new HttpClient();
        var res = await client.PutAsJsonAsync(BaseUrl + url, data);
        return await res.Content.ReadAsStringAsync();
    }

    public static async Task DeleteAsync(string url)
    {
        using var client = new HttpClient();
        var res = await client.DeleteAsync(BaseUrl + url);
        res.EnsureSuccessStatusCode();
    }

    public static async Task<bool> UploadFileAsync(string url, string filePath)
    {
        using var client = new HttpClient();
        using var form = new MultipartFormDataContent();
        using var stream = File.OpenRead(filePath);

        form.Add(new StreamContent(stream), "file", Path.GetFileName(filePath));

        var res = await client.PostAsync(BaseUrl + url, form);
        return res.IsSuccessStatusCode;
    }
}
