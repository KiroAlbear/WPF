﻿using System;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.Animation;

namespace WPF.ComponentPages.TabPages
{
    /// <summary>
    /// Interaction logic for ResponsiblePriestTab.xaml
    /// </summary>
    public partial class RegionsTab : Page
    {
        public RegionsTab()
        {
            InitializeComponent();
            this.Loaded += Page_loaded;
        }
        private async void Page_loaded(object sender, RoutedEventArgs e)
        {
            await AnimatePage();

        }

        public async Task AnimatePage()
        {

            Storyboard storyboard = new Storyboard();
            storyboard.SlideAnimation(-this.WindowWidth / 20, 0, this.WindowWidth, 0, 0.23);
            storyboard.FadeAnimation(0.5);
            storyboard.Begin(this);
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
