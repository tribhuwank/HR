using Microsoft.AspNetCore.Http;

namespace CloudHR.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserRepository(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string LogCurrentUser()
        {           
            var currentUsername = !string.IsNullOrEmpty(_httpContextAccessor.HttpContext.User?.Identity?.Name)
                ? _httpContextAccessor.HttpContext.User.Identity.Name
                : "Anonymous";
            return currentUsername;
        }
    }
}
