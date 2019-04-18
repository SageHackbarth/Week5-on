using System;

namespace SageHackbarthWeek5.Web.Models
{
	public class EmployeeUpdateModel
	{
		public Guid EmployeeId { get; set; }
		public string EmployeeName { get; set; }
		public string Email { get; set; }
		public string Role { get; set; }
	}
}