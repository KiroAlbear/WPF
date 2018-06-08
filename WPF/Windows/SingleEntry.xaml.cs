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
using System.Windows.Shapes;
using WPF.ComponentPages.TabPages;

namespace WPF.Windows
{
    /// <summary>
    /// Interaction logic for SingleEntry.xaml
    /// </summary>
    public partial class SingleEntry : MahApps.Metro.Controls.MetroWindow
    {
        int ResponsiblePriestCount = 0;
        int ChurchCount = 0;
        int RegionCount = 0;
        int SocialConditionCount =0 ;
        int StreetsCount = 0;
        int ConfessionPriestCount = 0;
        int LivingTypeCount = 0;
        int PabtismCount = 0;
        int ServersCount = 0;
        int ServiceCount = 0;


        public SingleEntry()
        {
            InitializeComponent();
        }

        private void ResponsiblePriestTab_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
          


                

            if (ResponsiblePriestCount == 0)
                 ResponsiblePriestFrame.NavigationService.Navigate(new ComponentPages.TabPages.ResPonsible_Priest_Tab());
                  ResponsiblePriestCount++;
        }

        private void ChurchesTab_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ChurchCount == 0)
                ChurchFrame.NavigationService.Navigate(new ComponentPages.TabPages.ChurchesTab());
                 ChurchCount++;
        }

        private void RegionTab_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (RegionCount == 0)
                RegionFrame.NavigationService.Navigate(new ComponentPages.TabPages.RegionsTab());
                 RegionCount++; 
        }

        private void SocialConditionTabTab_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
                if (SocialConditionCount == 0)
                  SocialConditionFrame.NavigationService.Navigate(new ComponentPages.TabPages.SocialConditionTab());
                     SocialConditionCount++;
        }

        private void StreetTab_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (StreetsCount == 0)
                StreetsFrame.NavigationService.Navigate(new ComponentPages.TabPages.StreetsTab());
                   StreetsCount++;
        }

        private void ConfessionTab_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ConfessionPriestCount == 0)
                ConfessionPriestFrame.NavigationService.Navigate(new ComponentPages.TabPages.ConfessionTab());
                   ConfessionPriestCount++;
        }

        private void LivingTypeTab_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (LivingTypeCount == 0)
                LivingTypeFrame.NavigationService.Navigate(new ComponentPages.TabPages.LivingTypeTab());
                 LivingTypeCount++;
        }

        private void baptismTab_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (PabtismCount == 0)
                PabtismFrame.NavigationService.Navigate(new ComponentPages.TabPages.PabtismTab());
                  PabtismCount++;
        }

        private void ServersTab_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ServersCount == 0)
                ServersFrame.NavigationService.Navigate(new ComponentPages.TabPages.ServerPersonType());
                  ServersCount++;
        }

        private void ServiceTab_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ServiceCount == 0)
                ServiceFrame.NavigationService.Navigate(new ComponentPages.TabPages.ServiceTypeTab());
                  ServiceCount++;
        }

        

   
    
    }
}
