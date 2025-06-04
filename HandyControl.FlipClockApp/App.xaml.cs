using HandyControl.FlipClockApp.Service;
using HandyControl.FlipClockApp.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace HandyControl.FlipClockApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; private set; }

        public App()
        {
            Services = ConfigureServices();
            this.InitializeComponent();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Services.GetService<MainWindow>()?.Show();
        }

        private IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<ISettingsService, JsonSettingsService>();
            services.AddSingleton<IWindowService, WindowService>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>();

            return services.BuildServiceProvider();
        }
    }

}
