using System;
using System.Threading.Tasks;
using CloudHR.Data;
using CloudHR.Helper;
using CloudHR.ViewsModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CloudHR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DbHelper _dbHelper;
        private readonly ILogger _logger;
        private readonly ApplicationDbContext _context;
        public EmployeeController(ILogger<EmployeeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
            _dbHelper = new DbHelper(_context);
        }

        [Authorize]
        [HttpGet("getEmployees")]
        public IActionResult GetEmployees(int? page = 1, int? pageSize = 5)
        {
            var employees = _dbHelper.GetPagedEmployees((int)page, (int)pageSize).ToVM(_dbHelper);
            return Ok(new
            {
                Result= employees,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getUserByPersonId")]
        public IActionResult GetEmployeeDependents(int personId)
        {
            var user = _dbHelper.GetUserByPersonId(personId);
            return Ok(new
            {
                user.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getDependentsByEmployeeId")]
        public IActionResult GetDependentsByEmployeeId(int employeeId)
        {
            var employeeDependents = _dbHelper.GetEmployeeDependentsByEmployeeId(employeeId);
            return Ok(new
            {
                employeeDependents.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getDocumentRecords")]
        public IActionResult GetDocumentRecords(int recordId)
        {
            var documentRecord = _dbHelper.GetDocumentRecordsByRecordId(recordId);
            return Ok(new
            {
                documentRecord.Result,
                Code = 200,
                Msg = "Request success"
            });
        }

        [Authorize]
        [HttpGet("getPersons")]
        public IActionResult GetPersons()
        {
            var employees = _dbHelper.GetPerson();
            return Ok(new
            {
                employees.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpPost("addEmployee")]
        public async Task<IActionResult> AddEmployeeAsync([FromBody]EmployeeRegViewModel EmployeeViewModel)
        {
            if (EmployeeViewModel != null) {                
                try
                {                  
                    var res = await _dbHelper.RegisterEmployeeAsync(EmployeeViewModel);
                    if (res <=0 ) return BadRequest();                    
                    return Ok(new
                    {
                        res,
                        Code = 200,
                        Msg = "Request success"
                    });
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
            return BadRequest();
        }

        [HttpPost("deleteEmployee")]
        public async Task<IActionResult> DeleteEmployeeAsync([FromBody]EmployeeViewModel employeeVModel)
        {
            if (employeeVModel != null && employeeVModel.Id != null && employeeVModel.Id > 0)
            {
                int result = await _dbHelper.DeleteEmployeeAsync(employeeVModel.ToM(_dbHelper));
                if (result == -1) return BadRequest();
                return Ok(new
                {
                    result,
                    Code = 200,
                    Msg = "Request success"
                });
            }
            return BadRequest();
        }

        [Authorize]
        [HttpPost("editEmployee")]
        public async Task<IActionResult> EditEmployeeAsync([FromBody]EmployeeRegViewModel empRegModel)
        {
            if (empRegModel != null)
            {
                try
                {
                    var res = await _dbHelper.EditEmployeeAsync(empRegModel, _dbHelper);
                    if (res <= 0) return BadRequest();
                    return Ok(new
                    {
                        res,
                        Code = 200,
                        Msg = "Request success"
                    });
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
            return BadRequest();
        }

        [Authorize]
        [HttpGet("getLeaves")]
        public IActionResult GetLeaves(int? page = 1, int? pageSize = 5)
        {
            var leaves = _dbHelper.GetPagedLeaves((int)page, (int)pageSize).ToVM(_dbHelper);
            return Ok(new
            {
                Result = leaves,
                Code = 200,
                Msg = "Request success"
            });
        }

        
    }
}