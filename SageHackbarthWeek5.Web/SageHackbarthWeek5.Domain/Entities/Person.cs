using System;
using System.ComponentModel.DataAnnotations;

namespace SageHackbarthWeek5.Domain.Entities
{
	public class Person
	{
		[Key]
		public Guid PersonId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public DateTime DateCreated { get; set; }
	}
}
