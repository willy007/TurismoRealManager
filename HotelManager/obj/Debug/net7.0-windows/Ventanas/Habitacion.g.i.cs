﻿#pragma checksum "..\..\..\..\Ventanas\Habitacion.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D03F11EA7FAC9BA0131FB41F96DE7A584A6DEBB2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using HotelManager;
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


namespace HotelManager {
    
    
    /// <summary>
    /// Habitacion
    /// </summary>
    public partial class Habitacion : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Ventanas\Habitacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgHabitacoines;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Ventanas\Habitacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboHoteles;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Ventanas\Habitacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboEstado;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Ventanas\Habitacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEnumeracion;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Ventanas\Habitacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboTipoHabitacion;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Ventanas\Habitacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Ventanas\Habitacion.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnActualizar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HotelManager;V1.0.0.0;component/ventanas/habitacion.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Ventanas\Habitacion.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dgHabitacoines = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\..\..\Ventanas\Habitacion.xaml"
            this.dgHabitacoines.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgHabitacoines_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboHoteles = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\..\..\Ventanas\Habitacion.xaml"
            this.cboHoteles.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboHoteles_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cboEstado = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.txtEnumeracion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.cboTipoHabitacion = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.btnAgregar = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Ventanas\Habitacion.xaml"
            this.btnAgregar.Click += new System.Windows.RoutedEventHandler(this.btnAgregar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnActualizar = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Ventanas\Habitacion.xaml"
            this.btnActualizar.Click += new System.Windows.RoutedEventHandler(this.btnActualizar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
