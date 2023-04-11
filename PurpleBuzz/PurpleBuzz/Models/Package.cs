using System;
namespace PurpleBuzz.Models
{
	public class Package: BaseEntity
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string BackgroundColor { get; set; }
        public string IconColor { get; set; }
        public string TextColor { get; set; }
		public string CardHeight { get; set; }
		public string ButtonOutline { get; set; }
		public ICollection<Offer> Offers { get; set; }
	}
}