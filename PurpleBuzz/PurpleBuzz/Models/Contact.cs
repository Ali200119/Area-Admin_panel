using System;
namespace PurpleBuzz.Models
{
	public class Contact: BaseEntity
	{
		public string Title { get; set; }
		public string Subtitle { get; set; }
		public string Description { get; set; }
		public string BackgroundImage { get; set; }
	}
}