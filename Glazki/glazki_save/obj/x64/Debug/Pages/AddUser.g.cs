﻿#pragma checksum "..\..\..\..\Pages\AddUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B5A1AD8C34CFF135EFA48A97C44A921D4A184CF6EE7F2F6F571E81FBD4A29345"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using glazki_save.Pages;


namespace glazki_save.Pages {
    
    
    /// <summary>
    /// AddUser
    /// </summary>
    public partial class AddUser : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Pages\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBx_Login;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Pages\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PBx_Password;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowPass;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Pages\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HashPass;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Pages\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rc2Pass;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Pages\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Passwd;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Pages\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBx_FIO;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Pages\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbRole;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Pages\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLogin;
        
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
            System.Uri resourceLocater = new System.Uri("/glazki_save;component/pages/adduser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AddUser.xaml"
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
            this.TBx_Login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PBx_Password = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.ShowPass = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Pages\AddUser.xaml"
            this.ShowPass.Click += new System.Windows.RoutedEventHandler(this.ShowPass_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.HashPass = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Pages\AddUser.xaml"
            this.HashPass.Click += new System.Windows.RoutedEventHandler(this.HashPass_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rc2Pass = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\Pages\AddUser.xaml"
            this.rc2Pass.Click += new System.Windows.RoutedEventHandler(this.RC2Pass_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Passwd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TBx_FIO = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.CmbRole = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.BtnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\Pages\AddUser.xaml"
            this.BtnLogin.Click += new System.Windows.RoutedEventHandler(this.BtnLogin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
