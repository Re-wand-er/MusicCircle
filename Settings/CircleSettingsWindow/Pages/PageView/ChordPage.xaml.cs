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
            DataContext = new PageViewModel.ChordPageVM();
        }
    }
}
