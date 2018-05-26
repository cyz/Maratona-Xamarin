// GeneralViewModel.cs
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
	public class GeneralViewModel : ViewModelBase, IHandleViewAppearing
	{
        private readonly IApiService _apiService;

        private Event _event;
        public Event Event
        {
            get { return _event; }
            set
            {
                _event = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Speaker> _speakers;
        public ObservableCollection<Speaker> Speakers
        {
            get { return _speakers; }
            set
            {
                _speakers = value;
                OnPropertyChanged();
            }
        }

        public GeneralViewModel(IApiService apiService) : base("Geral")
		{
            _apiService = apiService;
		}

		public async Task OnViewAppearingAsync(VisualElement view)
		{
            Event = await _apiService.GetEvent();
            Speakers = new ObservableCollection<Speaker>(Event.Speakers);
		}
	}
}
