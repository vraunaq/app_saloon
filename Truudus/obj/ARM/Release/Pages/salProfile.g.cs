﻿#pragma checksum "C:\Users\Desmond\Documents\Visual Studio 2017\Projects\Universal\Truudus\Truudus\Pages\salProfile.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E242BD12A04D83BE3E95BB09235C2211"
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
    partial class salProfile : 
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
                    #line 5 "..\..\..\Pages\salProfile.xaml"
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
                    this.proRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 11:
                {
                    this.splitHam = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                    #line 84 "..\..\..\Pages\salProfile.xaml"
                    ((global::Windows.UI.Xaml.Controls.SplitView)this.splitHam).PaneClosing += this.splitHam_PaneClosing;
                    #line default
                }
                break;
            case 12:
                {
                    this.listHam = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 94 "..\..\..\Pages\salProfile.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.listHam).SelectionChanged += this.listHam_SelectionChanged;
                    #line default
                }
                break;
            case 13:
                {
                    this.commentsSalListItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 14:
                {
                    this.searchSalListItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 15:
                {
                    this.aboutSalItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 16:
                {
                    this.logoutListItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 17:
                {
                    this.zBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.aBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19:
                {
                    this.pBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20:
                {
                    this.p1Box = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21:
                {
                    this.HamBut = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 76 "..\..\..\Pages\salProfile.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamBut).Click += this.HamBut_Click;
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
