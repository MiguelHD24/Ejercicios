using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EL
{
	[Table("Employees")]
	public class Employees
	 {
		[Key]
		public int EmployeeID { get; set; }
		[MaxLength(20)]
		[Required]
		public string LastName { get; set; }
		[MaxLength(10)]
		[Required]
		public string FirstName { get; set; }
		[MaxLength(30)]
		public string? Title { get; set; }
		[MaxLength(25)]
		public string? TitleOfCourtesy { get; set; }
		public DateTime? BirthDate { get; set; }
		public DateTime? HireDate { get; set; }
		[MaxLength(60)]
		public string? Address { get; set; }
		[MaxLength(15)]
		public string? City { get; set; }
		[MaxLength(15)]
		public string? Region { get; set; }
		[MaxLength(10)]
		public string? PostalCode { get; set; }
		[MaxLength(15)]
		public string? Country { get; set; }
		[MaxLength(24)]
		public string? HomePhone { get; set; }
		[MaxLength(4)]
		public string? Extension { get; set; }
		[MaxLength(2147483647)]
		public byte[]? Photo { get; set; }
		[MaxLength(1073741823)]
		public string? Notes { get; set; }
		public int? ReportsTo { get; set; }
		[MaxLength(255)]
		public string? PhotoPath { get; set; }
	 }
}
