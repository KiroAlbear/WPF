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

namespace WPF.Windows
{
    /// <summary>
    /// Interaction logic for TablePreview.xaml
    /// </summary>
    public partial class TablePreview : Window
    {
        string path;
        public TablePreview(string path)
        {
            InitializeComponent();
            this.path = path;
            WebBrowser browser = new WebBrowser();
            PdfTableViewer.Children.Add(browser);
            browser.Navigate(path);
            browser.Opacity = 200;
        }
    }
}
