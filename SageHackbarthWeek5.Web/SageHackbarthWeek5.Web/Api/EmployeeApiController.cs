using System.Collections.Generic;
using SageHackbarthWeek5.Shared.Orchestrators;
using System.Web.Http;
using SageHackbarthWeek5.Shared.ViewModels;

namespace SageHackbarthWeek5.Web.Api
{
	[Route("api/v1/employees")]
	public class EmployeeApiController : ApiController
	{
		private readonly EmployeeOrchestrator _employeeOrchestrator;

		public EmployeeApiController()
		{
			_employeeOrchestrator = new EmployeeOrchestrator();
		}

		[HttpGet]
		public List<EmployeeViewModel> GetProjectMembers()
		{
			var employees = _employeeOrchestrator.GetAllEmployees();

			return employees;
		}
	}
}
