using CloudHR.ViewsModel;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CloudHR.Helper
{
    public partial class DbHelper
    {
        public async Task<RoleViewModel> GetRoleById(int id)
        {
            return (await _context.Roles.SingleOrDefaultAsync(x => x.Id == id)).ToVM();
        }

       
    }
}
