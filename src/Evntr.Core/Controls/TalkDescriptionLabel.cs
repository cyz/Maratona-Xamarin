using System;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Evntr.Core.Controls
{
    public class TalkDescriptionLabel : Label
    {
        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == Label.TextProperty.PropertyName)
            {
                if (Text?.Length > 200)
                {
                    Text = $"{Text.Substring(0, Text.Length - 15)}... Leia Mais";
                }
            }
		}
	}
}
