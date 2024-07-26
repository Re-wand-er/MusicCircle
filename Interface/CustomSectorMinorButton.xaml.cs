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

namespace MusicCircle.Interface
{
    /// <summary>
    /// Логика взаимодействия для CustomSectorMinorButton.xaml
    /// </summary>
    public partial class CustomSectorMinorButton : UserControl
    {
        public CustomSectorMinorButton()
        {
            InitializeComponent();
        }

        private async void button_AMinor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("A C E");
        }
        private async void button_EMinor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("E G B");
        }
        private async void button_BMinor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("B D F#");
        }
        private async void button_FsharpMinor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("F# A C#");
        }
        private async void button_CsharpMinor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("C# E G#");
        }
        private async void button_GsharpMinor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("G# B D#");
        }
        private async void button_Eflat_DsharpMinor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("D# F# A#");
        }
        private async void button_BflatMinor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("A# C# F");
        }
        private async void button_FMinor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("F G# C");
        }
        private async void button_CMinor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("C D# G");
        }
        private async void button_GMinor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("G A# D");
        }
        private async void button_DMinor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("D F A");
        }
    }
}
