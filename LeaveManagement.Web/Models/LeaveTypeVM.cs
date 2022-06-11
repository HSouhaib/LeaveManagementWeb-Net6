using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models;

public class LeaveTypeVM
{
   public int Id { get; set; }

   [Required]
   [Display(Name = "Leave Type")]
   public string Name { get; set; }

   [Display(Name=" Default Number Of Days")]
   [Range(1,24, ErrorMessage = "Please Enter a number between 1 and 24 ")]
   [Required]
   public int DefaultDays { get; set; }
}
