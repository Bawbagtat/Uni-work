﻿#pragma checksum "..\..\..\ReadFilter.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B472F43D6C7DFA87D80ADC66377F22D9"
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


namespace NapierBanking {
    
    
    /// <summary>
    /// ReadFilter
    /// </summary>
    public partial class ReadFilter : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\ReadFilter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox messageListBox;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\ReadFilter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton sms_FilterBtn;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\ReadFilter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton email_FilterBtn;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\ReadFilter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton tweet_FilterBtn;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\ReadFilter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton sir_FilterBtn;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\ReadFilter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton all_FilterBtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\ReadFilter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button viewBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/NapierBanking;component/readfilter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ReadFilter.xaml"
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
            this.messageListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 6 "..\..\..\ReadFilter.xaml"
            this.messageListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.messageListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 8 "..\..\..\ReadFilter.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.sms_FilterBtn = ((System.Windows.Controls.RadioButton)(target));
            
            #line 9 "..\..\..\ReadFilter.xaml"
            this.sms_FilterBtn.Checked += new System.Windows.RoutedEventHandler(this.sms_FilterBtn_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.email_FilterBtn = ((System.Windows.Controls.RadioButton)(target));
            
            #line 10 "..\..\..\ReadFilter.xaml"
            this.email_FilterBtn.Checked += new System.Windows.RoutedEventHandler(this.email_FilterBtn_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tweet_FilterBtn = ((System.Windows.Controls.RadioButton)(target));
            
            #line 11 "..\..\..\ReadFilter.xaml"
            this.tweet_FilterBtn.Checked += new System.Windows.RoutedEventHandler(this.tweet_FilterBtn_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.sir_FilterBtn = ((System.Windows.Controls.RadioButton)(target));
            
            #line 12 "..\..\..\ReadFilter.xaml"
            this.sir_FilterBtn.Checked += new System.Windows.RoutedEventHandler(this.sir_FilterBtn_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.all_FilterBtn = ((System.Windows.Controls.RadioButton)(target));
            
            #line 13 "..\..\..\ReadFilter.xaml"
            this.all_FilterBtn.Checked += new System.Windows.RoutedEventHandler(this.all_FilterBtn_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.viewBtn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\ReadFilter.xaml"
            this.viewBtn.Click += new System.Windows.RoutedEventHandler(this.viewBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

