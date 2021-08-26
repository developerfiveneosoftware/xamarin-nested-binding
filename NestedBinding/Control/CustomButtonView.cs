using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NestedBinding.Control
{
    public class CustomButtonView : Button
    {
        public static readonly BindableProperty CustomTextProperty = BindableProperty.Create("CustomText", typeof(string), typeof(CustomButtonView), "Default");
        public string CustomText
        {
            get { return (string)base.GetValue(CustomTextProperty); }
            set 
            { 
                base.SetValue(CustomTextProperty, value);
                Text = value;
            }
        }

        public CustomButtonView()
        {
            Text = CustomText;
        }
    }
}
