﻿#pragma checksum "..\..\..\ProductChoosed.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99A33BFA238CD3F1E0B69FFA4DCBF806A8912067"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MilkTeaManagementUI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace MilkTeaManagementUI {
    
    
    /// <summary>
    /// ProductChoosed
    /// </summary>
    public partial class ProductChoosed : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\ProductChoosed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\ProductChoosed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\ProductChoosed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConfirmButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\ProductChoosed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ProductNameLabel;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\ProductChoosed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ProductPriceLabel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\ProductChoosed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox QuantityTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\ProductChoosed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DecresingButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\ProductChoosed.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IncresingButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MilkTeaManagementUI;component/productchoosed.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ProductChoosed.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\ProductChoosed.xaml"
            ((MilkTeaManagementUI.ProductChoosed)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\ProductChoosed.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ConfirmButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\ProductChoosed.xaml"
            this.ConfirmButton.Click += new System.Windows.RoutedEventHandler(this.ConfirmButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ProductNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.ProductPriceLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.QuantityTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.DecresingButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\ProductChoosed.xaml"
            this.DecresingButton.Click += new System.Windows.RoutedEventHandler(this.DecresingButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.IncresingButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\ProductChoosed.xaml"
            this.IncresingButton.Click += new System.Windows.RoutedEventHandler(this.IncresingButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

