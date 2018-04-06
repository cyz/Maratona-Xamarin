// BaseModel.cs
// 
using System;
namespace Evntr.Models
{
	public class BaseModel
	{
		public string Id { get; set; }

		public BaseModel()
		{
			Id = Guid.NewGuid().ToString();
		}
	}
}
