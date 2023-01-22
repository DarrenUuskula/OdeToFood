using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace OdeToFood.Models
{
	public class Restaurant
	{
		public int Id { get; set; }
		[StringLength(60, MinimumLength = 1)]
		[Required]
		public string Name { get; set; }
		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string City { get; set; }
		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string Country { get; set; }
		public ICollection<RestaurantReview> Reviews { get; set; }
	}
}