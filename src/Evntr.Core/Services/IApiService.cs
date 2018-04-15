// IApiService.cs
// 
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Evntr.Models;

namespace Evntr.Core.Services
{
	public interface IApiService
	{
        Task<List<Talk>> GetSchedule();
        Task<Event> GetEvent();
	}
}
