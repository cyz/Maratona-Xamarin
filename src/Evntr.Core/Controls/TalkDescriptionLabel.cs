using System;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Evntr.Core.Controls
{
    public class TalkDescriptionLabel : Label
    {
        public static readonly BindableProperty MaxLengthProperty =
            BindableProperty.Create(nameof(MaxLength), typeof(int), typeof(TalkDescriptionLabel), 200);

        public int MaxLength
        {
            get => (int)GetValue(MaxLengthProperty);
            set => SetValue(MaxLengthProperty, value);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == Label.TextProperty.PropertyName)
            {
                if (Text?.Length > MaxLength)
                {
                    Text = $"{Text.Substring(0, MaxLength - 15)}... Leia Mais";
                }
            }
		}
	}
}
