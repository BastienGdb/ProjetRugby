﻿#pragma checksum "..\..\CréationMatch.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B73727495D995406B9F1B31D1139D9A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using vue;


namespace vue {
    
    
    /// <summary>
    /// CréationMatch
    /// </summary>
    public partial class CréationMatch : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\CréationMatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox compet;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\CréationMatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox equipeA;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\CréationMatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox scoreA;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\CréationMatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nbessaiA;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\CréationMatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox equipeB;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\CréationMatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox scoreB;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\CréationMatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nbessaiB;
        
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
            System.Uri resourceLocater = new System.Uri("/projet;component/cr%c3%a9ationmatch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CréationMatch.xaml"
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
            this.compet = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.equipeA = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.scoreA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.nbessaiA = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.equipeB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.scoreB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.nbessaiB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 48 "..\..\CréationMatch.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.retour);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

