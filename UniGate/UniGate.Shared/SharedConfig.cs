using Microsoft.Extensions.Configuration;

namespace UniGate.Shared
{
    public static class SharedConfig
    {
        public static IConfiguration Configuration { get; private set; }

        static SharedConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.shared.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }

        public static string ApiBaseUrl =>
            Configuration["ApiBaseUrl"]!;
    }
}
