using CloudHR.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudHR.Helper
{
    public partial class DbHelper
    {
        public async Task<IList<LeaveType>> GetLeaveTypesAsync()
        {
            return await _context.LeaveTypes.ToListAsync();
        }
        public async Task<LeaveType> GetLeaveTypeByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.LeaveTypes.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
        public async Task<IList<DayType>> GetDayTypesAsync()
        {
            return await _context.DayTypes.ToListAsync();
        }
        public async Task<DayType> GetDayTypeByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.DayTypes.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
        public async Task<IList<AddressType>> GetAddressTypesAsync()
        {            
            return await _context.AddressTypes.ToListAsync();
        }
        public async Task<AddressType> GetAddressTypeByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.AddressTypes.Where(c=>c.Id==id).SingleOrDefaultAsync();
        }
        public async Task<Address> GetAddressByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.Addresses.Where(c => c.Id == id).SingleOrDefaultAsync();           
        }

        public async Task<IList<Cast>> GetCastsAsync()
        {
            return await _context.Casts.ToListAsync();
        }
        public async Task<Cast> GetCastByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.Casts.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
        public async Task<IList<Relation>> GetRelationsAsync()
        {
            return await _context.Relations.ToListAsync();
        }
        public async Task<Relation> GetRelationByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.Relations.Where(c => c.Id == id).SingleOrDefaultAsync();
        }

        public async Task<IList<MaritalStatus>> GetMaritalStatusesAsync()
        {
            return await _context.MaritalStatuses.ToListAsync();
        }
        public async Task<MaritalStatus> GetMaritalStatusByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.MaritalStatuses.Where(c => c.Id == id).SingleOrDefaultAsync();
        }


        public async Task<IList<Country>> GetCountriesAsync()
        {
            return await _context.Countrys.ToListAsync();
        }
        public async Task<Country> GetCountryByIdAsync(int?id)
        {
            if (id == null) return null;
            return await _context.Countrys.Where(c=>c.Id==id).SingleOrDefaultAsync();
        }
        public async Task<IList<Province>> GetProvincesAsync()
        {
            return await _context.Provinces.ToListAsync();
        }
        public async Task<Province> GetProvinceByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.Provinces.Where(c=>c.Id==id).SingleOrDefaultAsync();
        }
        public async Task<IList<District>> GetDistrictsAsync(int? provinceId)
        {
            if(provinceId!=null)
                return await _context.Districts.Where(c=>c.ProvinceId== provinceId).ToListAsync();
            return await _context.Districts.ToListAsync();
        }
        public async Task<District> GetDistrictByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.Districts.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
        public async Task<IList<MunVdc>> GetMunVdcsAsync(int? districtId)
        {
            return await _context.MunVdcs.Where(c=>c.DistrictId==districtId).ToListAsync();
        }
       
        public async Task<MunVdc> GetMunVdcByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.MunVdcs.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
        public async Task<IList<Gender>> GetGendersAsync()
        {
            return await _context.Genders.ToListAsync();
        }
        public async Task<Gender> GetGendersByIdAsync(int?id)
        {
            return await _context.Genders.Where(c=>c.Id==id).SingleOrDefaultAsync();
        }
        public async Task<IList<EduInstutionType>> GetEduInstutionTypesAsync()
        {
            return await _context.EduInstutionTypes.ToListAsync();
        }
        public async Task<EduInstutionType> GetEduInstutionTypeByIdAsync(int? id )
        {
            if (id == null) return null;
            return await _context.EduInstutionTypes.Where(c=>c.Id==id).SingleOrDefaultAsync();
        }
        public async Task<IList<Education>> GetEducationsAsync()
        {
            return await _context.Educations.ToListAsync();
        }
        public async Task<Education> GetEducationByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.Educations.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
        public async Task<IList<Office>> GetOfficesAsync()
        {
            return await _context.Offices.ToListAsync();
        }
        public async Task<Office> GetOfficeByIdAsync(int?id)
        {
            if (id == null) return null;
            return await _context.Offices.Where(c => c.Id == id).FirstOrDefaultAsync();
        }
        public async Task<IList<Department>> GetDepartmentByOfficeIdAsync(int? officeId)
        {
            if (officeId == null) return null;
            return await _context.Departments.Where(c=>c.OfficeId == officeId).ToListAsync();
        }
        public async Task<Department> GetDepartmentByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.Departments.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
        public async Task<OfficeDepartment> GetOfficeDepartmentByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.OfficeDepartments.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
        public async Task<IList<HealthStatus>> GetHealthStatusesAsyncs()
        {
            return await _context.HealthStatuses.ToListAsync();
        }
        public async Task<HealthStatus> GetHealthStatusByIdAsyncs(int? id)
        {
            if (id == null) return null;
            return await _context.HealthStatuses.Where(c=>c.Id==id).SingleOrDefaultAsync();
        }
        public async Task<IList<Holiday>> GetHolidaysAsync()
        {
            return await _context.Holidays.ToListAsync();
        }
        public async Task<IList<IdentityType>> GetIdentityTypesAsync()
        {
            return await _context.IdentityTypes.ToListAsync();
        }
        public async Task<IdentityType> GetIdentityTypeIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.IdentityTypes.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
        public async Task<IList<Litracy>> GetLitracysAsync()
        {
            return await _context.Litracys.ToListAsync();
        }
        public async Task<Litracy> GetLitracyByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.Litracys.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
        public async Task<IList<MaritalStatus>> GeMaritalStatusesAsync()
        {
            return await _context.MaritalStatuses.ToListAsync();
        }
        public async Task<IList<Occupation>> GetOccupationsAsync()
        {
            return await _context.Occupations.ToListAsync();
        }
        public async Task<IList<PostCategory>> GetPostCategorysAsync()
        {
            return await _context.PostCategorys.ToListAsync();
        }
        public async Task<PostCategory> GetPostCategoryByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.PostCategorys.Where(c=>c.Id==id).SingleOrDefaultAsync();
        }
        public async Task<IList<Post>> GetPostsByPostCategoryIdAsync(int? postCategoryId)
        {
            if (postCategoryId == null) return null;
            return await _context.Posts.Where(c=>c.PostCategoryId==postCategoryId).ToListAsync();
        }
        public async Task<IList<Level>> GetLevelsAsync()
        {
            return await _context.Levels.ToListAsync();
        }
        public async Task<Level> GetLevelByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.Levels.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
        public async Task<int> DeletePostAsync(Post post)
        {
             _context.Posts.Remove(post);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> AddPostAsync(Post post)
        {
            await _context.Posts.AddAsync(post);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> EditPostAsync(Post post)
        {
            var postModel=await _context.Posts.FindAsync(post.Id);
            postModel.LevelId = post.LevelId;
            postModel.Name = post.Name;
            postModel.PostCategoryId = post.PostCategoryId;
            postModel.ServiceId = post.ServiceId;
            postModel.Status = post.Status;
            postModel.WorkTypeId = post.WorkTypeId;
            postModel.Description = post.Description;
            postModel.DepartmentId = post.DepartmentId;
            _context.Update(postModel);
            return await _context.SaveChangesAsync();
        }
        public async Task<Post> GetPostsByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.Posts.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
        public async Task<IList<Post>> GetPostsByDepartmentIdAsync(int? departmentId)
        {
            return await _context.Posts.Where(c => c.DepartmentId == departmentId).ToListAsync();
        }
        public async Task<IList<PayGrade>> GetPayGradesAsync()
        {
            return await _context.PayGrades.ToListAsync();
        }
        public  PagedResult<PayGrade> GetPayGradesAsync(int page, int pageSize)
        {
            return  _context.PayGrades.GetPaged<PayGrade>(page, pageSize);
        }

        public async Task<IList<Level>> GetLevelByPayGradeId(int? PayGradeId)
        {
            if (PayGradeId == null) return null;
            return await _context.Levels.Where(c => c.PayGradeId == PayGradeId).ToListAsync();
        }

        public async Task<int> DeletePayGradeAsync(PayGrade payGrade)
        {
            _context.PayGrades.Remove(payGrade);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> AddPayGradeAsync(PayGrade payGrade)
        {
            await _context.PayGrades.AddAsync(payGrade);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> EditPayGradeAsync(PayGrade payGrade)
        {
            var payGradeModel = await _context.PayGrades.FindAsync(payGrade.Id);
            payGradeModel.MaxSalaryAmount = payGrade.MaxSalaryAmount;
            payGradeModel.Name = payGrade.Name;
            payGradeModel.MinSalaryAmount = payGrade.MinSalaryAmount;
            payGradeModel.NumberOfLevels = payGrade.NumberOfLevels;
            payGradeModel.Status = payGrade.Status;            
            _context.Update(payGradeModel);
            return await _context.SaveChangesAsync();
        }

        

        public async Task<int> DeleteLevelAsync(Level level)
        {
            _context.Levels.Remove(level);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> AddLevelAsync(Level level)
        {
            await _context.Levels.AddAsync(level);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> EditLevelAsync(Level level)
        {
            var levelModel = await _context.Levels.FindAsync(level.Id);
            levelModel.PayGradeId = level.PayGradeId;
            levelModel.Name = level.Name;
            levelModel.MaxGradeValue = level.MaxGradeValue;
            levelModel.GradePerMonth = level.GradePerMonth;
            levelModel.GradeUpgradationMonth = level.GradeUpgradationMonth;
            levelModel.GradeUpgradationRate = level.GradeUpgradationRate;
            levelModel.IsActive = level.IsActive;
            _context.Update(levelModel);
            return await _context.SaveChangesAsync();
        }

        public async Task<IList<Service>> GetServicesAsync()
        {
            return await _context.Services.ToListAsync();
        }
        public async Task<Service> GetServiceByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.Services.Where(c => c.Id == id).SingleOrDefaultAsync();
        }
        public async Task<IList<Skill>> GetSkillsAsync()
        {
            return await _context.Skills.ToListAsync();
        }
        public async Task<IList<WorkType>> GetWorkTypesAsync()
        {
            return await _context.WorkTypes.ToListAsync();
        }
        public async Task<WorkType> GetWorkTypeByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.WorkTypes.Where(c => c.Id == id).SingleOrDefaultAsync();
        }

        public async Task<IList<Religion>> GetReligionsAsync()
        {
            return await _context.Religions.ToListAsync();
        }
        public async Task<Religion> GetReligionByIdAsync(int? id)
        {
            if (id == null) return null;
            return await _context.Religions.Where(c=>c.Id==id).SingleOrDefaultAsync();
        }
        public async Task<IList<OfficeDepartment>> GetOfficeDepartmentsAsync(int? officeId)
        {
            if (officeId == null) return null;
            return await _context.OfficeDepartments.Where(c=>c.OfficeId==officeId).ToListAsync();
        }
    }
}
