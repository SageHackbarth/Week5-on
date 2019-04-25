using SageHackbarthWeek5.Shared.ViewModels;

namespace SageHackbarthWeek5.Shared.Services.Interfaces
{
    public interface IDOBService
    {
        bool IsTodayYourBD(EmployeeViewModel employee);
    }
}
