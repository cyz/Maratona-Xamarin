// EventController.cs
// 
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Evntr.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Evntr.Api.Controllers
{
	[Route("api/[controller]")]
	public class EventController : Controller
	{
		readonly IEventRepository _eventRepository;

		public EventController(IEventRepository eventRepository)
		{
			_eventRepository = eventRepository;
		}

		// GET api/event
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var @event = await _eventRepository.Get();
			return Ok(@event);
		}

		[HttpGet]
		[Route("schedule")]
		public async Task<IActionResult> GetSchedule()
		{
			var schedule = await _eventRepository.GetSchedule();
			return Ok(schedule);
		}
	}
}
