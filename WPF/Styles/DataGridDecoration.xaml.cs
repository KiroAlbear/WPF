using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Imaging;

namespace WPF.Styles
{
    public partial class DataGridDecoration :ResourceDictionary
    {
        const string ArrowUpPath = "pack://application:,,,/Icons/ArrowUp.png";
        const string ArrowDownPath = "pack://application:,,,/Icons/ArrowDown.png";
        const string WhitspacePath = "pack://application:,,,/Icons/whitspace.png";
        private void DataGridColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            var columnHeader = sender as DataGridColumnHeader;
            columnHeader.OnApplyTemplate();

             Image image = (Image)columnHeader.Template.FindName("ImageArrow", columnHeader);
            
            if (image.Source.ToString() == ArrowUpPath)
                image.Source = new BitmapImage(new Uri(ArrowDownPath));

            else if (image.Source.ToString() == ArrowDownPath || image.Source.ToString()==WhitspacePath)
                image.Source = new BitmapImage(new Uri(ArrowUpPath));
          
            
          
        }

     

        private void DataGridCell_PreviewMouseRightButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

           
        }
    }
}
