using System.Windows.Controls;
using MusicCircle.Settings.CircleSettingsWindow.Pages.PageViewModel;

namespace MusicCircle.Interface
{
    /// <summary>
    /// Логика взаимодействия для CustomSecterMajorButton.xaml
    /// </summary>
    public partial class CustomSecterMajorButton : UserControl
    {
        //ChordPageVM chordPageVM;
        public CustomSecterMajorButton()
        {
            InitializeComponent();
            //chordPageVM = new ChordPageVM();
            //DataContext = App.chordpage;
            this.DataContext = ChordPageVM.Instance;//GlobalService.Instance.ChordPage;
           
        }

        //private async void button_CMajor_Click(object sender, RoutedEventArgs e)
        //{
        //    await ChordSound.Play("C E G");
        //}
        //private async void button_GMagor_Click(object sender, RoutedEventArgs e)
        //{
        //    await ChordSound.Play("G B D");
        //}
        //private async void button_DMajor_Click(object sender, RoutedEventArgs e)
        //{
        //    await ChordSound.Play("D F# A");
        //}
        //private async void button_AMajor_Click(object sender, RoutedEventArgs e)
        //{
        //    await ChordSound.Play("A C# E");
        //}
        //private async void button_EMajor_Click(object sender, RoutedEventArgs e)
        //{
        //    await ChordSound.Play("E G# B");
        //}
        //private async void button_BMajor_Click(object sender, RoutedEventArgs e)
        //{
        //    await ChordSound.Play("B D# F#");
        //}
        //private async void button_Gflat_FsharpMajor_Click(object sender, RoutedEventArgs e)
        //{
        //    await ChordSound.Play("F# A# C#");
        //}
        //private async void button_DflatMajor_Click(object sender, RoutedEventArgs e)
        //{
        //    await ChordSound.Play("C# F G#");
        //}
        //private async void button_AflatMajor_Click(object sender, RoutedEventArgs e)
        //{
        //    await ChordSound.Play("G# C D#");
        //}
        //private async void button_EflatMajor_Click(object sender, RoutedEventArgs e)
        //{
        //    await ChordSound.Play("D# G A#");
        //}
        //private async void button_BflatMajor_Click(object sender, RoutedEventArgs e)
        //{
        //    await ChordSound.Play("A# D F");
        //}
        //private async void button_FMajor_Click(object sender, RoutedEventArgs e)
        //{
        //    await ChordSound.Play("F A C");
        //}

    }
}
