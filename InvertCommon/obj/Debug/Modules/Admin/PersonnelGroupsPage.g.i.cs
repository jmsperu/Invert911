﻿#pragma checksum "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A42E1EC38D95DFF54588F8645C5D9B34"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Invert911.InvertCommon.StandardGui;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Invert911.InvertCommon.Modules.Admin {
    
    
    /// <summary>
    /// PersonnelGroupsPage
    /// </summary>
    public partial class PersonnelGroupsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RefreshButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelButton;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AgencyLabel;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Invert911.InvertCommon.StandardGui.i9ComboBox AgencyComboBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ErrorMsgLabel;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox SecurityGroupsListView;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView PersonnelListView;
        
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
            System.Uri resourceLocater = new System.Uri("/Invert911.InvertCommon;component/modules/admin/personnelgroupspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 8 "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml"
            ((Invert911.InvertCommon.Modules.Admin.PersonnelGroupsPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RefreshButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml"
            this.RefreshButton.Click += new System.Windows.RoutedEventHandler(this.RefreshButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SaveButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml"
            this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml"
            this.CancelButton.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AgencyLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.AgencyComboBox = ((Invert911.InvertCommon.StandardGui.i9ComboBox)(target));
            return;
            case 7:
            this.ErrorMsgLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.SecurityGroupsListView = ((System.Windows.Controls.ListBox)(target));
            
            #line 63 "..\..\..\..\Modules\Admin\PersonnelGroupsPage.xaml"
            this.SecurityGroupsListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SecurityGroupsListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.PersonnelListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

