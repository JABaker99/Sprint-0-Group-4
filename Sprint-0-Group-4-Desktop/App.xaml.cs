using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sprint_0_Group_4.Data;
using System.IO;
using System.Windows;

namespace Sprint_0_Group_4_Desktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static AppDbContext Db { get; private set; } = default!;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connStr = config.GetConnectionString("WebApiPostgreSQLLocalDatabase")
                ?? throw new InvalidOperationException("Missing connection string");

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseNpgsql(connStr)
                .Options;

            Db = new AppDbContext(options);

            new MainWindow().Show();
        }
    }

}
