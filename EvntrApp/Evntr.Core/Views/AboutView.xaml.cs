// AboutView.xaml.cs
// 
using System;
using System.Collections.Generic;
using Evntr.Core.ViewModels.Base;
using Xamarin.Forms;

namespace Evntr.Core.Views
{
	public partial class AboutView : ContentPage
	{
		public AboutView()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			if (BindingContext is IHandleViewAppearing viewAware)
			{
				await viewAware.OnViewAppearingAsync(this);
			}
		}

		protected override async void OnDisappearing()
		{
			if (BindingContext is IHandleViewDisappearing viewAware)
			{
				await viewAware.OnViewDisappearingAsync(this);
			}
		}
	}
}
