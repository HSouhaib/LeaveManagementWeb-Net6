using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models;
public class LeaveAllocationVM
{
   [Required]
   public int Id { get; set; }

   [Display(Name ="Number Of Days")]
   [Range(1,50, ErrorMessage ="Invalid Number Entered")]
   [Required]
   public int NumbersOfDays { get; set; }
   [Required]
   [Display(Name = "Allocation Period")]
   public int Period { get; set; }
   public LeaveTypeVM? LeaveType { get; set; }

}