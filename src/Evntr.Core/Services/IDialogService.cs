// IDialogService.cs
// 
using System;
using System.Threading.Tasks;

namespace Evntr.Core.Services
{
	public interface IDialogService
	{
		Task<string> ActionSheetAsync(string title, string cancel, string destruction, params string[] buttons);
		Task AlertAsync(string title, string message, string cancel);
		Task<bool> AlertAsync(string title, string message, string accept, string cancel);
	}
}
