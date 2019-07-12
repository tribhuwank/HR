using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CloudHR.Data;
using CloudHR.Helper;
using CloudHR.ViewsModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace CloudHR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly DbHelper _dbHelper;
        private readonly ILogger _logger;
        private readonly ApplicationDbContext _context;
        public AccountController(ILogger<AccountController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
            _dbHelper = new DbHelper(_context);
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> AuthenticateAsync([FromBody]LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ErrorMessage = "Enter all the required fields in corrent format.";
                return BadRequest(new { message = "Username or password is incorrect" });
            }
            var personInfo = await _dbHelper.GetUserAsync(model.Username, model.Password);
            personInfo.Role = await _dbHelper.GetRoleById(personInfo.RoleId);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("My Secret Key123");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, personInfo.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            // return basic user info (without password) and token to store client side
            return Ok(new
            {
                data = (id:personInfo.Id,
                   username: personInfo.Username,
                   roleId: personInfo.RoleId,
                   avatar: string.Empty,
                   Token: tokenString
               ),                
                Code=200,
                Msg= "Request success"               

            });

        }

        [Authorize]
        [HttpGet("getUsers")]
        public IActionResult GetUsers(int? page = 1, int? pageSize = 5)
        {
            var users = _dbHelper.GetPagedUser((int)page, (int)pageSize).ToVM(_dbHelper);            
            return Ok(new
            {
                Result= users,
                Code = 200,
                Msg = "Request success"
            });
        }
        [Authorize]
        [HttpGet("getPagedRoles")]
        public IActionResult GetPagedRoles(int? page = 1, int? pageSize = 5)
        {
            var roles = _dbHelper.GetPagedRoles((int)page, (int)pageSize).ToVM();
            return Ok(new
            {
                Result= roles,
                Code = 200,
                Msg = "Request success"
            });
        }

        [HttpGet("getRoles")]
        public IActionResult GetRoles()
        {
            var roles = _dbHelper.GetRolesAsync().Result.ToVM();
            return Ok(new
            {
                Result = roles,
                Code = 200,
                Msg = "Request success"
            });
        }

        [Authorize]
        [HttpPost("addRole")]
        public async Task<IActionResult> AddRoleAsync([FromBody]RoleViewModel roleModel)
        {
           if (roleModel != null && !string.IsNullOrEmpty(roleModel.Name))
            {
                try
                {
                    int result = await _dbHelper.AddRole(roleModel);
                    if(result ==-1) return BadRequest();
                    return Ok(new
                    {
                        result,
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
        [HttpPost("editRole")]
        public async Task<IActionResult> EditRoleAsync([FromQuery]RoleViewModel roleModel)
        {
            if (roleModel != null && roleModel.Id!=null && roleModel.Id > 0 && !string.IsNullOrEmpty(roleModel.Name))
            {
                int result = await _dbHelper.EditRole(roleModel.ToM());
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
        [HttpPost("deleteRole")]
        public async Task<IActionResult> DeleteRoleAsync([FromBody]RoleViewModel roleModel)
        {
            if (roleModel != null && roleModel.Id != null && roleModel.Id > 0 && !string.IsNullOrEmpty(roleModel.Name))
            {
                int result = await _dbHelper.DeleteRole(roleModel.ToM());
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
        [HttpPost("addUser")]
        public async Task<IActionResult> AddUserAsync([FromBody]UserViewModel userModel)
        {
            if (userModel != null && !string.IsNullOrEmpty(userModel.Name) && !string.IsNullOrEmpty(userModel.Username) && !string.IsNullOrEmpty(userModel.Password))
            {
                try
                {
                    int res = await _dbHelper.AddUser(userModel);
                    if (res == -1) return BadRequest();
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
        [HttpPost("editUser")]
        public async Task<IActionResult> EditUserAsync([FromBody]UserViewModel userModel)
        {
            if (userModel != null && !string.IsNullOrEmpty(userModel.Name) && !string.IsNullOrEmpty(userModel.Username) && !string.IsNullOrEmpty(userModel.Password))
            {
                int res = await _dbHelper.EditUser(userModel);
                if (res == -1) return BadRequest();
                return Ok(new
                {
                    res,
                    Code = 200,
                    Msg = "Request success"
                });
            }
            return BadRequest();
        }

        [HttpPost("deleteUser")]
        public async Task<IActionResult> DeleteUserAsync([FromBody]UserViewModel userModel)
        {
            if (userModel != null && !string.IsNullOrEmpty(userModel.Name) && !string.IsNullOrEmpty(userModel.Username) && !string.IsNullOrEmpty(userModel.Password))
            {
                int result = await _dbHelper.DeleteUser(userModel.ToM());
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

        [HttpPost("posts")]
        public IActionResult Posts()
        {
            return Ok();
        }

    }
}