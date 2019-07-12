using CloudHR.Models;
using CloudHR.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CloudHR.Helper
{

    public static class Conversion
    {
        public static PagedResult<T> GetPaged<T>(this IQueryable<T> query,int page, int pageSize) where T : class
        {
            var result = new PagedResult<T>();
            result.CurrentPage = page;
            result.PageSize = pageSize;
            result.RowCount = query.Count();
            var pageCount = (double)result.RowCount / pageSize;
            result.PageCount = (int)Math.Ceiling(pageCount);
            var skip = (page - 1) * pageSize;
            result.Results = query.Skip(skip).Take(pageSize).ToList();
            return result;
        }
        public static RoleViewModel ToVM(this Role obj)
        {
            if (obj == null) return null;
            return new RoleViewModel
            {
                Id = obj.Id,
                Name = obj.Name,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static Role ToM(this RoleViewModel obj)
        {
            if (obj == null) return null;            
            return new Role
            {
                Id = obj.Id ?? -1,
                Name = obj.Name,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static UserViewModel ToVM(this User obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new UserViewModel
            {
                Id = obj.Id,
                Name = obj.Name,
                Username = obj.Username,
                Password = "",
                RoleId = obj.RoleId,
                Role = dbHelper.GetRoleById(obj.RoleId).Result,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }       
        public static PagedResult<UserViewModel> ToVM(this PagedResult<User> obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new PagedResult<UserViewModel>
            {
                Results=obj.Results.Select(b => b.ToVM(dbHelper)).ToList(),
                CurrentPage=obj.CurrentPage,
                PageCount=obj.PageCount,
                PageSize=obj.PageSize,
                RowCount=obj.RowCount               
            };
        }
        public static PagedResult<RoleViewModel> ToVM(this PagedResult<Role> obj)
        {
            if (obj == null) return null;
            return new PagedResult<RoleViewModel>
            {
                Results = obj.Results.Select(b => b.ToVM()).ToList(),
                CurrentPage = obj.CurrentPage,
                PageCount = obj.PageCount,
                PageSize = obj.PageSize,
                RowCount = obj.RowCount
            };
        }
        public static IList<RoleViewModel> ToVM(this IList<Role> obj)
        {
            if (obj == null) return null;
            return obj.Select(c => c.ToVM()).ToList();            
        }
        public static User ToM(this UserViewModel obj)
        {
            if (obj == null) return null;
            if (obj.Id == null)
            {
                return new User
                {
                    Name = obj.Name,
                    Username= obj.Username,
                    Password=obj.Password,
                    RoleId=obj.RoleId,
                    PersonId=obj.PersonId,
                    UserCreated = obj.UserCreated,
                    UserModified = obj.UserModified,
                    DateCreated = obj.DateCreated,
                    DateModified = obj.DateModified
                };
            }
            return new User
            {
                Id = obj.Id ?? -1,
                Name = obj.Name,
                Username = obj.Username,
                Password = obj.Password,
                RoleId = obj.RoleId,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static HealthStatusViewModel ToVM(this HealthStatus obj)
        {
            if (obj == null) return null;
            return new HealthStatusViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static HealthStatus ToM(this HealthStatusViewModel obj)
        {
            if (obj == null) return null;
            return new HealthStatus
            {
                Id = obj.Id?? default(int),
                Name = obj.Name,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static GenderViewModel ToVM(this Gender obj)
        {
            if (obj == null) return null;
            return new GenderViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                UserCreated=obj.UserCreated,
                UserModified=obj.UserModified,
                DateCreated=obj.DateCreated,
                DateModified=obj.DateModified
            };
        }
        public static Gender ToM(this GenderViewModel obj)
        {
            if (obj == null) return null;
            return new Gender
            {
                Id = obj.Id??default(int),
                Name = obj.Name,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static EduInstutionTypeViewModel ToVM(this EduInstutionType obj)
        {
            if (obj == null) return null;
            return new EduInstutionTypeViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                UserCreated=obj.UserCreated,
                UserModified=obj.UserModified,
                DateCreated=obj.DateCreated,
                DateModified=obj.DateModified
            };
        }
        public static EduInstutionType ToM(this EduInstutionTypeViewModel obj)
        {
            if (obj == null) return null;
            return new EduInstutionType
            {
                Id = obj.Id??default(int),
                Name = obj.Name,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static EducationViewModel ToVM(this Education obj)
        {
            if (obj == null) return null;
            return new EducationViewModel
            {               
                Id=obj.Id,
                Name=obj.Name,
                UserCreated=obj.UserCreated,
                UserModified=obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
            };
        }
        public static Education ToM(this EducationViewModel obj)
        {
            if (obj == null) return null;
            return new Education
            {
                Id = obj.Id??default(int),
                Name = obj.Name,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
            };
        }
        public static OfficeDepartmentViewModel ToVM(this OfficeDepartment obj,DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new OfficeDepartmentViewModel
            {
                Id = obj.Id,
                DepartmentId=obj.DepartmentId,
                Department=dbHelper.GetDepartmentByIdAsync(obj.DepartmentId).Result.ToVM(dbHelper),
                OfficeId=obj.OfficeId,
                Office=dbHelper.GetOfficeByIdAsync(obj.OfficeId).Result.ToVM(dbHelper),
                Status=obj.Status,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified

            };
        }
        public static EmployeeJobViewModel ToVM(this EmployeeJob obj,DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new EmployeeJobViewModel
            {
                Id = obj.Id,
                OfficeDepartmentId=obj.OfficeDepartmentId,
                OfficeDepartment=dbHelper.GetOfficeDepartmentByIdAsync(obj.OfficeDepartmentId).Result.ToVM(dbHelper),
                HiringDate=obj.HiringDate,
                OpinionSuggestion=obj.OpinionSuggestion,
                PostId=obj.PostId,
                Post=dbHelper.GetPostsByIdAsync(obj.PostId).Result.ToVM(dbHelper),
                ProbationPeriodFrom=obj.ProbationPeriodFrom,
                ProbationPeriodTo=obj.ProbationPeriodTo,
                ProbationPermorfanceSummary=obj.ProbationPermorfanceSummary,
                SymbolNumber=obj.SymbolNumber,                
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static CastViewModel ToVM(this Cast obj)
        {
            if (obj == null) return null;
            return new CastViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                DateCreated=obj.DateCreated,
                DateModified=obj.DateModified,
                UserCreated=obj.UserCreated,
                UserModified=obj.UserModified
            };
        }
        public static Cast ToM(this CastViewModel obj)
        {
            if (obj == null) return null;
            return new Cast
            {
                Id = obj.Id??default(int),
                Name = obj.Name,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static AddressTypeViewModel ToVM(this AddressType obj)
        {
            if (obj == null) return null;
            return new AddressTypeViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static AddressType ToM(this AddressTypeViewModel obj)
        {
            if (obj == null) return null;
            return new AddressType
            {
                Id = obj.Id??default(int),
                Name = obj.Name,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static ProvinceViewModel ToVM(this Province obj)
        {
            if (obj == null) return null;
            return new ProvinceViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static Province ToM(this ProvinceViewModel obj)
        {
            if (obj == null) return null;
            return new Province
            {
                Id = obj.Id??default(int),
                Name = obj.Name,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static DistrictViewModel ToVM(this District obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new DistrictViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                ProvinceId=obj.ProvinceId,
                Province= dbHelper.GetProvinceByIdAsync(obj.ProvinceId).Result.ToVM(),
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static District ToM(this DistrictViewModel obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new District
            {
                Id = obj.Id??default(int),
                Name = obj.Name,
                ProvinceId = obj.ProvinceId,
                Province = dbHelper.GetProvinceByIdAsync(obj.ProvinceId).Result,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static LitracyViewModel ToVM(this Litracy obj)
        {
            if (obj == null) return null;
            return new LitracyViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static MunVdcViewModel ToVM(this MunVdc obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new MunVdcViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                DistrictId=obj.DistrictId,
                District= dbHelper.GetDistrictByIdAsync(obj.DistrictId).Result.ToVM(dbHelper),
                VdcMunType=obj.VdcMunType,
                WardCount=obj.WardCount,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static CountryViewModel ToVM(this Country obj)
        {
            if (obj == null) return null;
            return new CountryViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                Code=obj.Code,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static AddressViewModel ToVM(this Address obj,DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new AddressViewModel
            {
                Id=obj.Id,
                AddressLine1=obj.AddressLine1,
                AddressLine2=obj.AddressLine2,
                AddressTypeId=obj.AddressTypeId,
                AddressType= dbHelper.GetAddressTypeByIdAsync(obj.AddressTypeId).Result.ToVM(),
                CountryId=obj.CountryId,
                Country= dbHelper.GetCountryByIdAsync(obj.CountryId).Result.ToVM(),
                DistrictId=obj.DistrictId,
                District= dbHelper.GetDistrictByIdAsync(obj.DistrictId).Result.ToVM(dbHelper),
                ProvinceId=obj.ProvinceId,
                Province= dbHelper.GetProvinceByIdAsync(obj.ProvinceId).Result.ToVM(),
                MunVdcId = obj.MunVdcId,
                MunVdc = dbHelper.GetMunVdcByIdAsync(obj.MunVdcId).Result.ToVM(dbHelper),
                HouseNo =obj.HouseNo,
                PinCode=obj.PinCode,
                WardNo=obj.WardNo,                
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static IdentityTypeViewModel ToVM(this IdentityType obj)
        {
            if (obj == null) return null;
            return new IdentityTypeViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static MaritalStatusViewModel ToVM(this MaritalStatus obj)
        {
            if (obj == null) return null;
            return new MaritalStatusViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static RelationViewModel ToVM(this Relation obj)
        {
            if (obj == null) return null;
            return new RelationViewModel
            {
                Id = obj.Id,
                Name = obj.Name,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static ReligionViewModel ToVM(this Religion obj)
        {
            if (obj == null) return null;
            return new ReligionViewModel
            {
                Id = obj.Id,
                Name = obj.Name,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }               
        public static OfficeViewModel ToVM(this Office obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new OfficeViewModel
            {
                Id = obj.Id,
                Name = obj.Name,
                AddressId=obj.AddressId,
                Address= dbHelper.GetAddressByIdAsync(obj.AddressId).Result.ToVM(dbHelper),
                ContactNo1=obj.ContactNo1,
                ContactNo2=obj.ContactNo2,
                Description=obj.Description,
                Email=obj.Email,
                Fax=obj.Fax,
                Logo= "data:image/png;base64," + Convert.ToBase64String(obj.Logo),
                Website=obj.Website,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static DepartmentViewModel ToVM(this Department obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new DepartmentViewModel
            {
                Id = obj.Id,
                Name = obj.Name,
                Location = obj.Location,
                DeptNumber = obj.DeptNumber,
                OfficeId = obj.OfficeId,
                Office = dbHelper.GetOfficeByIdAsync(obj.OfficeId).Result.ToVM(dbHelper),
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static PersonViewModel ToVM(this Person obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new PersonViewModel()
            {
                Id = obj.Id,
                CastId = obj.CastId,
                FirstName = obj.FirstName,
                MiddleName = obj.MiddleName,
                LastName = obj.LastName,
                GenderId = obj.GenderId,
                Gender = dbHelper.GetGendersByIdAsync(obj.GenderId).Result.ToVM(),
                Cast = dbHelper.GetCastByIdAsync(obj.CastId).Result.ToVM(),
                DOB = obj.DOB,
                EduInstutionTypeId = obj.EduInstutionTypeId,
                EduInstutionType = dbHelper.GetEduInstutionTypeByIdAsync(obj.EduInstutionTypeId).Result.ToVM(),
                Email = obj.Email,
                HealthStatusId = obj.HealthStatusId,
                HealthStatus = dbHelper.GetHealthStatusByIdAsyncs(obj.HealthStatusId).Result.ToVM(),
                TemporaryAddressId = obj.TemporaryAddressId,
                TemporaryAddress = dbHelper.GetAddressByIdAsync(obj.TemporaryAddressId).Result.ToVM(dbHelper)??new AddressViewModel(),
                PermanentAddressId = obj.PermanentAddressId,
                PermanentAddress = dbHelper.GetAddressByIdAsync(obj.PermanentAddressId).Result.ToVM(dbHelper)?? new AddressViewModel(),
                IdentityTypeId = obj.IdentityTypeId,
                IdentityNumber = obj.IdentityNumber,
                IdentityIssuePlace = obj.IdentityIssuePlace,
                IdentityIssueData = obj.IdentityIssueData,
                IdentityType = dbHelper.GetIdentityTypeIdAsync(obj.IdentityTypeId).Result.ToVM(),
                Phone1 = obj.Phone1,
                Phone2 = obj.Phone2,
                LitracyId = obj.LitracyId,
                Litracy = dbHelper.GetLitracyByIdAsync(obj.LitracyId).Result.ToVM(),
                MaritalStatusId = obj.MaritalStatusId,
                MaritalStatus = dbHelper.GetMaritalStatusByIdAsync(obj.MaritalStatusId).Result.ToVM(),
                RelationId = obj.RelationId,
                Relation = dbHelper.GetRelationByIdAsync(obj.RelationId).Result.ToVM(),
                ReligionId = obj.ReligionId,
                Religion = dbHelper.GetReligionByIdAsync(obj.ReligionId).Result.ToVM(),
                Photo= "data:image/jpeg;base64," + Convert.ToBase64String(obj.Photo),
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static ServiceViewModel ToVM(this Service obj)
        {
            if (obj == null) return null;
            return new ServiceViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                Description=obj.Description,
                Status=obj.Status,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static Service ToM(this ServiceViewModel obj)
        {
            if (obj == null) return null;
            return new Service
            {
                Id = obj.Id??default(int),
                Name = obj.Name,
                Description = obj.Description,
                Status = obj.Status,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static PostCategoryViewModel ToVM(this PostCategory obj)
        {
            if (obj == null) return null;
            return new PostCategoryViewModel
            {
                Id = obj.Id,
                Name = obj.Name,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static PostCategory ToM(this PostCategoryViewModel obj)
        {
            if (obj == null) return null;
            return new PostCategory
            {
                Id = obj.Id??default(int),
                Name = obj.Name,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static WorkTypeViewModel ToVM(this WorkType obj)
        {
            if (obj == null) return null;
            return new WorkTypeViewModel
            {
                Id = obj.Id,
                Name = obj.Name,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };

        }
        public static WorkType ToM(this WorkTypeViewModel obj)
        {
            if (obj == null) return null;
            return new WorkType
            {
                Id = obj.Id??default(int),
                Name = obj.Name,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };

        }
        public static LevelViewModel ToVM(this Level obj)
        {
            if (obj == null) return null;
            return new LevelViewModel
            {
                Id = obj.Id,
                Name = obj.Name,
                GradePerMonth=obj.GradePerMonth,
                GradeUpgradationMonth=obj.GradeUpgradationMonth,
                GradeUpgradationRate=obj.GradeUpgradationRate,
                MaxGradeValue=obj.MaxGradeValue,
                IsActive=obj.IsActive,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static Level ToM(this LevelViewModel obj)
        {
            if (obj == null) return null;
            return new Level
            {
                Id = obj.Id??default(int),
                Name = obj.Name,
                GradePerMonth = obj.GradePerMonth,
                GradeUpgradationMonth = obj.GradeUpgradationMonth,
                GradeUpgradationRate = obj.GradeUpgradationRate,
                MaxGradeValue = obj.MaxGradeValue,
                IsActive = obj.IsActive,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static IList<Level> ToM(this IList<LevelViewModel> obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return obj.Select(c => c.ToM()).ToList();
        }
        public static IList<LevelViewModel> ToVM(this IList<Level> obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return obj.Select(c => c.ToVM()).ToList();
        }

        public static PayGrade ToM(this PayGradeViewModel obj)
        {
            if (obj == null) return null;
            return new PayGrade
            {
                Id = obj.Id??default(int),
                Name = obj.Name,
                MaxSalaryAmount=obj.MaxSalaryAmount,
                MinSalaryAmount=obj.MinSalaryAmount,
                NumberOfLevels=obj.NumberOfLevels,
                Status=obj.Status,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static PayGradeViewModel ToVM(this PayGrade obj)
        {
            if (obj == null) return null;
            return new PayGradeViewModel
            {
                Id = obj.Id,
                Name = obj.Name,
                MaxSalaryAmount = obj.MaxSalaryAmount,
                MinSalaryAmount = obj.MinSalaryAmount,
                NumberOfLevels = obj.NumberOfLevels,
                Status = obj.Status,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static IList<PayGrade> ToM(this IList<PayGradeViewModel> obj )
        {
            if (obj == null) return null;
            return obj.Select(b => b.ToM()).ToList();
        }
        public static IList<PayGradeViewModel> ToVM(this IList<PayGrade> obj)
        {
            if (obj == null) return null;
            return obj.Select(b => b.ToVM()).ToList();
        }
        public static PagedResult<PayGradeViewModel> ToVM(this PagedResult<PayGrade> obj)
        {
            if (obj == null) return null;
            return new PagedResult<PayGradeViewModel>
            {
                Results = obj.Results.ToVM().ToList(),
                CurrentPage = obj.CurrentPage,
                PageCount = obj.PageCount,
                PageSize = obj.PageSize,
                RowCount = obj.RowCount
            };
        }

        public static IList<PostViewModel> ToVM(this IList<Post> obj,DbHelper dbHelper)
        {
            if (obj == null) return null;
            return obj.Select(c => c.ToVM(dbHelper)).ToList();
        }
        public static PostViewModel ToVM(this Post obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new PostViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                LevelId=obj.LevelId,
                Level= dbHelper.GetLevelByIdAsync(obj.LevelId).Result.ToVM(),
                Description =obj.Description,
                ServiceId=obj.ServiceId,
                Service=dbHelper.GetServiceByIdAsync(obj.ServiceId).Result.ToVM(),
                PostCategoryId=obj.PostCategoryId,
                PostCategory=dbHelper.GetPostCategoryByIdAsync(obj.PostCategoryId).Result.ToVM(),
                Status=obj.Status,
                WorkTypeId=obj.WorkTypeId,
                WorkType=dbHelper.GetWorkTypeByIdAsync(obj.WorkTypeId).Result.ToVM(),                
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }    
        public static Post ToM(this PostViewModel obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new Post
            {
                Id = obj.Id??default(int),
                Name = obj.Name,
                LevelId = obj.LevelId,                
                Description = obj.Description,
                ServiceId = obj.ServiceId,
                PostCategoryId = obj.PostCategoryId,
                Status = obj.Status,
                WorkTypeId = obj.WorkTypeId,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static Person ToM(this PersonViewModel obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new Person()
            {
                Id = obj.Id ?? default(int),
                CastId = obj.CastId,
                FirstName = obj.FirstName,
                MiddleName = obj.MiddleName,
                LastName = obj.LastName,
                GenderId = obj.GenderId,
                DOB = obj.DOB,               
                EduInstutionTypeId = obj.EduInstutionTypeId,
                Email = obj.Email,
                HealthStatusId = obj.HealthStatusId,
                TemporaryAddressId = obj.TemporaryAddressId,
                PermanentAddressId = obj.PermanentAddressId,
                IdentityTypeId = obj.IdentityTypeId,
                IdentityNumber = obj.IdentityNumber,
                IdentityIssuePlace = obj.IdentityIssuePlace,
                IdentityIssueData = obj.IdentityIssueData,
                Phone1 = obj.Phone1,
                Phone2 = obj.Phone2,
                LitracyId = obj.LitracyId,
                MaritalStatusId = obj.MaritalStatusId,
                RelationId = obj.RelationId,
                ReligionId = obj.ReligionId,
                Photo = Convert.FromBase64String(obj.Photo.Split("base64,")[1]),
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
       
        public static EmployeeJob ToM(this EmployeeJobViewModel obj,DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new EmployeeJob
            {
                Id=obj.Id??default(int),
                OfficeDepartmentId=obj.OfficeDepartmentId,
                HiringDate=obj.HiringDate,
                OpinionSuggestion=obj.OpinionSuggestion,
                PostId=obj.PostId,
                ProbationPeriodFrom=obj.ProbationPeriodFrom,
                ProbationPeriodTo=obj.ProbationPeriodTo,
                ProbationPermorfanceSummary=obj.ProbationPermorfanceSummary,
                SymbolNumber=obj.SymbolNumber,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified

            };
        }
        public static Employee ToM(this EmployeeViewModel obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new Employee
            {
                Id = obj.Id ?? default(int),
                CitNumber = obj.CitNumber,
                EmployeeJobId = obj.EmployeeJobId,
                ManagerId = obj.ManagerId,
                NomineeId = obj.NomineeId,
                PanNumber = obj.PanNumber,
                PersonId = obj.PersonId,
                Person = dbHelper.GetPersonByIdAysc(obj.PersonId).Result,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };

        }
        public static EmployeeViewModel ToVM(this Employee obj, DbHelper dbHelper)
        {
            if (obj == null) return null;

            return new EmployeeViewModel
            {
                Id = obj.Id,
                EmployeeJobId = obj.EmployeeJobId,
                EmployeeJob = dbHelper.GetEmployeeJobById(obj.EmployeeJobId).Result.ToVM(dbHelper),
                ManagerId = obj.ManagerId,
                Manager = dbHelper.GetEmployeeById(obj.ManagerId).Result.ToVM(dbHelper),
                NomineeId = obj.NomineeId,
                Nominee = dbHelper.GetPersonByIdAysc(obj.NomineeId).Result.ToVM(dbHelper),
                PanNumber = obj.PanNumber,
                CitNumber = obj.CitNumber,
                PersonId = obj.PersonId,
                Person = dbHelper.GetPersonByIdAysc(obj.PersonId).Result.ToVM(dbHelper),
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }
        public static IList<EmployeeViewModel> ToVM(this IList<Employee> obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            var lsEmployees = new List<EmployeeViewModel>();
            foreach (var emp in obj)
            {
                var employee = new EmployeeViewModel
                {
                    Id = emp.Id,
                    PersonId = emp.PersonId,
                    Person=dbHelper.GetPersonByIdAysc(emp.PersonId).Result.ToVM(dbHelper),
                    CitNumber = emp.CitNumber,                    
                    EmployeeJobId = emp.EmployeeJobId,
                    EmployeeJob=dbHelper.GetEmployeeJobById(emp.EmployeeJobId).Result.ToVM(dbHelper),                    
                    ManagerId = emp.ManagerId,
                    Manager=dbHelper.GetEmployeeById(emp.ManagerId).Result.ToVM(dbHelper),
                    NomineeId = emp.NomineeId,
                    Nominee=dbHelper.GetPersonByIdAysc(emp.ManagerId).Result.ToVM(dbHelper),                    
                    PanNumber = emp.PanNumber,                                       
                    UserCreated = emp.UserCreated,
                    UserModified = emp.UserModified,
                    DateCreated = emp.DateCreated,
                    DateModified = emp.DateModified
                };

                lsEmployees.Add(employee);


            }
            return lsEmployees;

        }
        public static PagedResult<EmployeeViewModel> ToVM(this PagedResult<Employee> obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new PagedResult<EmployeeViewModel>
            {
                Results = obj.Results.Select(b => b.ToVM(dbHelper)).ToList(),
                CurrentPage = obj.CurrentPage,
                PageCount = obj.PageCount,
                PageSize = obj.PageSize,
                RowCount = obj.RowCount
            };
        }
        public static DayTypeViewModel ToVM(this DayType obj)
        {
            if (obj == null) return null;
            return new DayTypeViewModel
            {
                Id=obj.Id,
                Name=obj.Name,
                IsActive=obj.IsActive,
                DateCreated=obj.DateCreated,
                DateModified=obj.DateModified,
                UserCreated=obj.UserCreated,
                UserModified=obj.UserModified
            };
        }
        public static LeaveTypeViewModel ToVM(this LeaveType obj)
        {
            if (obj == null) return null;
            return new LeaveTypeViewModel
            {
                Id = obj.Id,
                Name = obj.Name,
                IsActive = obj.IsActive,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified
            };
        }
        public static ApproverViewModel ToVM(this Approver obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new ApproverViewModel
            {
                Id = obj.Id,
                ApproveHistoryId=obj.ApproveHistoryId,
                ApproverEmployeeId=obj.ApproverEmployeeId,
                ApproverFor=obj.ApproverFor,
                EmployeeId=obj.EmployeeId,
                Employee=dbHelper.GetEmployeeById(obj.EmployeeId).Result.ToVM(dbHelper),
                IsApproved=obj.IsApproved,
                IsCanceled=obj.IsCanceled,
                PermisionHirarchy=obj.PermisionHirarchy,

                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }

        public static CarbonCopyerViewModel ToVM(this CarbonCopyer obj, DbHelper dbHelper )
        {
            if (obj == null) return null;
            return new CarbonCopyerViewModel
            {
                Id = obj.Id,
                CarbonCopyFor=obj.CarbonCopyFor,
                EmployeeId=obj.EmployeeId,
                Employee = dbHelper.GetEmployeeById(obj.EmployeeId).Result.ToVM(dbHelper),
                HistoryId=obj.HistoryId,
                IsApproved=obj.IsApproved,
                IsCanceled=obj.IsCanceled,
                PermisionHirarchy=obj.PermisionHirarchy,
                UserCreated = obj.UserCreated,
                UserModified = obj.UserModified,
                DateCreated = obj.DateCreated,
                DateModified = obj.DateModified
            };
        }

        public static LeaveViewModel ToVM(this Leave obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new LeaveViewModel {
                Id=obj.Id,
                EmployeeId=obj.EmployeeId,
                Employee= dbHelper.GetEmployeeById(obj.EmployeeId).Result.ToVM(dbHelper),
                DayTypeId =obj.DayTypeId,
                DayType=dbHelper.GetDayTypeByIdAsync(obj.DayTypeId).Result.ToVM(),
                LeaveTypeId=obj.LeaveTypeId,
                LeaveType= dbHelper.GetLeaveTypeByIdAsync(obj.LeaveTypeId).Result.ToVM(),
                ReasonForLeav=obj.ReasonForLeav,
                DateFrom=obj.DateFrom,
                DateTo=obj.DateTo,
                IsApproved=dbHelper.GetApproveRejectStatus(obj.Id).Result.IsApproved,
                Approvers= dbHelper.GetApproverByHistoryId(obj.Id).Result.Select(b => b.ToVM(dbHelper)).ToList(),
                CcTos= dbHelper.GetCarbonCopyerByHistoryId(obj.Id).Result.Select(b => b.ToVM(dbHelper)).ToList(),
                UserCreated =obj.UserCreated,
                UserModified=obj.UserModified,
                DateCreated=obj.DateCreated,
                DateModified=obj.DateModified
            };
        }

        public static PagedResult<LeaveViewModel> ToVM(this PagedResult<Leave> obj, DbHelper dbHelper)
        {
            if (obj == null) return null;
            return new PagedResult<LeaveViewModel>
            {
                Results = obj.Results.Select(b => b.ToVM(dbHelper)).ToList(),
                CurrentPage = obj.CurrentPage,
                PageCount = obj.PageCount,
                PageSize = obj.PageSize,
                RowCount = obj.RowCount
            };
        }

    }
}
