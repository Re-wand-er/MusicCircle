using System.Windows.Controls;
using MusicCircle.Settings.CircleSettingsWindow.Pages.PageViewModel;

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
            this.DataContext = ChordPageVM.Instance;//GlobalService.Instance.ChordPage;
            //this.DataContext = CustomSecterMajorButton.
        }
    }
}
