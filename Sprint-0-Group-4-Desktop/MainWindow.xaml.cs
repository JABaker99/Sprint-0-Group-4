using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sprint_0_Group_4.Data;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace Sprint_0_Group_4_Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AppDbContext _context;

        public MainWindow()
        {
            InitializeComponent();
            _context = CreateDbContext();
            Loaded += async (_, __) => await LoadUsersAsync();
        }

        private static AppDbContext CreateDbContext()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connStr = config.GetConnectionString("WebApiPostgreSQLLocalDatabase")
                ?? throw new InvalidOperationException("Missing connection string: WebApiPostgreSQLLocalDatabase");

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseNpgsql(connStr)
                .Options;

            return new AppDbContext(options);
        }

        private async Task LoadUsersAsync()
        {
            try
            {
                var users = await _context.AppUser.AsNoTracking().ToListAsync();
                UsersGrid.ItemsSource = users;
                NoUsersText.Visibility = users.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "DB Load Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
