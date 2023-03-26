using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace View {
    public class Program {
        public static void Main(string[] args) {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}

// cd .../imdb/Model
// dotnet ef --startup-project ../View migrations add mig1
// dotnet ef --startup-project ../View database update