// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Jingying.App.Core {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class MainPage : ContentPage {
        
        private ToolbarItem ok;
        
        private ToolbarItem no;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(MainPage));
            ok = this.FindByName <ToolbarItem>("ok");
            no = this.FindByName <ToolbarItem>("no");
        }
    }
}
