﻿#pragma checksum "..\..\Add_Industry_Dialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8AFBE64597C1295E1B719056AD87D2685970F60A274DCD1A1C5E66E70A82F279"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GreenHorn;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace GreenHorn {
    
    
    /// <summary>
    /// Add_Industry_Dialog
    /// </summary>
    public partial class Add_Industry_Dialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\Add_Industry_Dialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtBlck_New_Industry;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Add_Industry_Dialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtBlck_ind;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Add_Industry_Dialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txtbx_Industy_Name;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Add_Industry_Dialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_AddIndustry;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Add_Industry_Dialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_UpdateIndustry;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Add_Industry_Dialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_DeleteIndustry;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Add_Industry_Dialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Lv_Industry;
        
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
            System.Uri resourceLocater = new System.Uri("/GreenHorn;component/add_industry_dialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Add_Industry_Dialog.xaml"
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
            
            #line 18 "..\..\Add_Industry_Dialog.xaml"
            ((GreenHorn.Add_Industry_Dialog)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TxtBlck_New_Industry = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TxtBlck_ind = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Txtbx_Industy_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Btn_AddIndustry = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Add_Industry_Dialog.xaml"
            this.Btn_AddIndustry.Click += new System.Windows.RoutedEventHandler(this.Btn_AddIndustry_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Btn_UpdateIndustry = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Add_Industry_Dialog.xaml"
            this.Btn_UpdateIndustry.Click += new System.Windows.RoutedEventHandler(this.Btn_UpdateIndustry_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Btn_DeleteIndustry = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\Add_Industry_Dialog.xaml"
            this.Btn_DeleteIndustry.Click += new System.Windows.RoutedEventHandler(this.Btn_DeleteIndustry_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Lv_Industry = ((System.Windows.Controls.ListView)(target));
            
            #line 29 "..\..\Add_Industry_Dialog.xaml"
            this.Lv_Industry.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Lv_Industry_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

