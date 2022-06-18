using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagement.Web.Controllers
{
   public class EmployeesController : Controller
   {
      private readonly UserManager<Employee> _userManager;
      private readonly IMapper _mapper;
      private readonly ILeaveAllocationRepository _leaveAllocationRepository;
      private readonly ILeaveTypeRepository _leaveTypeRepository;

      public EmployeesController(UserManager<Employee> userManager,
                                 IMapper mapper,
                                 ILeaveAllocationRepository leaveAllocationRepository,
                                 ILeaveTypeRepository leaveTypeRepository)
      {
         _userManager = userManager;
         _mapper = mapper;
         _leaveAllocationRepository = leaveAllocationRepository;
         _leaveTypeRepository = leaveTypeRepository;
      }
      // GET: EmployeesController
      public async Task<IActionResult> Index()
      {
         var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
         var model = _mapper.Map<List<EmployeeListVM>>(employees);
         return View(model);
      }

      // GET: EmployeesController/ViewAllocations/EmployeeId
      public async Task<IActionResult> ViewAllocations(string id)
      {

         var model = await _leaveAllocationRepository.GetEmployeeAllocations(id);
         return View(model);
      }

     

      // POST: EmployeesController/Create
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Create(IFormCollection collection)
      {
         try
         {
            return RedirectToAction(nameof(Index));
         }
         catch
         {
            return View();
         }
      }

      // GET: EmployeesController/EditAllocation/id
      public async Task<ActionResult> EditAllocation(int id)
      {
         var model = await _leaveAllocationRepository.GetEmployeeAllocations(id);
         if (model is null)
            return NotFound();

         return View(model);
      }

      // POST: EmployeesController/EditAllocation/5
      [HttpPost]
      [ValidateAntiForgeryToken]
      public async Task<ActionResult> EditAllocation(LeaveAllocationEditVM model ,int id)
      {
         try
         {
            if (ModelState.IsValid)
            {
               if (await _leaveAllocationRepository.UpdateEmployeeAllocation(model))
               {
                        return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });
                        //return RedirectToAction(nameof(ViewAllocations));
               }
            }
         }
         catch (Exception)
         {
            ModelState.AddModelError(string.Empty, "An Error Has Occured.Please Try AGAIN LATER");
         }
         model.Employee = _mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(model.EmployeeId));
         model.LeaveType = _mapper.Map<LeaveTypeVM>(await _leaveTypeRepository.GetAsync(model.LeaveTypeId));
         return View(model);
      }
   }
}
