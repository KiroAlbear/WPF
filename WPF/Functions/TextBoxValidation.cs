using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF.Functions
{
   static class TextBoxValidation
    {
      
     
        static public void Exception(TextBox Box)
        {
            Grid gridInTemplate = (Grid)Box.Template.FindName("linegrid", Box);
            gridInTemplate.Background = Brushes.Red;
        }
        static public void ReturnNormal(TextBox Box)
        {
            Grid gridInTemplate = (Grid)Box.Template.FindName("linegrid", Box);

           Color BlueColor = Color.FromRgb(17, 132, 178);

            gridInTemplate.Background = new SolidColorBrush(BlueColor);
        }


    }
}
