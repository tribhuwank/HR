using CloudHR.Models;
using CloudHR.ViewsModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace CloudHR.Helper
{
    public partial class DbHelper
    {
        public async Task<User> GetUserByPersonId(int personId)
        {
            return await _context.Users.Where(c => c.PersonId == personId).SingleOrDefaultAsync();
        }
        public async Task<IList<DocumentRecord>> GetDocumentRecordsByRecordId(int recordId)
        {
            return await _context.DocumentRecords.Where(c => c.RecordId == recordId).ToListAsync();
        }

        public async Task<IList<EmployeeDependent>> GetEmployeeDependentsByEmployeeId(int employeeId)
        {
            return await _context.EmployeeDependents.Where(c=>c.EmployeeId == employeeId).ToListAsync();
        }

        public async Task<Person> GetPersonByIdAysc(int? personId)
        {
            if (personId == null) return null;
            return await _context.Persons.Where(c => c.Id == personId).FirstOrDefaultAsync();
        }
        public async Task<IList<Person>> GetPerson()
        {
            return await _context.Persons.ToListAsync();
        }
        public async Task<IList<Employee>> GetEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }
        public PagedResult<Employee> GetPagedEmployees(int page, int pageSize)
        {
            return _context.Employees.GetPaged(page, pageSize);

        }
        public async Task<EmployeeJob> GetEmployeeJobById(int? id)
        {
            if (id == null) return null;
           return await _context.EmployeeJobs.Where(c => c.Id == id).SingleOrDefaultAsync();
        }

        public async Task<Employee> GetEmployeeById(int? id)
        {
            if (id == null) return null;
            return await _context.Employees.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
        public async Task<Employee> GetEmployeeByPersonId(int? personId)
        {
            if (personId == null) return null;
            return await _context.Employees.Where(c => c.PersonId == personId).SingleOrDefaultAsync();
        }
        public async Task<IList<Employee>> GetEmployeeByManagerIdAysnc(int? managerId)
        {
            if (managerId == null) return null;
            return await _context.Employees.Where(c => c.ManagerId == managerId).ToListAsync();
        }

        public async Task<Person> AddPersonAsync(Person model)
        {
            try
            {
                await _context.Persons.AddAsync(model);
                await _context.SaveChangesAsync();
                return model;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<int> AddEmployeeAync(Employee model)
        {
            try
            {
                await _context.Employees.AddAsync(model);
                return await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }


        }

        public async Task<int> RegisterEmployeeAsync(EmployeeRegViewModel viemodel)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {

                    var personModel = viemodel.EmployeeViewModel.Person.ToM(this);
                    var person = await _context.Persons.AddAsync(personModel);
                    await _context.SaveChangesAsync();
                    var employeeJobModel = viemodel.EmployeeViewModel.EmployeeJob.ToM(this);
                    var empJob = await _context.EmployeeJobs.AddAsync(employeeJobModel);
                    await _context.SaveChangesAsync();
                    var empModel = viemodel.EmployeeViewModel.ToM(this);
                    empModel.PersonId= personModel.Id;
                    empModel.EmployeeJobId = employeeJobModel.Id;
                    var employee=await _context.Employees.AddAsync(empModel);
                    await _context.SaveChangesAsync();
                    if (viemodel.UserViewModel != null && !string.IsNullOrEmpty(viemodel.UserViewModel.Username))
                    {
                        viemodel.UserViewModel.RoleId = 2;
                        viemodel.UserViewModel.PersonId = personModel.Id;
                        var user = await _context.Users.AddAsync(viemodel.UserViewModel.ToM());
                    }
                    var res=await _context.SaveChangesAsync();
                    scope.Complete();
                    return res;
                }
                catch (Exception ex)
                {                    
                    throw ex;
                }
            }

        }

        public async Task<int> EditEmployeeAsync(EmployeeRegViewModel viemodel, DbHelper _dbHelper)
        {
            try
            {

                var personModel = viemodel.EmployeeViewModel.Person.ToM(_dbHelper);
                var updatePerson = _context.Persons.Update(personModel);

                var empModel = viemodel.EmployeeViewModel.ToM(_dbHelper);
                var updateEmployee = _context.Employees.Update(empModel);

                if (viemodel.UserViewModel != null && !string.IsNullOrEmpty(viemodel.UserViewModel.Username))
                {
                    viemodel.UserViewModel.RoleId = 2;
                    viemodel.UserViewModel.PersonId = updatePerson.Entity.Id;
                    var user = await _context.Users.AddAsync(viemodel.UserViewModel.ToM());
                }

                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<int> DeleteEmployeeAsync(Employee modle)
        {
            try
            {
                var user = _context.Users.Remove(_context.Users.Where(c => c.PersonId == modle.Person.Id).SingleOrDefaultAsync().Result);
                var person = _context.Persons.Remove(modle.Person);
                var employee = _context.Employees.Remove(_context.Employees.Where(c => c.Id == modle.Id).SingleOrDefaultAsync().Result);
                return await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public async Task<IList<Leave>> GetLeavesAsync()
        {
            return await _context.Leaves.ToListAsync();
        }
        public PagedResult<Leave> GetPagedLeaves(int page, int pageSize)
        {
            return _context.Leaves.GetPaged(page, pageSize);
        }
        public PagedResult<Leave> GetPagedLeavesByEmployeeId(int page, int pageSize,int? EmployeeId)
        {
            return _context.Leaves.Where(c=>c.EmployeeId==EmployeeId).GetPaged(page, pageSize);
        }
        public async Task<Approver> GetApproveRejectStatus(int? historyId)
        {
            return await _context.Approvers.Where(c => c.ApproveHistoryId == historyId).SingleOrDefaultAsync();
        }
        public async Task<IList<Approver>> GetApproverByHistoryId(int? historyId)
        {
            return await _context.Approvers.Where(c => c.ApproveHistoryId == historyId).ToListAsync();
        }
        public async Task<IList<CarbonCopyer>> GetCarbonCopyerByHistoryId(int? historyId)
        {
            return await _context.CarbonCopyers.Where(c => c.HistoryId == historyId).ToListAsync();
        }
    }
}
