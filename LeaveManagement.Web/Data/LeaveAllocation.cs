namespace LeaveManagement.Web.Data;

public class LeaveAllocation  : BaseEntity
{
   public LeaveType LeaveType { get; set; }
   public int LeaveTypeId { get; set; }

   public string EmployeeId { get; set; }
   public int NumbersOfDays { get; set; }

   public int Period { get; set; }

}
