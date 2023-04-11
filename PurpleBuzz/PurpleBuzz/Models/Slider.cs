using System;
namespace PurpleBuzz.Models
{
	public class Slider: BaseEntity
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string IsActive { get; set; }
	}
}