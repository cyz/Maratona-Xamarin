using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using CoreAnimation;
using CoreGraphics;
using Evntr.Core.Controls;
using Evntr.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CircleImage), typeof(CircleImageRenderer))]
namespace Evntr.iOS.Renderers
{
    public class CircleImageRenderer : ImageRenderer
    {
		protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
		{
            base.OnElementChanged(e);

            if (Element != null)
                CreateCircle();
		}

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == VisualElement.HeightProperty.PropertyName ||
                e.PropertyName == VisualElement.WidthProperty.PropertyName)
            {
                CreateCircle();
            }
        }

        private void CreateCircle()
        {
            try
            {
                var min = Math.Min(Element.Width, Element.Height);
                Control.Layer.CornerRadius = (float)(min / 2.0);
                Control.Layer.MasksToBounds = false;
                Control.BackgroundColor = Color.Transparent.ToUIColor();
                Control.ClipsToBounds = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Unable to create circle image: " + ex);
            }
        }
	}
}
