// NavigationService.cs
// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evntr.Core.ViewModels;
using Evntr.Core.Views;
using Xamarin.Forms;

namespace Evntr.Core.Services
{
	public class NavigationService : INavigationService
	{
		protected readonly Dictionary<Type, Type> _mappings;

		protected Application CurrentApplication
		{
			get { return Application.Current; }
		}

		public NavigationService()
		{
			_mappings = new Dictionary<Type, Type>();
			CreatePageViewModelMappings();
		}

		public async Task InitializeAsync()
			=> await NavigateToAsync<MainViewModel>();

		public Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase
			=> InternalNavigateToAsync(typeof(TViewModel), null);

		public Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase
			=> InternalNavigateToAsync(typeof(TViewModel), parameter);

		public Task NavigateToAsync(Type viewModelType)
			=> InternalNavigateToAsync(viewModelType, null);

		public Task NavigateToAsync(Type viewModelType, object parameter)
			=> InternalNavigateToAsync(viewModelType, parameter);

		public async Task NavigateBackAsync()
		{
			if (CurrentApplication.MainPage != null)
				await CurrentApplication.MainPage.Navigation.PopAsync();
		}

		public async Task NavigateAndClearBackStackAsync<TViewModel>(object parameter = null) where TViewModel : ViewModelBase
		{
			try
			{
				Page page = CreateAndBindPage(typeof(TViewModel), parameter);
				var navigationPage = CurrentApplication.MainPage as NavigationPage;

				await navigationPage.PushAsync(page);

				await (page.BindingContext as ViewModelBase).InitializeAsync(parameter);

				if (navigationPage != null && navigationPage.Navigation.NavigationStack.Count > 0)
				{
					var existingPages = navigationPage.Navigation.NavigationStack.ToList();

					foreach (var existingPage in existingPages)
					{
						if (existingPage != page)
							navigationPage.Navigation.RemovePage(existingPage);
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception($"NavigateAndClearBackStackAsync: {ex.Message}");
			}
		}

		public virtual Task RemoveLastFromBackStackAsync()
		{
			throw new NotImplementedException();
		}

		async Task InternalNavigateToAsync(Type viewModelType, object parameter)
		{
			Page page = CreateAndBindPage(viewModelType, parameter);

			if (page is MainView)
			{
                CurrentApplication.MainPage = new NavigationPage(page);
			}
			else
			{
				var navigationPage = CurrentApplication.MainPage as NavigationPage;

				if (navigationPage != null)
				{
					await navigationPage.PushAsync(page);
				}
				else
				{
					CurrentApplication.MainPage = new NavigationPage(page);
				}
			}

			await (page.BindingContext as ViewModelBase).InitializeAsync(parameter);
		}

		Type GetPageTypeForViewModel(Type viewModelType)
		{
			if (!_mappings.ContainsKey(viewModelType))
			{
				throw new KeyNotFoundException($"No map for ${viewModelType} was found on navigation mappings");
			}

			return _mappings[viewModelType];
		}

		Page CreateAndBindPage(Type viewModelType, object parameter)
		{
			Type pageType = GetPageTypeForViewModel(viewModelType);

			if (pageType == null)
			{
				throw new Exception($"Mapping type for {viewModelType} is not a page");
			}

			Page page = Activator.CreateInstance(pageType) as Page;
			ViewModelBase viewModel = ViewModelLocator.Instance.Resolve(viewModelType) as ViewModelBase;
			page.BindingContext = viewModel;

			return page;
		}

		void CreatePageViewModelMappings()
		{
			_mappings.Add(typeof(MainViewModel), typeof(MainView));
			_mappings.Add(typeof(AboutViewModel), typeof(AboutView));
			_mappings.Add(typeof(ScheduleViewModel), typeof(ScheduleView));
			_mappings.Add(typeof(GeneralViewModel), typeof(GeneralView));
            _mappings.Add(typeof(TalkDetailsViewModel), typeof(TalkDetailsView));
		}
	}
}
