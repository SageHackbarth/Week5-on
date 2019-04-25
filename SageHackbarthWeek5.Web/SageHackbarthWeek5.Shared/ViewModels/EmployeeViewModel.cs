using System;

namespace SageHackbarthWeek5.Shared.ViewModels
{
	public class EmployeeViewModel
	{
        public Guid EmployeeId { get; set; }
		public string EmployeeName { get; set; }
		public string Role { get; set; }
		public string Email { get; set; }
        public DateTime DOB { get; set; }
	}
}
