﻿#pragma checksum "..\..\..\ComponentPages\BottomPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DFB40EAAB31E6017B1928F23C801875F17E175F4"
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
using WPF.ComponentPages;


namespace WPF.ComponentPages {
    
    
    /// <summary>
    /// BottomPage
    /// </summary>
    public partial class BottomPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\ComponentPages\BottomPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid VisitGrid;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\ComponentPages\BottomPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PopSaVeButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\ComponentPages\BottomPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PopEditButton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\ComponentPages\BottomPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PopCancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF;component/componentpages/bottompage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ComponentPages\BottomPage.xaml"
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
            this.VisitGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.PopSaVeButton = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\ComponentPages\BottomPage.xaml"
            this.PopSaVeButton.Click += new System.Windows.RoutedEventHandler(this.PopSaVeButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.PopEditButton = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\ComponentPages\BottomPage.xaml"
            this.PopEditButton.Click += new System.Windows.RoutedEventHandler(this.PopEditButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PopCancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\ComponentPages\BottomPage.xaml"
            this.PopCancelButton.Click += new System.Windows.RoutedEventHandler(this.PopCancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

