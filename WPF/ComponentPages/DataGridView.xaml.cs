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
using System.Data;
using System.Reflection;

namespace WPF.ComponentPages
{
    /// <summary>
    /// Interaction logic for DataGridView.xaml
    /// </summary>
    public partial class DataGridView : Page
    {
        public DataGridView(bool enablePopPage)
        {
            InitializeComponent();
            this.Loaded += Page_loaded;
            if(enablePopPage)
            PopUpFrame.NavigationService.Navigate(new Pop());
        }
        private async void Page_loaded(object sender, RoutedEventArgs e)
        {
            await Animation();

        }
        /// <summary>
        /// Test Class///
        /// 
        /// </summary>

        public async Task Animation()
        {
            var sb = new Storyboard();

            var slideAnimation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                From = new Thickness(-this.WindowWidth, 0, this.WindowWidth, 0),
                To = new Thickness(0),
                DecelerationRatio = 0.5
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            sb.Children.Add(slideAnimation);
            sb.Begin(this);
            //   this.Visibility = Visibility.Visible;
            //await Task.Delay((int)(0.2f * 1000));

        }
        
       public class Person
        {
            public string Name;
            public string Age;
        };
        
        private void MydataGride_Loaded(object sender, RoutedEventArgs e)
        {
            Functions.ExpanderFunctions myfunctions = new Functions.ExpanderFunctions(MainStackPanel,PopUpFrame);
            List<string> names = new List<string>();
            names.Add("hai");
            names.Add("SoWhat");
            DatabaseFamilyDataContext dd = new DatabaseFamilyDataContext();
            DataTable table_view = new DataTable();
          
            table_view.Columns.Add("Name");
            table_view.Columns.Add("num");
            table_view.Columns.Add("4");
            table_view.Columns.Add("3");
            table_view.Columns.Add("2");
            table_view.Columns.Add("1");
            table_view.Rows.Add("tony", "123", "123", "123", "123", "123");
             // myfunctions.AddTableToDataGrid(table_view, MyDataGrid);
            DataTable dddd = new DataTable();
            dddd= ToDataTable<family>(dd.families.Where(o => o.familycode < 100).ToList());
            MyDataGrid.ItemsSource = dddd.DefaultView;

            MyDataGrid.PreviewMouseLeftButtonUp += new MouseButtonEventHandler(myfunctions.MydataGride_MouseRightClick);




        }
        public  DataTable ToDataTable<T>(List<T> items)
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



        //private DataTable Table()
        //{
        //    DataTable newdatatable = new DataTable();
        //    ////add Columns
        //    for (int i = 0; i <10; i++)
        //    {
        //        newdatatable.Columns.Add(i.ToString());
        //    }

        //    ///add Rows
        //    for (int row = 0; row < 10; row++)
        //    {

        //        newdatatable.Rows.Add(row.ToString());
        //    }

        //    for (int row = 0; row < 10; row++)
        //    {
        //        for (int column = 0; column < 10; column++)
        //        {
        //            newdatatable.Rows[row][column] = row.ToString() + " " + column.ToString();
        //        }
        //    }

        //    return newdatatable;
        //}
        //private Expander AddExpanderToStackPanel(string ExpanderName)
        //{

        //    Expander newexpander = NewExpander(ExpanderName);
        //    MainStackPanel.Children.Add(newexpander);
        //    return newexpander;
        //    ////Register the name of the element so we can search for it lately
        //   // MainStackPanel.RegisterName(name, newexpander);
        //}
        //private Expander AddExpanderToExpander(Expander ParentExpander,string NewExpanderName)
        //{

        //    Expander newexpander = NewExpander(NewExpanderName);
        //    //if (MainStackPanel.Children.Contains(ParentExpander)) ;
        //    ParentExpander.Content = newexpander;
        //    return newexpander;
        //    ////Register the name of the element so we can search for it lately
        //    //ParentExpander.RegisterName(NewExpanderName, newexpander);
        //}

        //private Expander NewExpander(string ExpanderName)
        //{
        //    string NoSpaceString = SpaceCleaningString(ExpanderName);
        //    Expander newexpander = new Expander();
        //    newexpander.Name = NoSpaceString;
        //    newexpander.Header = ExpanderName;
        //    newexpander.Foreground = Brushes.Black;

        //    newexpander.MouseEnter += new MouseEventHandler(Expander_MouseEnter);
        //    newexpander.MouseLeave += new MouseEventHandler(Expander_MouseLeave);

        //    /////////Antonious    
        //    newexpander.FlowDirection = FlowDirection.RightToLeft;

        //    ////////////////////////////

        //    ////Register the name of the element so we can search for it lately
        //    RegisterName(NoSpaceString, newexpander);
        //    return newexpander;
        //}


        //private Expander GetExpander(string ExpanderName)
        //{
        //    string NoSpaceString = SpaceCleaningString(ExpanderName);
        //    Expander existexpander = (Expander)this.FindName(NoSpaceString);

        //    return existexpander;
        //}



        //private DataGrid GetDataGrid(string DatagridName)
        //{
        //    string NoSpaceString = SpaceCleaningString(DatagridName);
        //    DataGrid existdatagrid = (DataGrid)this.FindName(NoSpaceString);
        //    return existdatagrid;
        //}

        //private void AddTableToDataGrid(DataTable datatable,DataGrid datagrid)
        //{
        //    datagrid.ItemsSource = datatable.DefaultView;
        //}

        //private void InsetIntoDataGrid(DataTable table,DataGrid datagrid)
        //{
        //    datagrid.ItemsSource = table.DefaultView;
        //}
        //private string SpaceCleaningString(string anystring)
        //{
        //    return anystring = anystring.Replace(" ", string.Empty);
        //}

        //private DataGrid NewDataGridToExpander(string DataGridName,Expander expander)
        //{
        //    string NoSpaceString = SpaceCleaningString(DataGridName);
        //    DataGrid temp = new DataGrid();
        //    temp.Name = NoSpaceString;


        //    temp.MouseDoubleClick += new MouseButtonEventHandler(MydataGride_MouseDoubleClick);

        //    expander.RegisterName(NoSpaceString, temp);
        //    temp.FlowDirection = FlowDirection.RightToLeft;
        //    temp.AutoGenerateColumns = true;

        //    expander.Content = temp;
        //    return temp;

        //}

        private void rowselect(){
            
            
            }


        //private void MydataGride_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{

        //    string index = ((DataGrid)sender).SelectedIndex.ToString();
        
        //    MessageBox.Show(index);
        //    //RowDefinition Row2= MainRow2;
        //    //ColumnDefinition column1 = MainColumn1;
        //    // NewGride = new Grid();
        //    //NewGride.Background = Brushes.Red;
        //    //NewGride.Width = 870;
        //    //NewGride.Height = 550;
        //    //NewGride.Margin = new Thickness(0, 0, 25, 0);
        //    //NewGride.Opacity = 0.7;

        //    //NewGride.SetValue(Grid.RowProperty, 1);
        //    //NewGride.SetValue(Grid.ColumnProperty, 0);
        //    //NewGride.HorizontalAlignment = HorizontalAlignment.Center;
        //    //NewGride.VerticalAlignment = VerticalAlignment.Center;
        //    //MainGrid.Children.Add(NewGride);

        //    //Frame fram = new Frame();
        //    //fram.SetValue(Grid.ColumnProperty, 0);
        //    //fram.SetValue(Grid.RowProperty, 1);
        //    //fram.VerticalAlignment = VerticalAlignment.Stretch;
        //    //fram.HorizontalAlignment = HorizontalAlignment.Stretch;

        //    //fram.NavigationService.Navigate(new Pop());
        //    //MainGrid.Children.Add(fram);

        //    // MessageBox.Show(mylist[1]);


        //    //PopUpFrame.NavigationService.Navigate(new Pop());

        //}

        private void PopUpFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }


 
        //private void Expander_MouseEnter(object sender, MouseEventArgs e)
        //{
        //   ((Expander)sender).Background = Brushes.BlueViolet;
 

        //}
        //private void Expander_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    ((Expander)sender).Background = Brushes.White;
           
           

        //}

        private void DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }
    }
}






































































