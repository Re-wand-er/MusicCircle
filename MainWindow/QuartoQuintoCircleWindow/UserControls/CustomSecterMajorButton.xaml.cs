using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using MusicCircle.SoundPlayAlghorithms;

namespace MusicCircle.Interface
{
    /// <summary>
    /// Логика взаимодействия для CustomSecterMajorButton.xaml
    /// </summary>
    public partial class CustomSecterMajorButton : UserControl
    {
        public CustomSecterMajorButton()
        {
            InitializeComponent();

            //CreateSymmetricSector(325,260, 193, -15, 15);
        }

        private void CreateSymmetricSector(double centerX, double centerY, double radius, double startAngle, double endAngle)
        {
            Path path = new Path
            {
                Fill = Brushes.LightGray,
                Stroke = Brushes.Black,
                StrokeThickness = 1,
                Data = CreateSectorGeometry(centerX, centerY, radius, startAngle, endAngle)
            };

            Circle.Children.Add(path);
        }

        private Geometry CreateSectorGeometry(double centerX, double centerY, double radius, double startAngle, double endAngle)
        {
            double startRadians = startAngle * Math.PI / 180;
            double endRadians = endAngle * Math.PI / 180;

            double startX = centerX + radius * Math.Cos(startRadians);
            double startY = centerY - radius * Math.Sin(startRadians);

            double endX = centerX + radius * Math.Cos(endRadians);
            double endY = centerY - radius * Math.Sin(endRadians);

            string pathData = $"M {centerX},{centerY} L {Math.Round(startX)},{Math.Round(startY)} A {radius},{radius} 0 0 0 {Math.Round(endX)},{Math.Round(endY)} Z";
            return Geometry.Parse(pathData);
        }


        private async void button_CMajor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("C E G");
        }
        private async void button_GMagor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("G B D");
        }
        private async void button_DMajor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("D F# A");
        }
        private async void button_AMajor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("A C# E");
        }
        private async void button_EMajor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("E G# B");
        }
        private async void button_BMajor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("B D# F#");
        }
        private async void button_Gflat_FsharpMajor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("F# A# C#");
        }
        private async void button_DflatMajor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("C# F G#");
        }
        private async void button_AflatMajor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("G# C D#");
        }
        private async void button_EflatMajor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("D# G A#");
        }
        private async void button_BflatMajor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("A# D F");
        }
        private async void button_FMajor_Click(object sender, RoutedEventArgs e)
        {
            await ChordSound.Play("F A C");
        }

    }
}
