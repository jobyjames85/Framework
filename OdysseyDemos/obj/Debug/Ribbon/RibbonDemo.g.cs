﻿#pragma checksum "..\..\..\Ribbon\RibbonDemo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B08B500BBF8E4A90BEEB5D34ABFD29E2"
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


namespace Demos.Ribbon {
    
    
    /// <summary>
    /// RibbonDemo
    /// </summary>
    public partial class RibbonDemo : Odyssey.Controls.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 3 "..\..\..\Ribbon\RibbonDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Demos.Ribbon.RibbonDemo window;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\Ribbon\RibbonDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Odyssey.Controls.RibbonBar ribbonBar;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Ribbon\RibbonDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Odyssey.Controls.RibbonGallery gallery;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Ribbon\RibbonDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Odyssey.Controls.RibbonThumbnail thumb1;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\Ribbon\RibbonDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Odyssey.Controls.RibbonThumbnail thumb2;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\Ribbon\RibbonDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Odyssey.Controls.RibbonTextBox rbox;
        
        #line default
        #line hidden
        
        
        #line 296 "..\..\..\Ribbon\RibbonDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Odyssey.Controls.RibbonGallery gallery2;
        
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
            System.Uri resourceLocater = new System.Uri("/Demos;component/ribbon/ribbondemo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ribbon\RibbonDemo.xaml"
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
            this.window = ((Demos.Ribbon.RibbonDemo)(target));
            return;
            case 2:
            this.ribbonBar = ((Odyssey.Controls.RibbonBar)(target));
            return;
            case 3:
            
            #line 18 "..\..\..\Ribbon\RibbonDemo.xaml"
            ((Odyssey.Controls.RibbonMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowBelowClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 19 "..\..\..\Ribbon\RibbonDemo.xaml"
            ((Odyssey.Controls.RibbonMenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowAboveClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 66 "..\..\..\Ribbon\RibbonDemo.xaml"
            ((Odyssey.Controls.RibbonGroup)(target)).ExecuteLauncher += new System.Windows.RoutedEventHandler(this.RibbonGroup_LaunchDialog);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 75 "..\..\..\Ribbon\RibbonDemo.xaml"
            ((Odyssey.Controls.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.VistaClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 82 "..\..\..\Ribbon\RibbonDemo.xaml"
            ((Odyssey.Controls.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.Win7Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 84 "..\..\..\Ribbon\RibbonDemo.xaml"
            ((Odyssey.Controls.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.OfficeBlueClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 86 "..\..\..\Ribbon\RibbonDemo.xaml"
            ((Odyssey.Controls.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.OfficeSilverClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 88 "..\..\..\Ribbon\RibbonDemo.xaml"
            ((Odyssey.Controls.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.OfficeBlackClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 90 "..\..\..\Ribbon\RibbonDemo.xaml"
            ((Odyssey.Controls.RibbonGroup)(target)).ExecuteLauncher += new System.Windows.RoutedEventHandler(this.RibbonGroup_LaunchDialog);
            
            #line default
            #line hidden
            return;
            case 12:
            this.gallery = ((Odyssey.Controls.RibbonGallery)(target));
            return;
            case 13:
            this.thumb1 = ((Odyssey.Controls.RibbonThumbnail)(target));
            return;
            case 14:
            this.thumb2 = ((Odyssey.Controls.RibbonThumbnail)(target));
            return;
            case 15:
            this.rbox = ((Odyssey.Controls.RibbonTextBox)(target));
            return;
            case 16:
            
            #line 130 "..\..\..\Ribbon\RibbonDemo.xaml"
            ((Odyssey.Controls.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.ContextOffClick);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 211 "..\..\..\Ribbon\RibbonDemo.xaml"
            ((Odyssey.Controls.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.Context1Click);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 212 "..\..\..\Ribbon\RibbonDemo.xaml"
            ((Odyssey.Controls.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.Context2Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 213 "..\..\..\Ribbon\RibbonDemo.xaml"
            ((Odyssey.Controls.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.ContextOffClick);
            
            #line default
            #line hidden
            return;
            case 20:
            this.gallery2 = ((Odyssey.Controls.RibbonGallery)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

