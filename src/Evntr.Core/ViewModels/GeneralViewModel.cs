// GeneralViewModel.cs
// 
using System;
using System.Threading.Tasks;
using Evntr.Core.ViewModels.Base;
using Xamarin.Forms;

namespace Evntr.Core.ViewModels
{
	public class GeneralViewModel : ViewModelBase, IHandleViewAppearing, IHandleViewDisappearing
	{
		public GeneralViewModel() : base("Geral")
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
