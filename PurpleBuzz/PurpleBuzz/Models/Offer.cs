using System;
namespace PurpleBuzz.Models
{
	public class Offer: BaseEntity
	{
		public string Description { get; set; }
		public int PackageId { get; set; }
		public Package Package { get; set; }
	}
}