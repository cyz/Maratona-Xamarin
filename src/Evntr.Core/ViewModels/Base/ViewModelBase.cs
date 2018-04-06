// ViewModelBase.cs
// 
using System;
using System.Threading.Tasks;
using Evntr.Core.Services;
using Xamarin.Forms;

namespace Evntr.Core.ViewModels
{
	public abstract class ViewModelBase : BindableObject
	{
		protected readonly INavigationService NavigationService;
		protected readonly IDialogService DialogService;

		string _title;
		public string Title
		{
			get { return _title; }
			set { _title = value; OnPropertyChanged(); }
		}

		bool _isBusy;
		public bool IsBusy
		{
			get { return _isBusy; }
			set { _isBusy = value; OnPropertyChanged(); }
		}

		protected ViewModelBase() { }

		protected ViewModelBase(string title)
		{
			Title = title;
			NavigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
			DialogService = ViewModelLocator.Instance.Resolve<IDialogService>();
		}

		public virtual Task InitializeAsync(object navigationData)
		{
			return Task.FromResult(false);
		}
	}
}
