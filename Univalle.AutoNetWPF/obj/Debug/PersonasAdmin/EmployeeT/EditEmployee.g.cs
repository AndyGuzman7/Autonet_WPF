﻿#pragma checksum "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9313C60C78164068AFCACCB25ED78C77F0D4B93F9FE9515AFF6ED3FB04AD0543"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Univalle.AutoNetWPF.PersonasAdmin.EmployeeT;


namespace Univalle.AutoNetWPF.PersonasAdmin.EmployeeT {
    
    
    /// <summary>
    /// EditEmployee
    /// </summary>
    public partial class EditEmployee : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombres;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrimerApellido;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSegundoApellido;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreUusuario;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbTipoUsuario;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpFechaNacimiento;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDireccion;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTelefono;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCi;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbGenero;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCorreo;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuadar;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalir;
        
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
            System.Uri resourceLocater = new System.Uri("/Univalle.AutoNetWPF;component/personasadmin/employeet/editemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
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
            
            #line 16 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
            ((Univalle.AutoNetWPF.PersonasAdmin.EmployeeT.EditEmployee)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtNombres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtPrimerApellido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtSegundoApellido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtNombreUusuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.cmbTipoUsuario = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.dtpFechaNacimiento = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.txtDireccion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txtTelefono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txtCi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.cmbGenero = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            this.txtCorreo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.btnGuadar = ((System.Windows.Controls.Button)(target));
            
            #line 189 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
            this.btnGuadar.Click += new System.Windows.RoutedEventHandler(this.btnGuadar_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.btnSalir = ((System.Windows.Controls.Button)(target));
            
            #line 192 "..\..\..\..\PersonasAdmin\EmployeeT\EditEmployee.xaml"
            this.btnSalir.Click += new System.Windows.RoutedEventHandler(this.btnSalir_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
