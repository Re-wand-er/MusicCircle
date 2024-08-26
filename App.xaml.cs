using System;
using System.Windows;

namespace MusicCircle
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        static void Main()
        {
            App app = new App();
            MainWindow window = new MainWindow();
            window.Title = "MusicCircle";
            app.Run(window);
        }
    }
}
