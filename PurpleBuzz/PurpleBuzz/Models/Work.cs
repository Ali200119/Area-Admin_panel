﻿using System;
namespace PurpleBuzz.Models
{
	public class Work: BaseEntity
	{
		public string Description { get; set; }
		public bool IsRecent { get; set; }
		public ICollection<WorkImage> WorkImages { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}
}