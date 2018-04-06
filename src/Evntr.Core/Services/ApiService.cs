// ApiService.cs
// 
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Evntr.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Evntr.Core.Services
{
	public class ApiService
	{
		private const string BaseUrl = "https://monkey-hub-api.azurewebsites.net/api/";

		public async Task<List<Talk>> GetSchedule()
		{
			var httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			var response = await httpClient.GetAsync($"{BaseUrl}event/schedule").ConfigureAwait(false);

			if (response.IsSuccessStatusCode)
			{
				using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
				{
					return JsonConvert.DeserializeObject<List<Talk>>(
						await new StreamReader(responseStream)
							.ReadToEndAsync().ConfigureAwait(false));
				}
			}

			return null;
		}

		public async Task<Event> GetEvent()
		{
			var httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			var response = await httpClient.GetAsync($"{BaseUrl}event").ConfigureAwait(false);

			if (response.IsSuccessStatusCode)
			{
				using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
				{
					return JsonConvert.DeserializeObject<Event>(
						await new StreamReader(responseStream)
							.ReadToEndAsync().ConfigureAwait(false));
				}
			}

			return null;
		}
	}
}
