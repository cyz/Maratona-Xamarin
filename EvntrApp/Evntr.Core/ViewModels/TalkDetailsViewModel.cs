using System;
using System.Threading.Tasks;
using Evntr.Core.ViewModels.Base;
using Evntr.Models;
using Xamarin.Forms;

namespace Evntr.Core.ViewModels
{
    public class TalkDetailsViewModel : ViewModelBase
    {
        private Talk _talk;
        public Talk Talk
        {
            get { return _talk; }
            set
            {
                _talk = value;
                OnPropertyChanged();
            }
        }

        public TalkDetailsViewModel()
        {
        }

		public override async Task InitializeAsync(object navigationData)
		{
            Talk = navigationData as Talk;
		}
    }
}
