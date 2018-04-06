// Speaker.cs
// 
using System;
namespace Evntr.Models
{
	public class Speaker : BaseModel
	{
		public string Name { get; set; }
		public string Title { get; set; }
		public string MiniBio { get; set; }
		public string AvatarUrl { get; set; }
	}
}
