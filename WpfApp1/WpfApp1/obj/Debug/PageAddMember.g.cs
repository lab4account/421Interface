﻿#pragma checksum "..\..\PageAddMember.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BBB78F64457BC48D49EDE6ACFF7520A3AF8A1960"
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// PageAddMember
    /// </summary>
    public partial class PageAddMember : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\PageAddMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneInput;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\PageAddMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddressInput;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\PageAddMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FNameInput;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\PageAddMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MinitInput;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\PageAddMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LNameInput;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\PageAddMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OKbtn;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\PageAddMember.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/pageaddmember.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PageAddMember.xaml"
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
            this.PhoneInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.AddressInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.FNameInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\PageAddMember.xaml"
            this.FNameInput.GotFocus += new System.Windows.RoutedEventHandler(this.FNameInput_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MinitInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\PageAddMember.xaml"
            this.MinitInput.GotFocus += new System.Windows.RoutedEventHandler(this.MinitInput_GotFocus);
            
            #line default
            #line hidden
            
            #line 66 "..\..\PageAddMember.xaml"
            this.MinitInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.MinitInput_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LNameInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\PageAddMember.xaml"
            this.LNameInput.GotFocus += new System.Windows.RoutedEventHandler(this.LNameInput_GotFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.OKbtn = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\PageAddMember.xaml"
            this.OKbtn.Click += new System.Windows.RoutedEventHandler(this.OKbtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CancelBtn = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\PageAddMember.xaml"
            this.CancelBtn.Click += new System.Windows.RoutedEventHandler(this.CancelBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

