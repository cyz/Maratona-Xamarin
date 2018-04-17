using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Evntr.Core.Controls
{
    public partial class SpeakerView : ContentView
    {
        public SpeakerView()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty AvatarUrlProperty =
            BindableProperty.Create(nameof(AvatarUrl), typeof(string), typeof(SpeakerView), "",
                                    propertyChanged: OnAvatarUrlChanged);

        private static void OnAvatarUrlChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var speakerView = (SpeakerView)bindable;

            speakerView.avatar.Source = (string)newValue;
        }

        public string AvatarUrl
        {
            get => (string)GetValue(AvatarUrlProperty);
            set => SetValue(AvatarUrlProperty, value);
        }

        public static readonly BindableProperty NameProperty =
            BindableProperty.Create(nameof(Name), typeof(string), typeof(SpeakerView), "",
                                    propertyChanged: OnNameChanged);

        private static void OnNameChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var speakerView = (SpeakerView)bindable;

            speakerView.name.Text = (string)newValue;
        }

        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }

        public static readonly BindableProperty MiniBioProperty =
            BindableProperty.Create(nameof(MiniBio), typeof(string), typeof(SpeakerView), "",
                                    propertyChanged: OnMiniBioChanged);

        private static void OnMiniBioChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var speakerView = (SpeakerView)bindable;

            speakerView.miniBio.Text = (string)newValue;
        }

        public string MiniBio
        {
            get => (string)GetValue(MiniBioProperty);
            set => SetValue(MiniBioProperty, value);
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(SpeakerView), Color.Black,
                                    propertyChanged: OnTextColorChanged);

        private static void OnTextColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var speakerView = (SpeakerView)bindable;

            var newColor = (Color)(newValue ?? TextColorProperty.DefaultValue);
            speakerView.name.TextColor = newColor;
            speakerView.miniBio.TextColor = newColor;
        }

        public Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }
    }
}
