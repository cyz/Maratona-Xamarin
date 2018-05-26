using Modulo2.Droid;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("MyEffects")]
[assembly: ExportEffect(typeof(EntryFocusEffect), "EntryFocusEffect")]
namespace Modulo2.Droid
{
    public class EntryFocusEffect : PlatformEffect
    {
        Android.Graphics.Color _color = Android.Graphics.Color.Blue;

        protected override void OnAttached()
        {
            this.Control.SetBackgroundColor(this._color);
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if(args.PropertyName.Equals("IsFocused"))
            {
                var background = (Android.Graphics.Drawables.ColorDrawable)this.Control.Background;
                if (background.Color == this._color)
                    this.Control.SetBackgroundColor(Android.Graphics.Color.Green); //Palestra Itália :) Valew Will!!!
                else
                    this.Control.SetBackgroundColor(this._color);
            }
        }

        protected override void OnDetached(){}
    }
}