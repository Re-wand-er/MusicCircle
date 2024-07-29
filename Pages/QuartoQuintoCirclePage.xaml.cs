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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MusicCircle.Settings;
using MusicCircle.SoundPlayAlghorithms;

namespace MusicCircle.Pages
{
    /// <summary>
    /// Логика взаимодействия для MusicSirclePage.xaml
    /// </summary>
    public partial class QuartoQuintoCirclePage : Page
    {
        SettingsViewModel settingsViewModel;
        public QuartoQuintoCirclePage()
        {
            InitializeComponent();
            settingsViewModel = new SettingsViewModel("Textic");
        }

        public async void button_KeyDown(object sender, KeyEventArgs e)
        {
            // Возможно проблема в рассинхроне кроется здесь
            // А может и нет 

            switch (e.Key)
            {
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
    }
}
