using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Categories")]
	public class Categories
	 {
		[Key]
		public int CategoryID { get; set; }
		[MaxLength(15)]
		[Required]
		public string CategoryName { get; set; }
		[MaxLength(1073741823)]
		public string? Description { get; set; }
		[MaxLength(2147483647)]
		public byte[]? Picture { get; set; }
	 }
}
