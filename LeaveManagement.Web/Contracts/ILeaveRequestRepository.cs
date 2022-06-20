using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts;
public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
   Task CreateLeaveRequest(LeaveRequestCreateVM model);
   Task<EmployeeLeaveRequestVM> GetMyLeaveDetails();
   Task<List<LeaveRequest>> GetAllAsync(string employeeId);
   Task ChangeApprovalStatus(int leaveRequestedId, bool approved);
   Task <AdminLeaveRequestVM> GetAdminLeaveRequestList();
   
}
