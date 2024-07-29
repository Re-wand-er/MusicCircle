using System;
using System.CodeDom;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MusicCircle.Settings;

namespace MusicCircle
{
    /// <summary>
    /// Логика взаимодействия для CustomSoundMenu.xaml
    /// </summary>
    public partial class CustomSoundMenu : UserControl
    {
        private Window _window;
        public CustomSoundMenu()
        {
            InitializeComponent();
        }
        // Не работают
        private void QuartoQuintoCircleSettings_Click(object sender, RoutedEventArgs e)
        {
            if (_window == null)
            {
                _window = new QuintoCircleSettingsWindow();
                _window.Closed += Window_Closed;
                _window.ShowDialog();
            }
            else
            {
                _window.Activate();
            }

            /*QuintoCircleSettingsWindow circle = new QuintoCircleSettingsWindow();
            
            circle.Show();*/
        }

        private void VirtualPianoSettings_Click(object sender, RoutedEventArgs e)
        {
            if (_window == null)
            {
                _window = new VirtualPianoSettingsWindow();
                _window.Closed += Window_Closed;
                _window.ShowDialog();
            }
            else
            {
                _window.Activate();
            }
            /*VirtualPianoSettingsWindow piano = new VirtualPianoSettingsWindow();

             piano.Show();*/
        }

        private void GeneralSettings_Click(object sender, RoutedEventArgs e)
        {
            if (_window == null)
            {
                _window = new GeneralSettingsWindow();
                _window.Closed += Window_Closed;
                _window.ShowDialog();
            }
            else
            {
                _window.Activate();
            }

            /*GeneralSettingsWindow general = new GeneralSettingsWindow();

            general.Show();*/
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            _window = null;
        }
    }
}
