using System.Collections.Generic;
using System.Threading.Tasks;
using SageHackbarthWeek5.Shared.ViewModels;

namespace SageHackbarthWeek5.Shared.Orchestrators.Interface
{
	public interface IEmployeeOrchestrator
	{
		List<EmployeeViewModel> GetAllEmployees();

        Task<int> CreateEmployee (EmployeeViewModel employee);
        Task<bool> UpdateEmployee(EmployeeViewModel employee);
        Task<EmployeeViewModel> SearchEmployee(string searchString);
    }
}
