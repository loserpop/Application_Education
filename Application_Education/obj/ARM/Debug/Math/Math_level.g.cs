﻿#pragma checksum "D:\App\git\Application_Education\Application_Education\Math\Math_level.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A7FD54CDE4B7BDDF3AEC289DC99E3485"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Application_Education.Math
{
    partial class Math_level : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\Math\Math_level.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).DoubleTapped += this.button_DoubleTapped;
                    #line 35 "..\..\..\Math\Math_level.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 36 "..\..\..\Math\Math_level.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1).Click += this.button1_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.button2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 37 "..\..\..\Math\Math_level.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button2).Click += this.button2_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.but_home = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 38 "..\..\..\Math\Math_level.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.but_home).Click += this.but_home_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.but_back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 39 "..\..\..\Math\Math_level.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.but_back).Click += this.but_back_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

