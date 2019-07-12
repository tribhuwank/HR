using CloudHR.Models;
using CloudHR.ViewsModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudHR.Helper
{
    public partial class DbHelper
    {
        public async Task<List<UserViewModel>> GetOperators()
        {
            return (await _context.Users.AsNoTracking().Where(x => x.RoleId == 2).ToListAsync()).Select(x => x.ToVM(this)).ToList();
        }

        public async Task<UserViewModel> GetOperatorById(int id)
        {
            return (await _context.Users.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id)).ToVM(this);
        }

        public async Task<bool> AddOperator(string name, string username, string password)
        {
            var objUser = new User
            {
                Name = name,
                Username = username,
                Password = password,
                RoleId = 2
            };

            try
            {
                await _context.Users.AddAsync(objUser);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
