﻿#pragma checksum "..\..\..\..\windows\NewTopic.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AC39CCAFE2DC4398899BB719AFF7A8F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
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


namespace IntelligensSzotar {
    
    
    /// <summary>
    /// NewTopic
    /// </summary>
    public partial class NewTopic : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\windows\NewTopic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textb_newTopicName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\windows\NewTopic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textb_lang1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\windows\NewTopic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textb_lang2;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\windows\NewTopic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_addNewTopic;
        
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
            System.Uri resourceLocater = new System.Uri("/Interaktív szótár;component/windows/newtopic.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\windows\NewTopic.xaml"
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
            this.textb_newTopicName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.textb_lang1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textb_lang2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btn_addNewTopic = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\windows\NewTopic.xaml"
            this.btn_addNewTopic.Click += new System.Windows.RoutedEventHandler(this.btn_addNewTopic_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

