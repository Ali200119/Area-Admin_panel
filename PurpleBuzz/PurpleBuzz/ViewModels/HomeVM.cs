using System;
using PurpleBuzz.Models;

namespace PurpleBuzz.ViewModels
{
	public class HomeVM
	{
		public Service Service { get; set; }
		public SliderBackground SliderBackground { get; set; }
		public IEnumerable<Slider> Sliders { get; set; }
		public IEnumerable<Category> Categories { get; set; }
		public IEnumerable<Work> Works { get; set; }
    }
}