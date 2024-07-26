using Microsoft.Win32;
using MusicCircle.Interface;
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

namespace MusicCircle
{
    /// <summary>
    /// Логика взаимодействия для CustomUserControl.xaml
    /// </summary>
    public partial class CustomUserControl : UserControl
    {
        public CustomUserControl()
        {
            InitializeComponent();
            
            //CreateSymmetricSector(400,260, 250, -15, 15);
            
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

            string pathData = $"M {centerX},{centerY} L {Math.Round(startX)},{Math.Round(startY)} A {radius},{radius} 0 0 1 {Math.Round(endX)},{Math.Round(endY)} Z";
            return Geometry.Parse(pathData);
        }
       
    }
}
