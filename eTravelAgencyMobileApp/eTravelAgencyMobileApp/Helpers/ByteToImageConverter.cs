using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using System.Drawing;
using System.IO;

namespace eTravelAgencyMobileApp.Helpers
{
    public class ByteToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ImageSource image = null;
            if (value != null)
            {
                byte[] imageBytes = value as byte[];
                image = ImageSource.FromStream(()=>new MemoryStream(imageBytes));
            }
            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
