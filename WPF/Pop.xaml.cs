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
using WPF.Functions;

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
        private ListView ComfessionListView;
        private ListView SocialCaseListView;
        private ListView RelativeListView;
        private ListView ShamosiaListView;
        /// <summary>
        /// /////////////////////////////////
        /// </summary>
        private bool ComfessionFirstTime=false;
        private bool SocialCaseFirstTime = false;
        private bool RelativeFirstTime = false;
        private bool ShamosiaFirstTime = false;
        /// <summary>
        /// ///////////////////////////
        /// </summary>
        private bool ComfessionVisible = false;
        private bool SocialCaseVisible = false;
        private bool RelativeVisible = false;
        private bool ShamosiaVisible = false;
        private ListViewPrepare comfessionl;
        private ListViewPrepare SocialCasl;
        private ListViewPrepare relativel;
        private ListViewPrepare shamosial;
        /// <summary>
        /// //////////////////////////////
        /// </summary>
        /// 
        private string ComfessionListName= "ComfessionList";
        private string SocialCaseListName= "SocialCaseLis";
        private string RelativeListName= "RelativeList";
        private string ShamosiaListName= "ShamosiaList";

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
       
        private void PopComfessionBox_Loaded(object sender, RoutedEventArgs e)
        {
           Style style= (Style)FindResource("StylishList");
            ComfessionListView = new ListView();

            DatabaseFamilyDataContext dd = new DatabaseFamilyDataContext();
            var a = (from aa in new DatabaseFamilyDataContext().responsiblepriests
                     where aa.responsiblepriestcode > 0
                     select new responsiblepriests
                     {
                         responsiblepriestname = aa.responsiblepriestname
                     }).ToList();
            comfessionl = new ListViewPrepare(ComfessionListView,PopUpGrid,2,2,ComfessionListName,style);
            ComfessionListView.ItemsSource = dd.responsiblepriests.Select(o => o.responsiblepriestname).ToList();

            ComfessionListView.PreviewMouseLeftButtonUp += new MouseButtonEventHandler(Listview_PreviewMouseLeftButtonUp);
            ComfessionListView.KeyDown += new KeyEventHandler(Listview_PreviewKeyDown);
 

        }

        private void PopComfessionBox_GotFocus(object sender, RoutedEventArgs e)
        {
           


        }

        private void PopComfessionBox_LostFocus(object sender, RoutedEventArgs e)
        {
           // comfessionl.TextBoxMouseDownFunction();
        }
        private void PopComfessionBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        { 
           
            comfessionl.TextBoxMouseDownFunction();
          //  Keyboard.Focus(ComfessionListView);
        }

        private void PopSocialCaseBox_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void PopSocialCaseBox_Loaded(object sender, RoutedEventArgs e)
        {
            SocialCaseListView = new ListView();
            Style style = (Style)FindResource("StylishList");
          

            DatabaseFamilyDataContext dd = new DatabaseFamilyDataContext();
            var a = (from aa in new DatabaseFamilyDataContext().responsiblepriests
                     where aa.responsiblepriestcode > 0
                     select new responsiblepriests
                     {
                         responsiblepriestname = aa.responsiblepriestname
                     }).ToList();
            SocialCasl = new ListViewPrepare(SocialCaseListView, PopUpGrid, 2, 0, SocialCaseListName, style);
            SocialCaseListView.ItemsSource = dd.responsiblepriests.Select(o => o.responsiblepriestname).ToList();

            SocialCaseListView.PreviewMouseLeftButtonUp += new MouseButtonEventHandler(Listview_PreviewMouseLeftButtonUp);
            SocialCaseListView.PreviewKeyDown += new KeyEventHandler(Listview_PreviewKeyDown);
        }

        private void PopSocialCaseBox_LostFocus(object sender, RoutedEventArgs e)
        {
          //  SocialCasl.TextBoxMouseDownFunction();
        }

        private void PopSocialCaseBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            SocialCasl.TextBoxMouseDownFunction();
        }


        private void PopRelativeBox_Loaded(object sender, RoutedEventArgs e)
        {
            Style style = (Style)FindResource("StylishList");
            RelativeListView = new ListView();

        


            DatabaseFamilyDataContext dd = new DatabaseFamilyDataContext();
            var a = (from aa in new DatabaseFamilyDataContext().responsiblepriests
                     where aa.responsiblepriestcode > 0
                     select new responsiblepriests
                     {
                         responsiblepriestname = aa.responsiblepriestname
                     }).ToList();
            
            relativel = new ListViewPrepare(RelativeListView, PopUpGrid, 3, 0, RelativeListName, style);
            RelativeListView.ItemsSource = dd.responsiblepriests.Select(o => o.responsiblepriestname).ToList();

            RelativeListView.PreviewMouseLeftButtonUp += new MouseButtonEventHandler(Listview_PreviewMouseLeftButtonUp);
            RelativeListView.KeyDown += new KeyEventHandler(Listview_PreviewKeyDown);
        }

        private void PopRelativeBox_LostFocus(object sender, RoutedEventArgs e)
        {
            //relativel.TextBoxMouseDownFunction();
        }

        private void PopRelativeBox_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void PopRelativeBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            relativel.TextBoxMouseDownFunction();
        }

        private void PopShamosiaBox_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void PopShamosiaBox_Loaded(object sender, RoutedEventArgs e)
        {
            Style style = (Style)FindResource("StylishList");
            ShamosiaListView = new ListView();
            shamosial = new ListViewPrepare(ShamosiaListView, PopUpGrid, 4, 0, ShamosiaListName, style);

            DatabaseFamilyDataContext dd = new DatabaseFamilyDataContext();
            var a = (from aa in new DatabaseFamilyDataContext().responsiblepriests
                     where aa.responsiblepriestcode > 0
                     select new responsiblepriests
                     {
                         responsiblepriestname = aa.responsiblepriestname
                     }).ToList();

            ShamosiaListView.ItemsSource = dd.responsiblepriests.Select(o => o.responsiblepriestname).ToList();

            ShamosiaListView.PreviewMouseLeftButtonUp += new MouseButtonEventHandler(Listview_PreviewMouseLeftButtonUp);
            ShamosiaListView.KeyDown += new KeyEventHandler(Listview_PreviewKeyDown);

        }

        private void PopShamosiaBox_LostFocus(object sender, RoutedEventArgs e)
        {
          //  relativel.TextBoxMouseDownFunction();
        }

        private void PopShamosiaBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            shamosial.TextBoxMouseDownFunction();
        }

        private void Listview_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Call");
           
            // if (((ListView)sender).Name == ComfessionListName)
            comfessionl.ListViewKeyDownFunction(PopComfessionBox,e);

            // if (((ListView)sender).Name == RelativeListName)
            //    relativel.ListViewKeyDownFunction(PopRelativeBox, e);

            //else if (((ListView)sender).Name == SocialCaseListName)
            //    SocialCasl.ListViewKeyDownFunction(PopSocialCaseBox, e);

            //else if (((ListView)sender).Name == ShamosiaListName)
            //    shamosial.ListViewKeyDownFunction(PopShamosiaBox, e);
            //shamosial.ListViewKeyDownFunction(((TextBox)sender),e);


        }

        private void Listview_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (((ListView)sender).Name == ComfessionListName)
                comfessionl.ListViewMouseDown(PopComfessionBox);

            else if(((ListView)sender).Name == RelativeListName)
                relativel.ListViewMouseDown(PopRelativeBox);

            else if(((ListView)sender).Name == SocialCaseListName)
                SocialCasl.ListViewMouseDown(PopSocialCaseBox);

            else if(((ListView)sender).Name == ShamosiaListName)
                shamosial.ListViewMouseDown(PopShamosiaBox);
            
        }

   
    }
}
