﻿

#pragma checksum "c:\Sites\WindowsEightTweaks\WindowsEightTweaks\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1490E733E3B260B1D2BA57E253508C61"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace WindowsEightTweaks
{
    partial class MainPage : Windows.UI.Xaml.Controls.Page, IComponentConnector
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 18 "..\..\MainPage.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SaveApp;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


