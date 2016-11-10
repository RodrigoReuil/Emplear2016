using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ObjectDraw.Figuras
{
    public class FiguraConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Rectangulo rect = value as Rectangulo;

            if (rect != null)
            {
                return $"RECT: ({rect.X}, {rect.Y}): {rect.Base} x {rect.Altura}";
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
