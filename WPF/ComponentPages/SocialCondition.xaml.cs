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
    /// Interaction logic for SocialCondition.xaml
    /// </summary>
    public partial class SocialCondition : Page
    {
        public SocialCondition()
        {
            InitializeComponent();
        }
        List<string> firstlist = new List<string>();
        List<string> secondlist = new List<string>();
        
        private void BlankSpaceButtonClick(object sender, RoutedEventArgs e)
        {
            this.Margin = new Thickness(0, this.WindowHeight + 100, 0, 0);
        }

        private void SocialConditionFirstList_Loaded(object sender, RoutedEventArgs e)
        {
            SocialConditionFirstList.ItemsSource = firstlist;
        }

        private void SocialConditionFirstList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            Functions.ListViewTransportation transport = new Functions.ListViewTransportation(firstlist, secondlist, 2);
        }

        private void SocialConditionSecondtList_Loaded(object sender, RoutedEventArgs e)
        {
            SocialConditionSecondtList.ItemsSource = secondlist;
        }

        private void SocialConditionSecondtList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
