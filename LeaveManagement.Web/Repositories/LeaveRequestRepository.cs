using AutoMapper;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
   public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
   {
      private readonly ApplicationDbContext _context;
      private readonly IMapper _mapper;
      private readonly IHttpContextAccessor _httpContextAccessor;
      private readonly ILeaveAllocationRepository _leaveAllocationRepository;
      private readonly UserManager<Employee> _userManager;

      public LeaveRequestRepository(ApplicationDbContext context,
                                  IMapper mapper,
                                  IHttpContextAccessor httpContextAccessor,
                                  ILeaveAllocationRepository leaveAllocationRepository,
                                  UserManager<Employee> userManager) : base(context)
      {
         _context = context;
         _mapper = mapper;
         _httpContextAccessor = httpContextAccessor;
         _leaveAllocationRepository = leaveAllocationRepository;
         _userManager = userManager;
      }

      public Task ChangeApprovalStatus(int leaveRequestedId, bool approved)
      {
         throw new NotImplementedException();
      }

      public async Task CreateLeaveRequest(LeaveRequestCreateVM model)
      {
         var user = await _userManager.GetUserAsync(_httpContextAccessor?.HttpContext?.User);

         var leaveRequest = _mapper.Map<LeaveRequest>(model);
         leaveRequest.DateRequested = DateTime.Now;
         leaveRequest.RequestingEmployeeeId = user.Id;

         await AddAsync(leaveRequest);
      }

      public async Task<AdminLeaveRequestVM> GetAdminLeaveRequestList()
      {
         var leaveRequests = await _context.LeaveRequests.Include(q => q.LeaveType).ToListAsync();
         var model = new AdminLeaveRequestVM
         {
            TotalRequests = leaveRequests.Count,
            ApprovedRequests = leaveRequests.Count(q => q.Approved == true),
            PendingRequests = leaveRequests.Count(q => q.Approved == null),
            RejectedRequests = leaveRequests.Count(q => q.Approved == false),
            LeaveRequests = _mapper.Map<List<LeaveRequestVM>>(leaveRequests),
         };

         foreach (var leaveRequest in model.LeaveRequests)
         {
            leaveRequest.Employee =_mapper.Map<EmployeeListVM>(await _userManager.FindByIdAsync(leaveRequest.RequestingEmployeeId));
         }
         return model;
      }


      public async Task<List<LeaveRequest>> GetAllAsync(string employeeId)
      {
         return await _context.LeaveRequests.Where(q => q.RequestingEmployeeeId == employeeId).ToListAsync();
      }

      public async Task<EmployeeLeaveRequestVM> GetMyLeaveDetails()
      {
         var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);
         var allocations = (await _leaveAllocationRepository.GetEmployeeAllocations(user.Id)).LeaveAllocations;

         var requests = _mapper.Map<List<LeaveRequestVM>>(await GetAllAsync(user.Id));

         var model = new EmployeeLeaveRequestVM(allocations, requests);

         return model;

      }
   }
}

