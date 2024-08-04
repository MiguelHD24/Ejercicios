using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Region")]
	public class Region
	 {
		[Key]
		public int RegionID { get; set; }
		[MaxLength(50)]
		[Required]
		public string RegionDescription { get; set; }
	 }
}
