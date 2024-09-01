using MusicCircle.Settings.CircleSettingsWindow.Pages.PageViewModel.UserControls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace MusicCircle.QuartoQuintoCircleWindow.UserControls
{
    internal class RotateConverter : IValueConverter
    {
        //static int indexer = 0;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (parameter is RotateTransform[] transforms)
            {
                int index = /*++indexer;*/(value as TonalitySettingsVM).Angle % transforms.Length;
                return transforms[index/*++indexer*/];
            }
            return null;

            //if (value is int)
            //{
            //    // Здесь вы можете реализовать свою логику для расчета угла поворота
            //    // Например, поворот на 30 градусов для каждого следующего элемента
            //    indexer += 30;
            //    double angle = indexer;
            //    return new RotateTransform(angle);
            //}
            //return new RotateTransform(0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
