// IHandleViewAppearing.cs
// 
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Evntr.Core.ViewModels.Base
{
	public interface IHandleViewAppearing
	{
		Task OnViewAppearingAsync(VisualElement view);
	}
}
