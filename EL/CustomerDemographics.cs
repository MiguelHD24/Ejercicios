using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("CustomerDemographics")]
	public class CustomerDemographics
	 {
		[Key]
		[MaxLength(10)]
		public string CustomerTypeID { get; set; }
		[MaxLength(1073741823)]
		public string? CustomerDesc { get; set; }
	 }
}
