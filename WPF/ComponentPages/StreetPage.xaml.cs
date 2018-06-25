using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.ComponentPages
{
    /// <summary>
    /// Interaction logic for StreetPage.xaml
    /// </summary>
    public partial class StreetPage : Page
    {
        public StreetPage()
        {
            InitializeComponent();
          
        }

        private void BlankSpaceButtonClick(object sender, RoutedEventArgs e)
        {
            this.Margin = new Thickness(0, this.WindowHeight+100, 0, 0);
        }

        List<string> firstlist = new List<string>();
        List<string> secondtlist = new List<string>();
        private void StreetFirstList_Loaded(object sender, RoutedEventArgs e)
        {
            
            for (int i = 0; i < 5; i++)
            {
                firstlist.Add("item " + i.ToString());
            }

            StreetFirstList.ItemsSource = firstlist;
        }

        private void StreetFirstList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            int s = StreetFirstList.SelectedIndex;
            Functions.ListViewTransportation transport =
                new Functions.ListViewTransportation(firstlist, secondtlist, s);

            transport.Transport();

            //secondtlist.Add(firstlist[s]);

            //firstlist.RemoveAt(s);

            //ICollectionView view = CollectionViewSource.GetDefaultView(firstlist);
            //view.Refresh();

            //view = CollectionViewSource.GetDefaultView(secondtlist);
            //view.Refresh();

           
        }

        private void StreetSecondtList_Loaded(object sender, RoutedEventArgs e)
        {
            StreetSecondtList.ItemsSource = secondtlist;     
        }

        private void StreetSecondtList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int s = StreetSecondtList.SelectedIndex;
            Functions.ListViewTransportation transport =
                new Functions.ListViewTransportation(secondtlist, firstlist, s);
            transport.Transport();
        }

        /// <summary>
        /// Test Class///
        /// 
        /// </summary>


    }
}
