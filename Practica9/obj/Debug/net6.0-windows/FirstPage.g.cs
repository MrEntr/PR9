﻿#pragma checksum "..\..\..\FirstPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DDA3CDAB329003AFF1719FA0E02E774139ADAAC2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Accessibility;
using MahApps.Metro.Actions;
using MahApps.Metro.Automation.Peers;
using MahApps.Metro.Behaviors;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Converters;
using MahApps.Metro.Markup;
using MahApps.Metro.Theming;
using MahApps.Metro.ValueBoxes;
using Practica9;
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


namespace Practica9 {
    
    
    /// <summary>
    /// FirstPage
    /// </summary>
    public partial class FirstPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView messagesLV;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem OpenContext;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem SendContext;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MahApps.Metro.Controls.ProgressRing loadingProgressRing;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\FirstPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame contentFrame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Practica9;component/firstpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FirstPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.messagesLV = ((System.Windows.Controls.ListView)(target));
            
            #line 14 "..\..\..\FirstPage.xaml"
            this.messagesLV.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.MessagesLV_OnMouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.OpenContext = ((System.Windows.Controls.MenuItem)(target));
            
            #line 23 "..\..\..\FirstPage.xaml"
            this.OpenContext.Click += new System.Windows.RoutedEventHandler(this.OpenContext_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SendContext = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\..\FirstPage.xaml"
            this.SendContext.Click += new System.Windows.RoutedEventHandler(this.SendContext_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.loadingProgressRing = ((MahApps.Metro.Controls.ProgressRing)(target));
            return;
            case 5:
            this.contentFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

