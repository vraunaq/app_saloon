﻿#pragma checksum "C:\Users\Desmond\Documents\Visual Studio 2015\Projects\Personal\C#\Universal\Truudus\Truudus\Pages\userProfile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5E590F4EF89309C00146FD73678CDBF9"
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
    partial class userProfile : 
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
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 5 "..\..\..\Pages\userProfile.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.userPic = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 3:
                {
                    this.NameBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.city = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.state = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.pin = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.CityBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.StateBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.PinBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.UserProfileBut = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 11:
                {
                    this.SaloonSearchBut = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 73 "..\..\..\Pages\userProfile.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SaloonSearchBut).Click += this.SaloonSearchBut_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.logoutBut = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 79 "..\..\..\Pages\userProfile.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.logoutBut).Click += this.logoutBut_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.proRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
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

