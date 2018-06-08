using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WPF.Functions
{
    static class BitmapFunctions
    {
     
        public static BitmapImage FillBitMap(string ImageLocation)
        {
             BitmapImage EmptyBitmap = new BitmapImage();
            EmptyBitmap.BeginInit();
            EmptyBitmap.UriSource = new Uri(ImageLocation);
            EmptyBitmap.EndInit();
            return EmptyBitmap;
        }
    }
}
