// AboutViewModel.cs
// 
using System;
using System.Threading.Tasks;
using Evntr.Core.ViewModels.Base;
using Xamarin.Forms;

namespace Evntr.Core.ViewModels
{
	public class AboutViewModel : ViewModelBase, IHandleViewAppearing, IHandleViewDisappearing
	{
		public AboutViewModel() : base("Sobre")
		{
		}

		public Task OnViewAppearingAsync(VisualElement view)
		{
            return Task.FromResult(true);
		}

		public Task OnViewDisappearingAsync(VisualElement view)
		{
            return Task.FromResult(true);
		}
	}
}
