using Xamarin.Forms;

namespace Modulo2
{
    public class ItemTappedEventTrigger : TriggerAction<ListView>
    {
        protected override void Invoke(ListView sender)
        {
            var item = sender.SelectedItem as Models.Item;
            App.Current.MainPage.DisplayAlert("Event Trigger", item.Name, "Ok");
        }
    }
}
