﻿#pragma checksum "..\..\..\..\Ventanas\TipoHabitacionWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "810CF82A8A48288468D0761C93DC1171439EE861"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using HotelManager.Ventanas;
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


namespace HotelManager.Ventanas {
    
    
    /// <summary>
    /// TipoHabitacionWindow
    /// </summary>
    public partial class TipoHabitacionWindow : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\Ventanas\TipoHabitacionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboHoteles;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Ventanas\TipoHabitacionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgTiposHabitacion;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Ventanas\TipoHabitacionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCantidadPersona;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Ventanas\TipoHabitacionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrecio;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Ventanas\TipoHabitacionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Ventanas\TipoHabitacionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDescripcion;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Ventanas\TipoHabitacionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregar;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Ventanas\TipoHabitacionWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/HotelManager;V1.0.0.0;component/ventanas/tipohabitacionwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Ventanas\TipoHabitacionWindow.xaml"
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
            this.cboHoteles = ((System.Windows.Controls.ComboBox)(target));
            
            #line 16 "..\..\..\..\Ventanas\TipoHabitacionWindow.xaml"
            this.cboHoteles.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboHoteles_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dgTiposHabitacion = ((System.Windows.Controls.DataGrid)(target));
            
            #line 18 "..\..\..\..\Ventanas\TipoHabitacionWindow.xaml"
            this.dgTiposHabitacion.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgTiposHabitacion_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtCantidadPersona = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtPrecio = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtDescripcion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnAgregar = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Ventanas\TipoHabitacionWindow.xaml"
            this.btnAgregar.Click += new System.Windows.RoutedEventHandler(this.btnAgregar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnActualizar = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Ventanas\TipoHabitacionWindow.xaml"
            this.btnActualizar.Click += new System.Windows.RoutedEventHandler(this.btnActualizar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

