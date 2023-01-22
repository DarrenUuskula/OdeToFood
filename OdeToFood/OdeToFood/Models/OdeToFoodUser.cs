using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Models
{
	public class OdeToFoodUser : IdentityUser
	{
		[StringLength(1024)]
		public string FavoriteRestaurant { get; set; }
	}
}