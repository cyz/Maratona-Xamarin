using System;
using Xamarin.Forms;

namespace Evntr.Core.Controls
{
    public class Checkbox : View
    {
        public static BindableProperty IsCheckedProperty 
            = BindableProperty.Create(nameof(IsChecked), typeof(bool), typeof(Checkbox), false);
    
        public bool IsChecked
        {
            get => (bool)GetValue(IsCheckedProperty);
            set => SetValue(IsCheckedProperty, value);
        }
    }
}
