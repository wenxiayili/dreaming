﻿

#pragma checksum "E:\WP源码\dreaming\dreaming\Views\Dreaming.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "14A764029F747DFF3A4A4C6F4A693962"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dreaming.Views
{
    partial class Dreaming : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 136 "..\..\..\Views\Dreaming.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.cancel_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 145 "..\..\..\Views\Dreaming.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.stop_Tapped;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 152 "..\..\..\Views\Dreaming.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.accept_Tapped;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 62 "..\..\..\Views\Dreaming.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.song_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 175 "..\..\..\Views\Dreaming.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.record_Click_1;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 176 "..\..\..\Views\Dreaming.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.image_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


