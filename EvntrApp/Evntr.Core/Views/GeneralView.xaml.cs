// GeneralView.xaml.cs
// 
using System;
using System.Collections.Generic;
using Evntr.Core.ViewModels.Base;
using Xamarin.Forms;

namespace Evntr.Core.Views
{
	public partial class GeneralView : ContentPage
	{
		public GeneralView()
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
