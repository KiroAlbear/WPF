using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

namespace WPF.Windows
{
    /// <summary>
    /// Interaction logic for SearchWindows.xaml
    /// </summary>
    public partial class SearchWindows : MahApps.Metro.Controls.MetroWindow
    {
        Window temp;
        int count = 0;
        Flyout flyout=null;
        int Exitcounter=0;
        Style TextBoxStyleGotFocus = (Style)Application.Current.Resources["NewTextBoxStyleGotFocus"];
        Style TextBoxNormalStyle = (Style)Application.Current.Resources["NewTextBoxStyle"];
        string spaces = "                                                                                                " +
            "                                     ";
        #region TextBoxStrings
        string fathername = "اسم رب الاسرة";
        string name = "الاسم";
        string email = "Email,الايميل";
        string phonenumber = "رقم التليفون";
        string qualification = "المؤهل";
        string from = "من";
        string to = "إلى";
        string job = "الوظيفة";
        string service = "الخدمة";
        string nationalid = "ألرقم القومى";
        string livingtype = "نوع السكن";
        string pabtism = "نوع المعمودية";
        string disease = "نوع المرض";
        string housenumber = "رقم المنزل";

        string birthdatefrom = "ابتداء من";
        string birthdateto = "انتهاء الى";
        string birthdayfrom = "ابتداء من ";
        string birthdayto = "أنتهاء الى ";
        string birthmonthfrom = "ابتداء من  ";
        string birthmonthto = "انتهاء الى  ";
        string birthyearfrom = "ابتداء من   ";
        string birthyearto = "انتهاء الى   ";
        string lastvisitfrom = "ابتداء من    ";
        string lastvisitto = "انتهاء الى    ";

        #endregion
        public SearchWindows()
        {
            InitializeComponent();
            Search_Load();
            this.Closing -= new System.ComponentModel.CancelEventHandler(Window4_Closing);
            this.Closing += new System.ComponentModel.CancelEventHandler(Window4_Closing);
            this.Name = "SearchWindow";
            SearchFlyout_Load();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            //Application.Current.Shutdown();
         
        }

        void Window4_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Exitcounter++;
            // e.Cancel = true;
         //   if (Exitcounter == 1)
            {
                //MessageBoxResult result = MessageBox.Show("Do you want to close this window?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                //if (result == MessageBoxResult.Yes)
                //{
                //    Application.Current.Shutdown();
                //}
                //if (MessageBox.Show("Close Application?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                //{
                //    //do no stuff

                //}
                //else
                //{
                //    //do yes stuff
                //    Application.Current.Shutdown();
                //}
          
                if (MessageBox.Show("Do You Want To Close This Window ? ", "Close Window", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    this.Hide();
                    //Application.Current.Shutdown();

                  //  return;
                }

                else
                {

                }


            }

        }

        private void Search_Load()
        {
            //bool enablePopPage = false;
            //SearchFrame.NavigationService.Navigate(new ComponentPages.Search());


            /////////////SearchDataFrame/////////////////////////////
            //RightFrame.NavigationService.Navigate(new ComponentPages.Search(FloatingFrame));
            //RightFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;


         
            //////////////////////DataGridFrame////////////////////
            GridFrame.NavigationService.Navigate(new Search.SearchDataGrid());
            GridFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
           


            //StreetFrame.Margin = new Thickness(0, 0, 0, 1000);
        }
        private void SearchFlyout_Load()
        {
           
            ToggleFlyout(0);
        }
     
        private void SetStreetFrame()
        {
            // StreetFrame.NavigationService.Navigate(new ComponentPages.StreetPage());

        }
      

        public static void ClossThisWindow()
        {

            Application.Current.Windows[1].Close();
        }
       
        private void ToggleFlyout(int index)
        {

            if (flyout != null)

            {
                if (flyout.IsOpen == true&&count>1)
                 flyout.IsOpen = !flyout.IsOpen;

            }

            

            flyout = this.Flyouts.Items[index] as Flyout;
            flyout.Width = 500; ;
            if (flyout == null)
            {
                return;
            }

            flyout.IsOpen = !flyout.IsOpen;
            count++;
        }


        private void settingsFlyout_LostFocus(object sender, RoutedEventArgs e)
        {
          
            
            //    Flyout flyout = (Flyout)sender;
            //flyout.IsOpen = !flyout.IsOpen;
            
        }

        private void SearchFlyOutButton_Click(object sender, RoutedEventArgs e)
        {
                 count = 0;
                ToggleFlyout(0);
        }

     

        private void SearchStreetButton_Click(object sender, RoutedEventArgs e)
        {
            UnCheckAllRadioButtons();
            ToggleFlyout(1);
        }

        private void SearchPriestButton_Click(object sender, RoutedEventArgs e)
        {
            UnCheckAllRadioButtons();
            ToggleFlyout(3);
        }

        private void SearchConfisionButton_Click(object sender, RoutedEventArgs e)
        {
            UnCheckAllRadioButtons();
            ToggleFlyout(2);
        }

        private void SearchSocialButton_Click(object sender, RoutedEventArgs e)
        {
            UnCheckAllRadioButtons();
            ToggleFlyout(4);
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PriestSelectAllRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            PriestDeSelectAllRadioButton.IsChecked = false;
        }

        private void PriestDeSelectAllRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            PriestSelectAllRadioButton.IsChecked = false;
        }

        private void SocialSelectAllRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SocialDeSelectAllRadioButton.IsChecked = false;
        }

        private void SocialDeSelectAllRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SocialSelectAllRadioButton.IsChecked = false;
        }

        private void StreetSelectAllRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StreetDeSelectAllRadioButton.IsChecked = false;
        }

        private void StreetDeSelectAllRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StreetSelectAllRadioButton.IsChecked = false;
        }

        private void ConfisionSelectAllRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ConfisionDeSelectAllRadioButton.IsChecked = false;
        }

        private void ConfisionDeSelectAllRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ConfisionSelectAllRadioButton.IsChecked = false;
        }


        private void UnCheckAllRadioButtons()
        {
            if (SocialDeSelectAllRadioButton.IsChecked == true) ;
            SocialDeSelectAllRadioButton.IsChecked = false;

            if (SocialSelectAllRadioButton.IsChecked == true)
                SocialSelectAllRadioButton.IsChecked = false;

            if (ConfisionDeSelectAllRadioButton.IsChecked == true)
                ConfisionDeSelectAllRadioButton.IsChecked = false;

            if (ConfisionSelectAllRadioButton.IsChecked == true)
                ConfisionSelectAllRadioButton.IsChecked = false;

            if (PriestDeSelectAllRadioButton.IsChecked == true)
                PriestDeSelectAllRadioButton.IsChecked = false;

            if (PriestSelectAllRadioButton.IsChecked == true)
                PriestSelectAllRadioButton.IsChecked = false;

            if (StreetDeSelectAllRadioButton.IsChecked == true)
                StreetDeSelectAllRadioButton.IsChecked = false;

            if (StreetSelectAllRadioButton.IsChecked == true)
                StreetSelectAllRadioButton.IsChecked = false;


        }

        private void GlobalTextBox_GotFocus(object sender, RoutedEventArgs e)
        {


            //  ControlTemplate control =   (ControlTemplate)Application.Current.Resources["ExpanderHeaderStyle"];
            //Grid gridInTemplate = (Grid)((TextBox)sender).Template.FindName("linegrid", ((TextBox)sender));

           
         







           
            {

          

            if (((TextBox)sender).Text == fathername)
            {
              ;
                ((TextBox)sender).Text = string.Empty;
                   
                }

            else if (((TextBox)sender).Text == name)
            { 
              
                ((TextBox)sender).Text = string.Empty;
                  
                }
            else if (((TextBox)sender).Text == email)
            {
               
                ((TextBox)sender).Text = string.Empty;
                  
                }
            else if (((TextBox)sender).Text == phonenumber)
            {
                
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == qualification)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == from)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == to)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == job)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == service)
            {
                
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == nationalid)
            {
              
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == livingtype)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == pabtism)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == disease)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == housenumber)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == birthdayto)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == birthdayfrom)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == birthdatefrom)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == birthdateto)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == birthmonthfrom)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == birthmonthto)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == birthyearfrom)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == birthyearto)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == lastvisitfrom)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
            else if (((TextBox)sender).Text == lastvisitto)
            {
               
                ((TextBox)sender).Text = string.Empty;
            }
              ((TextBox)sender).ApplyTemplate();
            }
        }

        private void GlobalTextBox_Loaded(object sender, RoutedEventArgs e)
        {

            //DoubleAnimation story1 = new DoubleAnimation();

            //story1 = (DoubleAnimation)((TextBox)sender).Template.FindName("DoubleAnimation", ((TextBox)sender));
            //story1.RepeatBehavior = new RepeatBehavior(1.0);
           

            // ((TextBox)sender).Style = null;
            try
            {
              
                   
                if (((TextBox)sender).Text == string.Empty)
            {
              
                if (((TextBox)sender).Name == "FatherTextBox")
                {
                     
                       


                        ((TextBox)sender).Text = fathername;

                }
                else if (((TextBox)sender).Name == "NameTextBox")
                {
                     
                      
                        ((TextBox)sender).Text = name;
                }
                else if (((TextBox)sender).Name == "EmailTextBox")
                {
                       
                      
                        ((TextBox)sender).Text = email;
                }
                else if (((TextBox)sender).Name == "PhoneNumberTextBox")
                {   
                    ((TextBox)sender).Text = phonenumber;

                }
                else if (((TextBox)sender).Name == "QualificationTextBox")
                {
                    
                    ((TextBox)sender).Text = qualification;
                }
                else if (((TextBox)sender).Name == "PersonFromTextBox")
                {
                    
                    ((TextBox)sender).Text = from;
                }
                else if (((TextBox)sender).Name == "PersonToTextBox")
                {
                   
                    ((TextBox)sender).Text = to;
                }
                else if (((TextBox)sender).Name == "JobTextBox")
                {
                   
                    ((TextBox)sender).Text = job;
                }
                else if (((TextBox)sender).Name == "ServiceTextBox")
                {
                   
                    ((TextBox)sender).Text = service;
                }
                else if (((TextBox)sender).Name == "NationalIDTextBox")
                {
                 
                    ((TextBox)sender).Text = nationalid;
                }
                else if (((TextBox)sender).Name == "LivingTypeTextBox")
                {
                   
                    ((TextBox)sender).Text = livingtype;
                }
                else if (((TextBox)sender).Name == "PabtismTextBox")
                {
                   
                    ((TextBox)sender).Text = pabtism;
                }
                else if (((TextBox)sender).Name == "DiseaseTextBox")
                {
                    
                    ((TextBox)sender).Text = disease;
                }
                else if (((TextBox)sender).Name == "HouseNumberTextBox")
                {
                   
                    ((TextBox)sender).Text = housenumber;
                }
                else if (((TextBox)sender).Name == "BirhtDateFromTextBox")
                {
                 
                    ((TextBox)sender).Text = birthdatefrom;
                }
                else if (((TextBox)sender).Name == "BirhtDateToTextBox")
                {
                    
                    ((TextBox)sender).Text = birthdateto;
                }
                else if (((TextBox)sender).Name == "BirhtDayFromTextBox")
                {
                    
                    ((TextBox)sender).Text = birthdayfrom;
                }
                else if (((TextBox)sender).Name == "BirhtDayToTextBox")
                {
                  
                    ((TextBox)sender).Text = birthdayto;
                }
                else if (((TextBox)sender).Name == "BirhtMonthFromTextBox")
                {
                    
                    ((TextBox)sender).Text = birthmonthfrom;
                }
                else if (((TextBox)sender).Name == "BirhtMontToTextBox")
                {
                  
                    ((TextBox)sender).Text = birthmonthto;
                }
                else if (((TextBox)sender).Name == "BirhtYearFromTextBox")
                {
                   
                    ((TextBox)sender).Text = birthyearfrom;
                }
                else if (((TextBox)sender).Name == "BirhtYearToTextBox")
                {
                   
                    ((TextBox)sender).Text = birthyearto;
                }
                else if (((TextBox)sender).Name == "LastVisitFromTextBox")
                {
                    
                    ((TextBox)sender).Text = lastvisitfrom;
                }
                else if (((TextBox)sender).Name == "LastVisitToTextBox")
                {
                   
                    ((TextBox)sender).Text = lastvisitto;
                }
                    ((TextBox)sender).ApplyTemplate();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void GlobalTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
         
            // ((TextBox)sender).Text += spaces;
        }
    }
}
