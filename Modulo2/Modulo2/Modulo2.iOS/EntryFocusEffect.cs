using System;
using System.ComponentModel;
using Modulo2.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("MyEffects")]
[assembly: ExportEffect(typeof(EntryFocusEffect), "EntryFocusEffect")]
namespace Modulo2.iOS
{
    public class EntryFocusEffect : PlatformEffect
    {
        UIColor _color = UIColor.Blue;

        protected override void OnAttached()
        {
            this.Control.BackgroundColor = this._color;
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if(args.PropertyName.Equals("IsFocused"))
            {
                if (this.Control.BackgroundColor == this._color)
                    this.Control.BackgroundColor = UIColor.Green;
                else
                    this.Control.BackgroundColor = this._color;
            }
        }

        protected override void OnDetached() { }
    }
}