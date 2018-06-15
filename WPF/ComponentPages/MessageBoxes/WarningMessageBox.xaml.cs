using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF.ComponentPages.MessageBoxes
{
    /// <summary>
    /// Interaction logic for WarningMessageBox.xaml
    /// </summary>
    public partial class WarningMessageBox : MahApps.Metro.Controls.MetroWindow
    {
     
        string Header="", Message="";
        public WarningMessageBox(string Header,string Message)
        {
            InitializeComponent();
            this.Header = Header;
            this.Message = Message;
            SetText();
           
        }
        private void SetText()
        {
            if (Header != null)
            Title = Header;
            

            if (Message != null)
                MessageTextBlock.Text = Message;


            // AddText("askljfhagksjfhasfdas");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
      

      

       
       
    }
}
