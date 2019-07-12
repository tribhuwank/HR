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
        public async Task<bool> IsUsernameExists(string username)
        {
            return (await _context.Users.Where(x => x.Username == username).FirstOrDefaultAsync()) != null;
        }

        public async Task<UserViewModel> GetUserAsync(string username, string password)
        {
            return (await _context.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefaultAsync()).ToVM(this);
        }

        public  PagedResult<User> GetPagedUser(int page , int pageSize )
        {
            return _context.Users.GetPaged(page, pageSize);      
            
        }
        public PagedResult<Role> GetPagedRoles(int page, int pageSize)
        {
            return _context.Roles.GetPaged(page, pageSize);

        }
        public async Task<List<Role>> GetRolesAsync()
        {
            return await _context.Roles.ToListAsync();
        }
        public async Task<int> AddRole(RoleViewModel rolevModel)
        {
            try
            {
                var role = rolevModel.ToM();
                await _context.Roles.AddAsync(role);
              return  await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }         
            
          
        }
        public async Task<int> EditRole(Role role)
        {
            try
            {
                var data = await _context.Roles.FindAsync(role.Id);
                if (data != null)
                {
                    data.Name = role.Name;
                    _context.Roles.Update(data);
                    return await _context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                return -1;
                throw;
            }
           
            return -1;

        }
        public async Task<int> DeleteRole(Role role)
        {

            var data = await _context.Roles.FindAsync(role.Id);
            if (data != null)
            {                
                _context.Roles.Remove(data);
                return await _context.SaveChangesAsync();
            }
            return -1;

        }
        public async Task<int> AddUser(UserViewModel user)
        {
            try
            {
                await _context.Users.AddAsync(user.ToM());
                return await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
           
                
        }
        public async Task<int> EditUser(UserViewModel user)
        {

            var data = await _context.Users.FindAsync(user.Id);
            if (data != null)
            {
                data.Name = user.Name;
                data.Username = user.Username;
                data.RoleId = user.RoleId;
                data.Password = user.Password;
                _context.Users.Update(data);
               return await _context.SaveChangesAsync();
            }
            return -1;

        }
        public async Task<int> DeleteUser(User user)
        {
            var data = await _context.Users.FindAsync(user.Id);
            if (data != null)
            {
                _context.Users.Remove(data);
                return await _context.SaveChangesAsync();
            }
            return -1;

        }        
       
        public async Task<Role> GetRoleAsync(int roleId)
        {
            return (await _context.Roles.Where(x => x.Id == roleId).FirstOrDefaultAsync());
        }

        public async Task<bool> ChangePasswordAsync(int userId, string password)
        {
            try
            {
                var obj = await _context.Users.Where(x => x.Id == userId).FirstOrDefaultAsync();
                if (obj == null) return false;

                obj.Password = password;

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
