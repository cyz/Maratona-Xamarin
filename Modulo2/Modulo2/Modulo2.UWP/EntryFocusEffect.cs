using Modulo2.UWP;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ResolutionGroupName("MyEffects")]
[assembly: ExportEffect(typeof(EntryFocusEffect), "EntryFocusEffect")]
namespace Modulo2.UWP
{
    public class EntryFocusEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var control = this.Control as Windows.UI.Xaml.Controls.Control;
            var textbox = this.Control as FormsTextBox;

            control.Background = new SolidColorBrush(Colors.Blue);
            textbox.BackgroundFocusBrush = new SolidColorBrush(Colors.Green);
        }

        protected override void OnDetached() { }
    }
}
