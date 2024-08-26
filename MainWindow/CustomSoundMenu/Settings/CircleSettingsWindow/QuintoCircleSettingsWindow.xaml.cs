using System.Windows;
using MusicCircle.Settings.CircleSettingsWindow.Pages.PageViewModel;

namespace MusicCircle.Settings
{
    public partial class QuintoCircleSettingsWindow : Window
    {
        public QuintoCircleSettingsWindow()
        {
            InitializeComponent();

            this.DataContext = new SettingsViewModel(
                new PageSettingsModel("Аккорды", new ChordPageVM()), 
                new PageSettingsModel("Внешний вид", new VolumePageVM())
            );
        }
    }
}
