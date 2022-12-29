using DynamicForms.UIConstants;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DynamicForms.Controls
{
    public class DropdownControls : Picker
    {
        public string ControlResourceId { get; set; }
        public DropdownControls()
        {
            base.Margin = new Thickness(50, 0, 50, 0);
            base.FontSize = 14;
            this.ControlResourceId = Guid.NewGuid().ToString();
            base.TextColor = Color.FromHex(Constants.Theme_Control_Text_Color);
        }
    }
}
