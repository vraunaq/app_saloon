﻿#pragma checksum "C:\Users\Desmond\Documents\Visual Studio 2015\Projects\Personal\C#\Universal\Truudus\Truudus\Pages\saloonRegister.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1BB20156FD9A80FCDEFC981AA1B20A53"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Truudus.Pages
{
    partial class saloonRegister : 
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
                    this.sname = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2:
                {
                    this.email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.shortDescbox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    this.goNext = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 57 "..\..\..\Pages\saloonRegister.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.goNext).Click += this.goNext_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.goBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 60 "..\..\..\Pages\saloonRegister.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.goBack).Click += this.goBack_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.welcomeRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
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

