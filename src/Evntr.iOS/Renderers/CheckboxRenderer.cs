using System;
using Evntr.Core.Controls;
using Evntr.iOS.Renderers;
using SaturdayMP.XPlugins.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Checkbox), typeof(CheckboxRenderer))]
namespace Evntr.iOS.Renderers
{
    public class CheckboxRenderer : ViewRenderer<Checkbox, BEMCheckBox>
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Checkbox> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var checkBox = new BEMCheckBox();
                ConfigStyle(checkBox);

                SetNativeControl(checkBox);
            }

            if (e.NewElement != null)
            {
                Control.On = e.NewElement.IsChecked;
                Control.ValueChanged += OnCheckChanged;
            }

            if (e.OldElement != null)
            {
                Control.ValueChanged -= OnCheckChanged;
            }
        }

        private static void ConfigStyle(BEMCheckBox checkBox)
        {
            var checkboxColor = Color.FromHex("#ED3941").ToUIColor();

            checkBox.BoxType = BEMBoxType.Square;
            checkBox.OnAnimationType = BEMAnimationType.Fill;
            checkBox.OffAnimationType = BEMAnimationType.Fill;
            checkBox.AnimationDuration = 0.25f;
            checkBox.OnFillColor = checkboxColor;
            checkBox.OnTintColor = checkboxColor;
            checkBox.OnCheckColor = Color.White.ToUIColor();
        }

        private void OnCheckChanged(object sender, EventArgs e)
            => Element.IsChecked = Control.On;
    }
}
