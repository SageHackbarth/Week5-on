using System;

namespace SageHackbarthWeek5.Web.Models
{
    public class UpdateEmployeeModel
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}