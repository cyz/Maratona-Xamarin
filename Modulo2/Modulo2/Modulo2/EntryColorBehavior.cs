using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Modulo2
{
    public class EntryColorBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += TextChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= TextChanged;
            base.OnDetachingFrom(bindable);
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = sender as Entry;

            if (string.IsNullOrEmpty(entry.Text)) return;

            if (entry.Text.Length >= 3 && entry.Text.Length <= 5)
                entry.TextColor = Color.Green;
            else if (entry.Text.Length > 5)
                entry.TextColor = Color.Blue;
            else
                entry.TextColor = Color.Black;
        }
    }
}
