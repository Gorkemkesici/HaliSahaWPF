﻿#pragma checksum "..\..\..\Pages\SahaPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BA6D5CCA573595D9D7744D9E5B722605F525251E845982EEB6E2EAE230CBE894"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HaliSahaWPF.Pages;
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


namespace HaliSahaWPF.Pages {
    
    
    /// <summary>
    /// SahaPage
    /// </summary>
    public partial class SahaPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\SahaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_add_saha;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\SahaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_sahaName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\SahaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_sahaPrice;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\SahaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_sahaLimit;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\SahaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tb1;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\SahaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_saha_sil;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\SahaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_saha_pasif;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\SahaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbox_saha_data;
        
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
            System.Uri resourceLocater = new System.Uri("/HaliSahaWPF;component/pages/sahapage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\SahaPage.xaml"
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
            
            #line 11 "..\..\..\Pages\SahaPage.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_add_saha = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Pages\SahaPage.xaml"
            this.btn_add_saha.Click += new System.Windows.RoutedEventHandler(this.btn_add_saha_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txt_sahaName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_sahaPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_sahaLimit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tb1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.btn_saha_sil = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Pages\SahaPage.xaml"
            this.btn_saha_sil.Click += new System.Windows.RoutedEventHandler(this.btn_saha_sil_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_saha_pasif = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Pages\SahaPage.xaml"
            this.btn_saha_pasif.Click += new System.Windows.RoutedEventHandler(this.btn_saha_pasif_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cmbox_saha_data = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\Pages\SahaPage.xaml"
            this.cmbox_saha_data.Loaded += new System.Windows.RoutedEventHandler(this.cmbox_saha_data_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
