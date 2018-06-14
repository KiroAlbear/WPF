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

namespace WPF.ComponentPages.MessageBoxes
{
    /// <summary>
    /// Interaction logic for YesNoMessageBox.xaml
    /// </summary>
    public partial class YesNoMessageBox : MahApps.Metro.Controls.MetroWindow
    {
        bool NoClicke = false;
        bool YesClicke = false;
        string Header = "", Message = "";
        public YesNoMessageBox(string Header, string Message)
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
         
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            YesClicke = true;
        }
     

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            NoClicke = true;
        }
        public bool YesClicked()
        {
            return YesClicke;
        }
        public bool NoClicked()
        {
            return NoClicke;
        }

    }
}
