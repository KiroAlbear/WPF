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

namespace WPF.ComponentPages
{
    /// <summary>
    /// Interaction logic for ResponsiblePriest.xaml
    /// </summary>
    public partial class ResponsiblePriest : Page
    {
        public ResponsiblePriest()
        {
            InitializeComponent();
        }

        private void BlankSpaceButtonClick(object sender, RoutedEventArgs e)
        {
            this.Margin = new Thickness(0, this.WindowHeight + 100, 0, 0);
        }

    }
}
