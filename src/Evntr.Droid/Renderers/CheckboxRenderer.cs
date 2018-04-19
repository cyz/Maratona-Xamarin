using Android.Content;
using Android.Support.V7.Widget;
using Evntr.Core.Controls;
using Evntr.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using static Android.Widget.CompoundButton;
using ACheckbox = Android.Widget.CheckBox;

[assembly: ExportRenderer(typeof(Checkbox), typeof(CheckboxRenderer))]
namespace Evntr.Droid.Renderers
{
    public class CheckboxRenderer : ViewRenderer<Checkbox, ACheckbox>
    {
        public CheckboxRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Checkbox> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var checkBox = new ACheckbox(Context);

                SetNativeControl(checkBox);
            }

            if (e.NewElement != null)
            {
                Control.CheckedChange += OnCheckChanged;

                Control.Checked = e.NewElement.IsChecked;
            }

            if (e.OldElement != null)
            {
                Control.CheckedChange -= OnCheckChanged;
            }
        }

        private void OnCheckChanged(object sender, CheckedChangeEventArgs e) 
            => Element.IsChecked = e.IsChecked;
    }
}
