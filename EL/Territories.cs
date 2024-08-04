using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Territories")]
	public class Territories
	 {
		[Key]
		[MaxLength(20)]
		public string TerritoryID { get; set; }
		[MaxLength(50)]
		[Required]
		public string TerritoryDescription { get; set; }
		[Required]
		public int RegionID { get; set; }
	 }
}
