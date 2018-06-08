using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using WPF.ComponentPages;
using WPF.Windows;

namespace WPF.Search
{
    /// <summary>
    /// Interaction logic for SearchDataGrid.xaml
    /// </summary>
    public partial class SearchDataGrid : Page
    {
        public SearchDataGrid()
        {
            InitializeComponent();
            this.Loaded += Page_loaded;
        }
        private async void Page_loaded(object sender, RoutedEventArgs e)
        {
            await Animation();

        }
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



        public void MydataGride_Loaded(object sender, RoutedEventArgs e)
        {
            Functions.ExpanderFunctions myfunctions = new Functions.ExpanderFunctions(MainStackPanel);
            //List<string> names = new List<string>();
            //names.Add("hai");
            //names.Add("SoWhat");
            // MydataGride.ItemsSource = kero.DefaultView;

            //DataTable kero = new DataTable();

            //    kero.Columns.Add("ان مكنتش تدلعنى مين هيدلعنى");

            //List<Person> t = new List<Person>();
            //t.Add(new Person() { Name = "asd", Age = "19" });
            //DataTable dt = new DataTable();
            //for (int i = 0; i < names.Count; i++)
            //{
            //    dt.Columns.Add(names[i]);
            //}
            //for (int i = 0; i < 5; i++)
            //{

            //}
            //dt.Columns.Add("Name");

            ////dt.Rows.Add("ayValue");
            string expandername = "ExpanderNumber ";
            string datagridname = "DataGridNumber ";

            DataTable table = myfunctions.Table();
            //  for (int i = 0; i < 9; i++)


            Expander expander = myfunctions.AddExpanderToStackPanel(expandername);

            DataGrid datagrid = myfunctions.NewDataGridToExpander(datagridname, expander);

            myfunctions.AddTableToDataGrid(table, datagrid);
            //try
            //{
            //MessageBox.Show((myfunctions.ColumnWidth(datagrid)).ToString());

            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

            //myfunctions.AddTableToDataGrid(table, datagrid);
            //Style ColumnHeaderSyle = (Style)Application.Current.Resources["ColumnHeaderStyle"];

            // temp.ColumnHeaderStyle = ColumnHeaderSyle;
            
            //AddExpanderToStackPanel("FirstExpander");


            //Expander Search = GetExpander("FirstExpander");


            //if (Search != null)
            //{
            //    AddExpanderToExpander(Search, "SecondExpander");
            //}

            //AddExpanderToStackPanel("third");
            //// MessageBox.Show(t[0].Name);




        }


        private void pdf(DataTable datatable)
        {
            string path = @"E:\Projects\OfflineWpf\PDF\test.pdf";


            PdfPTable table = new PdfPTable(datatable.Columns.Count);
            Font font = new Font(Font.FontFamily.TIMES_ROMAN, 7, Font.NORMAL);
            Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
            PdfWriter writ = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open(); 

            PdfPCell cell = new PdfPCell(new Phrase("Header spanning 3 columns"));
            cell.Colspan = datatable.Rows.Count;
            
            Color color = Color.FromRgb(21, 193, 29);

            cell.BackgroundColor = iTextSharp.text.BaseColor.BLUE;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            table.AddCell(cell);

            for (int row = 0; row < datatable.Rows.Count; row++)
            {
                for (int column = 0; column < datatable.Columns.Count; column++)
                {
                    table.AddCell(new Phrase("Row " + row.ToString() + " Col " + column.ToString(), font));
                }
            }

           
            //table.AddCell("1Col 1 Row 1"); 
            //table.AddCell("2Col 2 Row 1");
            //table.AddCell("3Col 3 Row 1");
            //table.AddCell("4Col 1 Row 2");
            //table.AddCell("5Col 2 Row 2");
            //table.AddCell("6Col 3 Row 2");
            doc.Add(table);
            doc.Close();
            //TablePreview preview = new TablePreview(@"P:\Projects\OfflineWpf\PDF\test.pdf");
            //preview.Width = 1000;
            //preview.Show();
            // MessageBox.Show("done");

        }


        private void PopUpFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }


    }
}
