// MainViewModel.cs
// 
using System;
namespace Evntr.Core.ViewModels
{
	public class MainViewModel : ViewModelBase
	{
		AboutViewModel _aboutViewModel;
		ScheduleViewModel _scheduleViewModel;
		GeneralViewModel _generalViewModel;

        public AboutViewModel AboutViewModel
		{
			get { return _aboutViewModel; }
			set
			{
				_aboutViewModel = value;
				OnPropertyChanged();
			}
		}

        public ScheduleViewModel ScheduleViewModel
		{
			get { return _scheduleViewModel; }
			set
			{
				_scheduleViewModel = value;
				OnPropertyChanged();
			}
		}

        public GeneralViewModel GeneralViewModel
		{
			get { return _generalViewModel; }
			set
			{
				_generalViewModel = value;
				OnPropertyChanged();
			}
		}

		public MainViewModel(AboutViewModel aboutViewModel,
							 ScheduleViewModel scheduleViewModel,
							 GeneralViewModel generalViewModel)
		{
			_aboutViewModel = aboutViewModel;
			_scheduleViewModel = scheduleViewModel;
			_generalViewModel = generalViewModel;
		}
	}
}