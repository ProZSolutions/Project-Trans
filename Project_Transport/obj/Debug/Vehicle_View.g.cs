﻿#pragma checksum "..\..\Vehicle_View.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "781023EA9B6345232D00303181FDB05B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Reporting.WinForms;
using Microsoft.Windows.Controls;
using Project_Transport;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using WpfTools;


namespace Project_Transport {
    
    
    /// <summary>
    /// Vehicle_View
    /// </summary>
    public partial class Vehicle_View : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Vehicle_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel vechicle_view_panel;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Vehicle_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ioc;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Vehicle_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox bpc;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Vehicle_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox hpc;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Vehicle_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox trailer;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Vehicle_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox load;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Vehicle_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel sp1;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\Vehicle_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Reporting.WinForms.ReportViewer Report_Viewer;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\Vehicle_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel sp2;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\Vehicle_View.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Reporting.WinForms.ReportViewer Report_Viewer1;
        
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
            System.Uri resourceLocater = new System.Uri("/Project_Transport;component/vehicle_view.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Vehicle_View.xaml"
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
            
            #line 11 "..\..\Vehicle_View.xaml"
            ((Project_Transport.Vehicle_View)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.vechicle_view_panel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.ioc = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\Vehicle_View.xaml"
            this.ioc.KeyDown += new System.Windows.Input.KeyEventHandler(this.ioc_keydown);
            
            #line default
            #line hidden
            
            #line 26 "..\..\Vehicle_View.xaml"
            this.ioc.GotFocus += new System.Windows.RoutedEventHandler(this.ioc_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bpc = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\Vehicle_View.xaml"
            this.bpc.KeyDown += new System.Windows.Input.KeyEventHandler(this.bpc_keydown);
            
            #line default
            #line hidden
            
            #line 29 "..\..\Vehicle_View.xaml"
            this.bpc.GotFocus += new System.Windows.RoutedEventHandler(this.bpc_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.hpc = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\Vehicle_View.xaml"
            this.hpc.KeyDown += new System.Windows.Input.KeyEventHandler(this.hpc_keydown);
            
            #line default
            #line hidden
            
            #line 32 "..\..\Vehicle_View.xaml"
            this.hpc.GotFocus += new System.Windows.RoutedEventHandler(this.hpc_GotFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.trailer = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\Vehicle_View.xaml"
            this.trailer.KeyDown += new System.Windows.Input.KeyEventHandler(this.trailer_keydown);
            
            #line default
            #line hidden
            
            #line 35 "..\..\Vehicle_View.xaml"
            this.trailer.GotFocus += new System.Windows.RoutedEventHandler(this.trailer_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.load = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\Vehicle_View.xaml"
            this.load.KeyDown += new System.Windows.Input.KeyEventHandler(this.load_keydown);
            
            #line default
            #line hidden
            
            #line 38 "..\..\Vehicle_View.xaml"
            this.load.GotFocus += new System.Windows.RoutedEventHandler(this.load_GotFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.sp1 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.Report_Viewer = ((Microsoft.Reporting.WinForms.ReportViewer)(target));
            return;
            case 10:
            this.sp2 = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 11:
            this.Report_Viewer1 = ((Microsoft.Reporting.WinForms.ReportViewer)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

