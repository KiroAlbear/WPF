﻿#pragma checksum "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A9C383813B35EDBD133ADDD33862EC09"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPF.ComponentPages.TabPages;


namespace WPF.ComponentPages.TabPages {
    
    
    /// <summary>
    /// ChurchesTab
    /// </summary>
    public partial class ChurchesTab : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid churchGrid;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FreeSpaceButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox NameComboBox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AdressTextBox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Telephone1TextBox;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Telephone2TextBox;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ThreeButtonGrid;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveButton;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditButton;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF;component/componentpages/tabpages/churchestab.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.churchGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.FreeSpaceButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.NameComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 64 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            this.NameComboBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.NameComboBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AdressTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            this.AdressTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.GlobalTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 70 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            this.AdressTextBox.Loaded += new System.Windows.RoutedEventHandler(this.GlobalTextBox_Loaded);
            
            #line default
            #line hidden
            
            #line 71 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            this.AdressTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.GlobalTextBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 72 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            this.AdressTextBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.AdressTextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Telephone1TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 78 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            this.Telephone1TextBox.GotFocus += new System.Windows.RoutedEventHandler(this.GlobalTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 79 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            this.Telephone1TextBox.Loaded += new System.Windows.RoutedEventHandler(this.GlobalTextBox_Loaded);
            
            #line default
            #line hidden
            
            #line 80 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            this.Telephone1TextBox.LostFocus += new System.Windows.RoutedEventHandler(this.GlobalTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Telephone2TextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 86 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            this.Telephone2TextBox.GotFocus += new System.Windows.RoutedEventHandler(this.GlobalTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 87 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            this.Telephone2TextBox.Loaded += new System.Windows.RoutedEventHandler(this.GlobalTextBox_Loaded);
            
            #line default
            #line hidden
            
            #line 88 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            this.Telephone2TextBox.LostFocus += new System.Windows.RoutedEventHandler(this.GlobalTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ThreeButtonGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.RemoveButton = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            this.RemoveButton.Click += new System.Windows.RoutedEventHandler(this.RemoveButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.EditButton = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            this.EditButton.Click += new System.Windows.RoutedEventHandler(this.EditButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\..\..\ComponentPages\TabPages\ChurchesTab.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

