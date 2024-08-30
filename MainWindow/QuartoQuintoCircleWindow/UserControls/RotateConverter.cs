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
        static int indexer = 0;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is RotateTransform[] transforms)
            {
                int index = /*++indexer;*/(value as TonalitySettingsVM).IndexProperty % transforms.Length;
                return transforms[index/*++indexer*/];
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
