#pragma checksum "..\..\..\..\Pages\captcha.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "21A0BD24B551BBBA4705E194C848674C42BF5D79D290F487C2595E5A3B49D367"
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
    /// captcha
    /// </summary>
    public partial class captcha : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Pages\captcha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SPanelSymbols;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Pages\captcha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas CanvasNoise;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Pages\captcha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CaptchatextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Pages\captcha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUpdateCaptcha1;
        
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
            System.Uri resourceLocater = new System.Uri("/glazki_save;component/pages/captcha.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\captcha.xaml"
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
            this.SPanelSymbols = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.CanvasNoise = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.CaptchatextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BtnUpdateCaptcha1 = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Pages\captcha.xaml"
            this.BtnUpdateCaptcha1.Click += new System.Windows.RoutedEventHandler(this.BtnUpdateCaptcha1_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 24 "..\..\..\..\Pages\captcha.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

