using System;
using System.Collections.Generic;
using System.Data;
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
using WPF.ComponentPages.MessageBoxes;
using WPF.classes;
using System.Reflection;

namespace WPF
{
    /// <summary>
    /// Interaction logic for Pop.xaml
    /// </summary>
    public partial class Pop : Page
    {
        public DataGridRow new_row;
        string rr;
        string spaces = "                                                                                                      ";
        public Pop()
        {
            InitializeComponent();
            this.Loaded += Page_loaded;
        }
        public Pop(DataGridRow row)
        {
            
            InitializeComponent();
            
            this.Loaded += Page_loaded;
          
            try
            {
                new_row = row;
               // DataRowView dr = (DataRowView)row.Item;
             //   PopNameBox.Text = dr.Row[0].ToString();
             //   PopJobBox.Text = dr.Row[1].ToString();
               
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        private async void Page_loaded(object sender, RoutedEventArgs e)
        {
            await Animation();
        }

        private void PopCancelButton_Click(object sender, RoutedEventArgs e)
        {
           
            this.Visibility = Visibility.Collapsed;
        }

        public async Task Animation()
        {
            var sb = new Storyboard();

            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(.5f)),
                From = new Thickness(300, 300, 300, 300),
                To = new Thickness(0),
                DecelerationRatio = 1
            };

            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            sb.Children.Add(slideAnimation);
            sb.Begin(this);
            //   this.Visibility = Visibility.Visible;
            //await Task.Delay((int)(0.2f * 1000));

        }
        private void GLOBALTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == spaces)
                ((TextBox)sender).Text = string.Empty;
            //if (((TextBox)sender).Name == PriestTextBox.Name)
            //    PositioningGlobalList(1, 0);
            //if (((TextBox)sender).Name == ChurchBox.Name)
            //    PositioningGlobalList(2, 0);
            //if (((TextBox)sender).Name == PersonBox.Name)
            //    PositioningGlobalList(3, 0);
            //if (((TextBox)sender).Name == StreetTextBox.Name)
            //    PositioningGlobalList(4, 0);
            //if (((TextBox)sender).Name == RegionTextBox.Name)
            //    PositioningGlobalList(6, 0);

        }
        private void GlobalTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text == string.Empty)
                ((TextBox)sender).Text = spaces;
         

           



        }

        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).Focus();
        }

        private void PopSaveButtom_Click(object sender, RoutedEventArgs e)
        {
            familydetail fd = new familydetail();
            fd.paxname = PopNameBox.Text;
            fd.moahel = PopQualificationBox.Text;
            fd.job = PopJobBox.Text;
            fd.birthdate = PopAgeBox.Text;
            
            family_data_shared.new_family_member.Add(fd);
           //  MessageBox.Show(family_data_shared.new_family_member.Count.ToString());
            DataTable fdm = new DataTable();
            fdm = ToDataTable<familydetail>(family_data_shared.new_family_member);
            family_data_shared.my_datagrid.ItemsSource = fdm.DefaultView;
            this.Visibility = Visibility.Collapsed;
            
        }
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

    }
}
