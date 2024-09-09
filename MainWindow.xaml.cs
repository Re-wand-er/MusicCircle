using System.Windows;
using System.Windows.Input;
using MusicCircle.Pages;
using MusicCircle.SoundPlayAlghorithms;
using System.Windows.Controls;
using System.Configuration;
using System.ComponentModel;

namespace MusicCircle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window/*, INotifyPropertyChanged*/
    {
        Page page = new QuartoQuintoCirclePage();

        // Попробовать здесь читать и записывать настройки приложения
        // SettinsManager settings;
        
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(page);

        }

        public async void Button_KeyDown(object sender, KeyEventArgs e)
        {
            
                switch (e.Key)
                {
                    // Переделать всю эту хуйню
                    default: break;
                    // Major
                    case Key.Q: await ChordSound.Play("C E G"); break;
                    case Key.W: await ChordSound.Play("G B D"); break;
                    case Key.E: await ChordSound.Play("D F# A"); break;
                    case Key.R: await ChordSound.Play("A C# E"); break;
                    case Key.T: await ChordSound.Play("E G# B"); break;
                    case Key.Y: await ChordSound.Play("B D# F#"); break;
                    case Key.U: await ChordSound.Play("F# A# C#"); break;
                    case Key.I: await ChordSound.Play("C# F G#"); break;
                    case Key.O: await ChordSound.Play("G# C D#"); break;
                    case Key.P: await ChordSound.Play("D# G A#"); break;
                    case Key.OemOpenBrackets: await ChordSound.Play("A# D F"); break;
                    case Key.OemCloseBrackets: await ChordSound.Play("F A C"); break;

                    // Minor
                    case Key.A: await ChordSound.Play("A C E"); break;
                    case Key.S: await ChordSound.Play("E G B"); break;
                    case Key.D: await ChordSound.Play("B D F#"); break;
                    case Key.F: await ChordSound.Play("F# A C#"); break;
                    case Key.G: await ChordSound.Play("C# E G#"); break;
                    case Key.H: await ChordSound.Play("G# B D#"); break;
                    case Key.J: await ChordSound.Play("D# F# A#"); break;
                    case Key.K: await ChordSound.Play("A# C# F"); break;
                    case Key.L: await ChordSound.Play("F G# C"); break;
                    case Key.OemSemicolon: await ChordSound.Play("C D# G"); break;
                    case Key.OemQuotes: await ChordSound.Play("G A# D"); break;
                    case Key.Enter: await ChordSound.Play("D F A"); break;
                }
        }
        private void QuartoQuintoCirclePage_Click(object sender, RoutedEventArgs e)
        {
            OpenPage(new QuartoQuintoCirclePage());
        }
        private void VirtualPianoPage_Click(object sender, RoutedEventArgs e)
        {
            OpenPage(new VirtualPianoPage());
        }

        private void OpenPage(Page pageop)
        {
            if(page.GetType() != pageop.GetType()) 
            {
                page = pageop;
                this.MainFrame.Navigate(page);
            }
        }

    }
}
