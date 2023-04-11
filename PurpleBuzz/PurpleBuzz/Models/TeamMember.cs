using System;
namespace PurpleBuzz.Models
{
	public class TeamMember: BaseEntity
	{
		public string Image { get; set; }
		public string FullName { get; set; }
		public string Postiton { get; set; }
		public int TeamId { get; set; }
		public Team Team { get; set; }
	}
}