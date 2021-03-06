﻿#pragma checksum "..\..\MainDemo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3EAB7783272F61DB459AE899688E8611"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Demos;
using Odyssey.Controls;
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


namespace Demos {
    
    
    /// <summary>
    /// ExplorerBar
    /// </summary>
    public partial class ExplorerBar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\MainDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Odyssey.Controls.BreadcrumbBar bar;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MainDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Odyssey.Controls.ExplorerBar explorerBar;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Odyssey.Controls.OdcExpander expander1;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text1;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MainDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text2;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MainDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock text3;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Odyssey.Controls.OdcExpander expander2;
        
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
            System.Uri resourceLocater = new System.Uri("/Demos;component/maindemo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainDemo.xaml"
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
            this.bar = ((Odyssey.Controls.BreadcrumbBar)(target));
            
            #line 28 "..\..\MainDemo.xaml"
            this.bar.PopulateItems += new Odyssey.Controls.BreadcrumbItemEventHandler(this.BreadcrumbBar_PopulateItems);
            
            #line default
            #line hidden
            
            #line 29 "..\..\MainDemo.xaml"
            this.bar.BreadcrumbItemDropDownOpened += new Odyssey.Controls.BreadcrumbItemEventHandler(this.bar_BreadcrumbItemDropDownOpened);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainDemo.xaml"
            this.bar.PathConversion += new Odyssey.Controls.PathConversionEventHandler(this.BreadcrumbBar_PathConversion);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 34 "..\..\MainDemo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RefreshClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 35 "..\..\MainDemo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowStaticBreadcrumbBar);
            
            #line default
            #line hidden
            return;
            case 4:
            this.explorerBar = ((Odyssey.Controls.ExplorerBar)(target));
            return;
            case 5:
            this.expander1 = ((Odyssey.Controls.OdcExpander)(target));
            return;
            case 6:
            this.text1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.text2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.text3 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.expander2 = ((Odyssey.Controls.OdcExpander)(target));
            return;
            case 10:
            
            #line 63 "..\..\MainDemo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 64 "..\..\MainDemo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 69 "..\..\MainDemo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Animate1Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 70 "..\..\MainDemo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Animate2Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 77 "..\..\MainDemo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 78 "..\..\MainDemo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

