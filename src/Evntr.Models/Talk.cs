// Talk.cs
// 
using System;
namespace Evntr.Models
{
	public class Talk : BaseModel
	{
		public string EventId { get; set; }

		public string Title { get; set; }
		public string Description { get; set; }
		public ScheduleDay ScheduleDay { get; set; }
		public Speaker Speaker { get; set; }
	}
}
