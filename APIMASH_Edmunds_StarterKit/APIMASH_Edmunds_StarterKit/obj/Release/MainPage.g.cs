﻿

#pragma checksum "C:\Users\robfamil\Documents\Visual Studio 2012\Cookbooks\APIMASH_Edmunds_StarterKit\APIMASH_Edmunds_StarterKit\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "87E7E191B442455211C6F2C59FED987F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIMASH_Edmunds_StarterKit
{
    partial class MainPage : global::APIMASH_Edmunds_StarterKit.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 35 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.YearCombo_OnSelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 55 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.MakeCombo_OnSelectionChanged;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 67 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.ModelList_OnSelectionChanged;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

