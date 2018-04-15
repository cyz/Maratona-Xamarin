// ScheduleViewModel.cs
// 
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Evntr.Core.Services;
using Evntr.Core.ViewModels.Base;
using Evntr.Models;
using Xamarin.Forms;

namespace Evntr.Core.ViewModels
{
	public class ScheduleViewModel : ViewModelBase, IHandleViewAppearing
	{
        private ObservableCollection<Talk> _talks;
        private readonly INavigationService _navigationService;
        private readonly IApiService _apiService;

        public ObservableCollection<Talk> Talks
        {
            get { return _talks; }
            set
            {
                _talks = value;
                OnPropertyChanged();
            }
        }

        public ScheduleViewModel(IApiService apiService,
                                 INavigationService navigationService) : base("Agenda")
		{
            _navigationService = navigationService;
            _apiService = apiService;
		}

		public async Task OnViewAppearingAsync(VisualElement view)
		{
            Talks = new ObservableCollection<Talk>(await _apiService.GetSchedule());
		}

        public void NavigateToTalkDetails(Talk selectedTalk)
        {
            _navigationService.NavigateToAsync<TalkDetailsViewModel>(selectedTalk);
        }
	}
}
