using MusicCircle.Settings;
using System;
using System.Windows;

namespace MusicCircle
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        SettingsManager settings = SettingsManager.Instance;

        [STAThread]
        static void Main()
        {
            App app = new App();
            MainWindow window = new MainWindow();
            window.Title = "MusicCircle";
            app.Run(window);
        }

        protected override void OnStartup(StartupEventArgs e)
        {   
            settings.LoadSettings();
            base.OnStartup(e);
            
            
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            settings.SaveSettings();
        }
    }
}
