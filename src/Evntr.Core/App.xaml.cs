// App.xaml.cs
// 
using System;
using System.Collections.Generic;
using Evntr.Core.Services;
using Evntr.Core.ViewModels;
using Xamarin.Forms;

namespace Evntr.Core
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			BuildDependencies();
			InitNavigation();
		}

		public void BuildDependencies()
		{
			ViewModelLocator.Instance.Build();
		}

		private async void InitNavigation()
		{
			var navigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
			await navigationService.InitializeAsync();
		}

		protected override void OnStart()
		{
		}
	}
}
