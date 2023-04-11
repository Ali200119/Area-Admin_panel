using System;
namespace PurpleBuzz.Models
{
	public class About: BaseEntity
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public string BackgroundImage { get; set; }
	}
}