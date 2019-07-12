using CloudHR.Data;
using CloudHR.Helper;
using CloudHR.ViewsModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CloudHR.Controllers
{
    [Route("api/[controller]")]
    public class SettingsController : Controller
    {
        private readonly DbHelper _dbHelper;
        private readonly ILogger _logger;
        private readonly ApplicationDbContext _context;
        public SettingsController(ILogger<AccountController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
            _dbHelper = new DbHelper(_context);
        }
        [Authorize]
        [HttpGet]
        public IActionResult GetAddressTypes()
        {
            //var AddressTypes = await _dbHelper.(model.Username, model.Password);
            return View();
        }
        [Authorize]
        [HttpGet("getHealthStatuses")]
        public IActionResult GetHealthStatusesAsync()
        {
            var allGenders = _dbHelper.GetHealthStatusesAsyncs();
            return Ok(new
            {
                allGenders.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getGenders")]
        public IActionResult GetGendersAsync()
        {
            var allGenders = _dbHelper.GetGendersAsync();
            return Ok(new
            {
                allGenders.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getMaritalStatuses")]
        public IActionResult GetMaritalStatusesAsync()
        {
            var allGenders = _dbHelper.GetMaritalStatusesAsync();
            return Ok(new
            {
                allGenders.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getReligions")]
        public IActionResult GetReligionsAsync()
        {
            var allGenders = _dbHelper.GetReligionsAsync();
            return Ok(new
            {
                allGenders.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getCasts")]
        public IActionResult GetCastsAsync()
        {
            var allGenders = _dbHelper.GetCastsAsync();
            return Ok(new
            {
                allGenders.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getLitracys")]
        public IActionResult GetgetLitracysAsync()
        {
            var allGenders = _dbHelper.GetLitracysAsync();
            return Ok(new
            {
                allGenders.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getDepartments")]
        public IActionResult GetDepartmentsAsync(int? officeId=1)
        {
            var departments = _dbHelper.GetDepartmentByOfficeIdAsync(officeId);
            return Ok(new
            {
                departments.Result,
                Code = 200,
                Msg = "Request success"
            });
        }


        [Authorize]
        [HttpGet("getCountrys")]
        public IActionResult GetCountrysAsync()
        {
            var countries = _dbHelper.GetCountriesAsync();
            return Ok(new
            {
                countries.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getProvinces")]
        public IActionResult GetProvincesAsync()
        {
            var provinces = _dbHelper.GetProvincesAsync();
            return Ok(new
            {
                provinces.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getDistricts")]
        public IActionResult GetDistrictsAsync(int? provinceId )
        {
            
            var districts = _dbHelper.GetDistrictsAsync(provinceId);
            return Ok(new
            {
                districts.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getMunVdcs")]
        public IActionResult GetMunVdcsAsync(int districtId)
        {
            var munVdcs = _dbHelper.GetMunVdcsAsync(districtId);
            return Ok(new
            {
                munVdcs.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getWard")]
        public IActionResult GetWardAsync(int munVdcId)
        {
            var wardCount = _dbHelper.GetMunVdcByIdAsync(munVdcId);
            var lsCount = new List<object>();

            for (int i = 1; i <= wardCount.Result.WardCount; i++)
            {
                var v = new { Value = i, Label = i.ToString() };
                lsCount.Add(v);
            }
          
            return Ok(new
            {
                Result=lsCount,
                Code = 200,
                Msg = "Request success"
            });
        }
       


        [Authorize]
        [HttpGet("getLeaveTypes")]
        public IActionResult GetLeaveTypesAsync()
        {
            var districts = _dbHelper.GetLeaveTypesAsync();
            return Ok(new
            {
                districts.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getDayTypes")]
        public IActionResult GetDayTypesAsync()
        {
            var dayTypes = _dbHelper.GetDayTypesAsync();
            return Ok(new
            {
                dayTypes.Result,
                Code = 200,
                Msg = "Request success"
            });
        }

        [Authorize]
        [HttpGet("getPostCategorys")]
        public IActionResult GetPostCategorysAsync()
        {
            var postCategorys = _dbHelper.GetPostCategorysAsync();
            return Ok(new
            {
                postCategorys.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getPostServices")]
        public IActionResult GetPostServicesAsync()
        {
            var services = _dbHelper.GetServicesAsync();
            return Ok(new
            {
                services.Result,
                Code = 200,
                Msg = "Request success"
            });
        }

        [Authorize]
        [HttpGet("getPostLevels")]
        public IActionResult GetPostLevelsAsync()
        {
            var levels = _dbHelper.GetLevelsAsync();
            return Ok(new
            {
                levels.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getWorkTypes")]
        public IActionResult GetWorkTypesAsync()
        {
            var workTypes = _dbHelper.GetWorkTypesAsync();
            return Ok(new
            {
                workTypes.Result,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpPost("addPost")]
        public async Task<IActionResult> AddPostAsync([FromBody]PostViewModel postmodel)
        {
            if (postmodel != null)
            {
                try
                {
                    var res = await _dbHelper.AddPostAsync(postmodel.ToM(_dbHelper));
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

        [HttpPost("deletePost")]
        public async Task<IActionResult> DeletePostAsync([FromBody]PostViewModel postModel)
        {
            if (postModel != null && postModel.Id != null && postModel.Id > 0)
            {
                int result = await _dbHelper.DeletePostAsync(postModel.ToM(_dbHelper));
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
        [HttpPost("editPost")]
        public async Task<IActionResult> EditPostAsync([FromBody]PostViewModel postModel)
        {
            if (postModel != null)
            {
                try
                {
                    var res = await _dbHelper.EditPostAsync(postModel.ToM(_dbHelper));
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
        [HttpGet("getPosts")]
        public IActionResult GetPosts(int? department)
        {
            var posts = _dbHelper.GetPostsByDepartmentIdAsync(department).Result.ToVM(_dbHelper);
            return Ok(new
            {
                Result = posts,
                Code = 200,
                Msg = "Request success"
            });
        }

        [HttpPost("deletePost")]
        public async Task<IActionResult> DeletePostAsync([FromBody]PayGradeViewModel payGradeModel)
        {
            if (payGradeModel != null && payGradeModel.Id != null && payGradeModel.Id > 0)
            {
                int result = await _dbHelper.DeletePayGradeAsync(payGradeModel.ToM());
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
        [HttpPost("editPayGrade")]
        public async Task<IActionResult> EditvAsync([FromBody]PayGradeViewModel payGradeModel)
        {
            if (payGradeModel != null)
            {
                try
                {
                    var res = await _dbHelper.EditPayGradeAsync(payGradeModel.ToM());
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
        [HttpGet("getPayGrades")]
        public IActionResult GetPayGrades(int? page = 1, int? pageSize = 5)
        {
            var payGrades = _dbHelper.GetPayGradesAsync((int)page, (int)pageSize).ToVM();
            return Ok(new
            {
                Result = payGrades,
                Code = 200,
                Msg = "Request success"
            });
        }


    }
}