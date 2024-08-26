using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace MusicCircle.Interface.QuartoQuintoCircleInterface
{
    /*internal*/public class CustomButtonProperty 
    {
        // TextProperty является свойство которое будет контейнером объекта которое
        //  мы передаем. Set и Get соответственно устанавливают и выдают значенияфф
        public static DependencyProperty TextProperty =
            DependencyProperty.RegisterAttached("Text", typeof(string),
                typeof(CustomButtonProperty), new PropertyMetadata(""));
        public static string GetText(DependencyObject obj)
        => (string)obj.GetValue(TextProperty);

        public static void SetText(DependencyObject obj, string value)
            => obj.SetValue(TextProperty, value);

        /*public static readonly DependencyProperty TextProperty =
            DependencyProperty.RegisterAttached("Text", typeof(string),
                typeof(CustomButtonProperty), new PropertyMetadata(""));*/
    }
}
