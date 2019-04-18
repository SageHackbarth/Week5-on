using System;
using System.ComponentModel.DataAnnotations;

namespace SageHackbarthWeek5.Domain.Entities
{
	public class Employee
	{
		[Key]
		public Guid EmplyeeId { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Role { get; set; }
	}
}
