using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Models
{
	public class RestaurantReview : IValidatableObject
	{
		public int Id { get; set; }

		[Range(1, 10)]
		public int Rating { get; set; }

		[Required(ErrorMessageResourceType = typeof(Resources.Models.RestaurantReview), ErrorMessageResourceName = "Required")]
		[StringLength(1024)]
		public string Body { get; set; }

		[Display(Name = "User Name")]
		[DisplayFormat(NullDisplayText = "anonymous")]
		[StringLength(1024)]
		public string ReviewerName { get; set; }
		public int RestaurantId { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (Rating < 2 && ReviewerName.ToLower().StartsWith("scott"))
			{
				yield return new ValidationResult("Sorry, Scott, you can't do this");
			}
		}
	}
}

