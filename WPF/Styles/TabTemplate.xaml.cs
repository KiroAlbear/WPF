using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace WPF.Styles
{
    public partial class TabTemplate : ResourceDictionary
    {
        Grid newgrid = null;
        public TabTemplate()
        {
            newgrid = (Grid)Application.Current.Resources["TabUnderlineGrid"];
           
        }
        private void TabContentGrid_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
          
        }

        private void TabContentGrid_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            newgrid.Background = Brushes.Red;
        }
    }
}
