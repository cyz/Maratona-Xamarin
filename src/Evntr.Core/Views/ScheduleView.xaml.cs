// ScheduleView.xaml.cs
// 
using System;
using System.Collections.Generic;
using Evntr.Core.Services;
using Evntr.Core.ViewModels;
using Evntr.Core.ViewModels.Base;
using Evntr.Models;
using Xamarin.Forms;

namespace Evntr.Core.Views
{
	public partial class ScheduleView : ContentPage
	{
		public ScheduleView()
		{
            InitializeComponent();

			listViewTalks.ItemSelected += (sender, e) =>
            {
                var selectedTalk = ((ListView)sender).SelectedItem as Talk;

                if (selectedTalk != null && BindingContext is ScheduleViewModel viewModel)
                {
                    viewModel.NavigateToTalkDetails(selectedTalk);
                }
            };
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
