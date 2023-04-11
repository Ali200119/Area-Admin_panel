using System;
namespace PurpleBuzz.Models
{
	public class Team: BaseEntity
	{
		public string Description { get; set; }
		public ICollection<TeamMember> TeamMembers { get; set; }
	}
}