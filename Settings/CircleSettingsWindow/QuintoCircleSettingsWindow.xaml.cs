using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MusicCircle.Settings.CircleSettingsWindow.Pages.PageViewModel;
namespace MusicCircle.Settings
{
    public partial class QuintoCircleSettingsWindow : Window
    {
        public QuintoCircleSettingsWindow()
        {
            InitializeComponent();

            this.DataContext = new SettingsViewModel(
                new PageSettingsModel("Привет земля", new ChordPageVM()), 
                new PageSettingsModel("Пока земля", new VolumePageVM())
            );
        }
    }
}
