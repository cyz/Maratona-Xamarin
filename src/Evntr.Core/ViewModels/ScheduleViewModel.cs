// ScheduleViewModel.cs
// 
using System;
using System.Threading.Tasks;
using Evntr.Core.ViewModels.Base;
using Xamarin.Forms;

namespace Evntr.Core.ViewModels
{
	public class ScheduleViewModel : ViewModelBase, IHandleViewAppearing, IHandleViewDisappearing
	{
		public ScheduleViewModel() : base("Agenda")
		{
		}

		public Task OnViewAppearingAsync(VisualElement view)
		{
			throw new NotImplementedException();
		}

		public Task OnViewDisappearingAsync(VisualElement view)
		{
			throw new NotImplementedException();
		}
	}
}
