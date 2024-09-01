using MusicCircle.Interface;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace MusicCircle.Settings.CircleSettingsWindow.Pages.PageView
{
    /// <summary>
    /// Логика взаимодействия для ChordPage.xaml
    /// </summary>
    public partial class ChordPage : UserControl
    {
        public ChordPage()
        {
            InitializeComponent();
            this.DataContext = GlobalService.Instance.ChordPage;
            //this.DataContext = CustomSecterMajorButton.
        }
    }
}
