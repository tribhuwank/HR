using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudHR.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Approver",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    ApproverEmployeeId = table.Column<int>(nullable: false),
                    ApproverFor = table.Column<int>(nullable: false),
                    ApproveHistoryId = table.Column<int>(nullable: true),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsCanceled = table.Column<bool>(nullable: false),
                    PermisionHirarchy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approver", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarbonCopyer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    HistoryId = table.Column<int>(nullable: true),
                    CarbonCopyFor = table.Column<int>(nullable: false),
                    IsApproved = table.Column<bool>(nullable: false),
                    IsCanceled = table.Column<bool>(nullable: false),
                    PermisionHirarchy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarbonCopyer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cast",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cast", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Code = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DayType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentRecord",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    RecordId = table.Column<int>(nullable: false),
                    AttachmentFor = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Attachment = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EduInstutionType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduInstutionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeJob",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    OfficeDepartmentId = table.Column<int>(nullable: true),
                    PostId = table.Column<int>(nullable: true),
                    HiringDate = table.Column<DateTime>(nullable: false),
                    SymbolNumber = table.Column<string>(nullable: false),
                    ProbationPeriodFrom = table.Column<DateTime>(nullable: true),
                    ProbationPeriodTo = table.Column<DateTime>(nullable: true),
                    ProbationPermorfanceSummary = table.Column<string>(nullable: true),
                    OpinionSuggestion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeJob", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealthStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holiday",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    FromDate = table.Column<DateTime>(nullable: false),
                    ToDate = table.Column<DateTime>(nullable: false),
                    IsPublicHoliday = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holiday", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ExpertiseLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leave",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    ReasonForLeav = table.Column<string>(nullable: false),
                    LeaveTypeId = table.Column<int>(nullable: false),
                    DateFrom = table.Column<DateTime>(nullable: false),
                    DateTo = table.Column<DateTime>(nullable: false),
                    DayTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leave", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Level",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    PayGradeId = table.Column<int>(nullable: false),
                    GradePerMonth = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GradeUpgradationMonth = table.Column<int>(nullable: false),
                    GradeUpgradationRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxGradeValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Litracy",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Litracy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MunVdc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    VdcMunType = table.Column<int>(nullable: false),
                    DistrictId = table.Column<int>(nullable: false),
                    WardCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MunVdc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Occupation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    ContactNo1 = table.Column<string>(nullable: false),
                    ContactNo2 = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: false),
                    Logo = table.Column<byte[]>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    EntryBy = table.Column<int>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficeDepartment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false),
                    OfficeId = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeDepartment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayGrade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    MinSalaryAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxSalaryAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumberOfLevels = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayGrade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: false),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    ReligionId = table.Column<int>(nullable: true),
                    CastId = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone1 = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    PermanentAddressId = table.Column<int>(nullable: true),
                    TemporaryAddressId = table.Column<int>(nullable: true),
                    MaritalStatusId = table.Column<int>(nullable: true),
                    HealthStatusId = table.Column<int>(nullable: true),
                    Photo = table.Column<byte[]>(nullable: true),
                    IdentityTypeId = table.Column<int>(nullable: true),
                    IdentityNumber = table.Column<string>(nullable: true),
                    IdentityIssueData = table.Column<DateTime>(nullable: true),
                    IdentityIssuePlace = table.Column<string>(nullable: true),
                    LitracyId = table.Column<int>(nullable: true),
                    EduInstutionTypeId = table.Column<int>(nullable: true),
                    RelationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonEducation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    EducationId = table.Column<int>(nullable: false),
                    Level = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDateDate = table.Column<DateTime>(nullable: true),
                    Institution = table.Column<string>(nullable: true),
                    InstitutionAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonEducation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonLanguage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonLanguage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonSkill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonSkill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PostCategoryId = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    LevelId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    WorkTypeId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PostCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Relation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    ParentServiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    DeptNumber = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    OfficeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    EmployeeJobId = table.Column<int>(nullable: false),
                    ManagerId = table.Column<int>(nullable: true),
                    NomineeId = table.Column<int>(nullable: true),
                    PanNumber = table.Column<string>(nullable: true),
                    CitNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeJob_EmployeeJobId",
                        column: x => x.EmployeeJobId,
                        principalTable: "EmployeeJob",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Employee_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Person_NomineeId",
                        column: x => x.NomineeId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_District_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDependent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDependent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDependent_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeDependent_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: true),
                    UserCreated = table.Column<string>(nullable: true),
                    DateModified = table.Column<DateTime>(nullable: true),
                    UserModified = table.Column<string>(nullable: true),
                    AddressTypeId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false),
                    DistrictId = table.Column<int>(nullable: false),
                    MunVdcId = table.Column<int>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    WardNo = table.Column<string>(nullable: false),
                    PinCode = table.Column<string>(nullable: true),
                    HouseNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_AddressType_AddressTypeId",
                        column: x => x.AddressTypeId,
                        principalTable: "AddressType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_MunVdc_MunVdcId",
                        column: x => x.MunVdcId,
                        principalTable: "MunVdc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AddressType",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, null, null, "Permanent", null, null },
                    { 2, null, null, "Temporary", null, null }
                });

            migrationBuilder.InsertData(
                table: "Cast",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 11, null, null, "Otehr", null, null },
                    { 9, null, null, "Sarki", null, null },
                    { 8, null, null, "Kami", null, null },
                    { 7, null, null, "Sanyasi", null, null },
                    { 6, null, null, "Damai", null, null },
                    { 10, null, null, "Gaine", null, null },
                    { 4, null, null, "Chettri", null, null },
                    { 3, null, null, "Brahmin", null, null },
                    { 2, null, null, "Gurung", null, null },
                    { 1, null, null, "Magar", null, null },
                    { 5, null, null, "Chantayal", null, null }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Code", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, "NP", null, null, "Nepal", null, null },
                    { 2, "IN", null, null, "India", null, null },
                    { 3, "US", null, null, "United States", null, null },
                    { 4, "CA", null, null, "Canada", null, null },
                    { 5, "GB", null, null, "United Kingdom", null, null }
                });

            migrationBuilder.InsertData(
                table: "DayType",
                columns: new[] { "Id", "DateCreated", "DateModified", "IsActive", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, null, null, true, "Full Day", null, null },
                    { 2, null, null, true, "First Half", null, null },
                    { 3, null, null, true, "Second Half", null, null }
                });

            migrationBuilder.InsertData(
                table: "EduInstutionType",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 6, null, null, "Gurukul", null, null },
                    { 7, null, null, "Other", null, null },
                    { 5, null, null, "Technical School", null, null },
                    { 4, null, null, "Private College", null, null },
                    { 3, null, null, "Community College", null, null },
                    { 2, null, null, "Government School", null, null },
                    { 1, null, null, "Private School", null, null }
                });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, null, null, "1-10", null, null },
                    { 2, null, null, "11-12", null, null },
                    { 3, null, null, "Bachelor", null, null },
                    { 4, null, null, "Master", null, null },
                    { 5, null, null, "PHD.", null, null },
                    { 6, null, null, "No Grade", null, null }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 3, null, null, "Third Gender", null, null },
                    { 4, null, null, "Other", null, null },
                    { 1, null, null, "Male", null, null },
                    { 2, null, null, "Female", null, null }
                });

            migrationBuilder.InsertData(
                table: "HealthStatus",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, null, null, "Disability", null, null },
                    { 2, null, null, "Healthy", null, null },
                    { 3, null, null, "Chronic Disease", null, null },
                    { 4, null, null, "Other", null, null }
                });

            migrationBuilder.InsertData(
                table: "IdentityType",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, null, null, "Passport", null, null },
                    { 2, null, null, "Nagrikta", null, null },
                    { 3, null, null, "Liscence", null, null }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "DateCreated", "DateModified", "ExpertiseLevel", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 4, null, null, null, "Chainees", null, null },
                    { 1, null, null, null, "English", null, null },
                    { 2, null, null, null, "Nepali", null, null },
                    { 3, null, null, null, "Hindi", null, null }
                });

            migrationBuilder.InsertData(
                table: "LeaveType",
                columns: new[] { "Id", "DateCreated", "DateModified", "IsActive", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 4, null, null, true, "Day Off", null, null },
                    { 3, null, null, true, "Medical Leave", null, null },
                    { 1, null, null, true, "Annual Leave", null, null },
                    { 2, null, null, true, "Emergency Leave", null, null }
                });

            migrationBuilder.InsertData(
                table: "Litracy",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, null, null, "Illiterate", null, null },
                    { 2, null, null, "literate", null, null }
                });

            migrationBuilder.InsertData(
                table: "MaritalStatus",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 5, null, null, "Divorced", null, null },
                    { 1, null, null, "UnMarried", null, null },
                    { 2, null, null, "Married", null, null },
                    { 3, null, null, "ReMarried", null, null },
                    { 4, null, null, "Widow/Widower", null, null }
                });

            migrationBuilder.InsertData(
                table: "MunVdc",
                columns: new[] { "Id", "DateCreated", "DateModified", "DistrictId", "Name", "UserCreated", "UserModified", "VdcMunType", "WardCount" },
                values: new object[,]
                {
                    { 497, null, null, 50, "Rajpur", null, null, 4, 7 },
                    { 496, null, null, 50, "Gadhawa", null, null, 4, 8 },
                    { 495, null, null, 50, "Dangi Sharan", null, null, 4, 7 },
                    { 510, null, null, 52, "Chandrakot", null, null, 4, 8 },
                    { 493, null, null, 50, "Lamahi", null, null, 3, 9 },
                    { 492, null, null, 50, "Ghorahi", null, null, 2, 19 },
                    { 498, null, null, 50, "Rapti", null, null, 4, 9 },
                    { 494, null, null, 50, "Banglachuli", null, null, 4, 8 },
                    { 499, null, null, 50, "Shanti Nagar", null, null, 4, 7 },
                    { 504, null, null, 52, "Musikot", null, null, 3, 9 },
                    { 501, null, null, 51, "Putha Uttar Ganga", null, null, 4, 14 },
                    { 502, null, null, 51, "Bhume", null, null, 4, 9 },
                    { 503, null, null, 51, "Sisne", null, null, 4, 8 },
                    { 491, null, null, 50, "Tulsipur", null, null, 2, 19 },
                    { 505, null, null, 52, "Resunga", null, null, 3, 14 },
                    { 506, null, null, 52, "Isma", null, null, 4, 6 },
                    { 507, null, null, 52, "Kali Gandaki", null, null, 4, 7 },
                    { 508, null, null, 52, "Gulmi Darbar", null, null, 4, 7 },
                    { 509, null, null, 52, "Satyawati", null, null, 4, 8 },
                    { 500, null, null, 50, "Babai", null, null, 4, 7 },
                    { 490, null, null, 49, "Geruwa", null, null, 4, 6 },
                    { 485, null, null, 49, "Rajapur Tratal", null, null, 3, 10 },
                    { 488, null, null, 49, "Bar Bardiya", null, null, 3, 11 },
                    { 468, null, null, 46, "Bandipur", null, null, 4, 6 },
                    { 469, null, null, 47, "Sandhikharka", null, null, 3, 12 },
                    { 470, null, null, 47, "Shit Ganga", null, null, 3, 14 },
                    { 471, null, null, 47, "Bhumikasthan", null, null, 3, 10 },
                    { 472, null, null, 47, "Chhatra Dev", null, null, 4, 8 },
                    { 473, null, null, 47, "Panini", null, null, 4, 8 },
                    { 474, null, null, 47, "Malarani", null, null, 4, 9 },
                    { 475, null, null, 48, "Nepalgunj", null, null, 2, 23 },
                    { 476, null, null, 48, "Kohalpur", null, null, 3, 15 },
                    { 477, null, null, 48, "Narainapur", null, null, 4, 6 },
                    { 478, null, null, 48, "Raptisonari", null, null, 4, 9 },
                    { 479, null, null, 48, "Baijanath", null, null, 4, 8 },
                    { 480, null, null, 48, "Khajura", null, null, 4, 8 },
                    { 481, null, null, 48, "Duduwa", null, null, 4, 6 },
                    { 482, null, null, 48, "Janaki", null, null, 4, 6 },
                    { 483, null, null, 49, "Gulariya", null, null, 3, 12 },
                    { 484, null, null, 49, "Madhuvan", null, null, 3, 9 },
                    { 486, null, null, 49, "Thakura Baba", null, null, 3, 9 },
                    { 487, null, null, 49, "Bansgadhi", null, null, 3, 9 },
                    { 489, null, null, 49, "Badhaiya Tal", null, null, 4, 9 },
                    { 511, null, null, 52, "Ruru", null, null, 4, 6 },
                    { 541, null, null, 55, "Ribdikot", null, null, 4, 8 },
                    { 513, null, null, 52, "Dhurkot", null, null, 4, 7 },
                    { 538, null, null, 55, "Matha Gadhi", null, null, 4, 8 },
                    { 539, null, null, 55, "Tinau", null, null, 4, 6 },
                    { 540, null, null, 55, "Bagnaskali", null, null, 4, 9 },
                    { 467, null, null, 46, "Myagde", null, null, 4, 7 },
                    { 542, null, null, 55, "Raina Devi Chhahara", null, null, 4, 8 },
                    { 543, null, null, 56, "Pyuthan", null, null, 3, 10 },
                    { 544, null, null, 56, "Swargadwari", null, null, 3, 9 },
                    { 545, null, null, 56, "Gaumukhi", null, null, 4, 7 },
                    { 546, null, null, 56, "Mandavi", null, null, 4, 5 },
                    { 547, null, null, 56, "Sarumarani", null, null, 4, 6 },
                    { 548, null, null, 56, "Mallarani", null, null, 4, 5 },
                    { 549, null, null, 56, "Nau Bahini", null, null, 4, 8 },
                    { 550, null, null, 56, "Jhimaruk", null, null, 4, 8 },
                    { 551, null, null, 56, "Eairabati", null, null, 4, 6 },
                    { 552, null, null, 57, "Rolpa", null, null, 3, 10 },
                    { 553, null, null, 57, "Triveni", null, null, 4, 7 },
                    { 554, null, null, 57, "Dui Kholi", null, null, 4, 6 },
                    { 555, null, null, 57, "Madi", null, null, 4, 6 },
                    { 556, null, null, 57, "Runti Gadhi", null, null, 4, 9 },
                    { 537, null, null, 55, "Rambha", null, null, 4, 5 },
                    { 536, null, null, 55, "Purba Khola", null, null, 4, 6 },
                    { 535, null, null, 55, "Nisdi", null, null, 4, 7 },
                    { 534, null, null, 55, "Tansen", null, null, 3, 14 },
                    { 514, null, null, 52, "Madane", null, null, 4, 7 },
                    { 515, null, null, 52, "Malika", null, null, 4, 8 },
                    { 516, null, null, 53, "Kapilbastu", null, null, 3, 12 },
                    { 517, null, null, 53, "Buddabhumi", null, null, 3, 10 },
                    { 518, null, null, 53, "Shivaraj", null, null, 3, 11 },
                    { 519, null, null, 53, "Maharajganj", null, null, 3, 11 },
                    { 520, null, null, 53, "Krishna Nagar", null, null, 3, 12 },
                    { 521, null, null, 53, "Banganga", null, null, 3, 11 },
                    { 522, null, null, 53, "Mayadevi", null, null, 4, 8 },
                    { 512, null, null, 52, "chhatrakot", null, null, 4, 6 },
                    { 523, null, null, 53, "Yashodhara", null, null, 4, 8 },
                    { 525, null, null, 53, "Bijay Nagar", null, null, 4, 7 },
                    { 526, null, null, 54, "Bardghat", null, null, 3, 16 },
                    { 527, null, null, 54, "Ramgram", null, null, 3, 18 },
                    { 528, null, null, 54, "Sunwal", null, null, 3, 13 },
                    { 529, null, null, 54, "Susta", null, null, 4, 7 },
                    { 530, null, null, 54, "Palhinand", null, null, 4, 6 },
                    { 531, null, null, 54, "Pratappur", null, null, 4, 9 },
                    { 532, null, null, 54, "Sarawal", null, null, 4, 7 },
                    { 533, null, null, 55, "Rampur", null, null, 3, 10 },
                    { 524, null, null, 53, "Suddodhana", null, null, 4, 6 },
                    { 466, null, null, 46, "Devghat", null, null, 4, 5 },
                    { 436, null, null, 43, "Madhyabindu", null, null, 4, 15 },
                    { 464, null, null, 46, "Rishing", null, null, 4, 8 },
                    { 398, null, null, 37, "Ajirkot", null, null, 4, 5 },
                    { 399, null, null, 37, "Aarughat", null, null, 4, 10 },
                    { 400, null, null, 37, "Gandaki", null, null, 4, 8 },
                    { 401, null, null, 37, "Chumanubri", null, null, 4, 7 },
                    { 402, null, null, 37, "Dharche", null, null, 4, 7 },
                    { 403, null, null, 37, "Bhimsen", null, null, 4, 8 },
                    { 404, null, null, 37, "Sahid Lakhnath", null, null, 4, 9 },
                    { 405, null, null, 38, "Pokhara Lekhnath", null, null, 1, 33 },
                    { 406, null, null, 38, "Annapurna", null, null, 4, 11 },
                    { 407, null, null, 38, "Machhapuchhre", null, null, 4, 9 },
                    { 408, null, null, 38, "Madi", null, null, 4, 12 },
                    { 409, null, null, 38, "Rupa", null, null, 4, 7 },
                    { 410, null, null, 39, "Besishahar", null, null, 3, 11 },
                    { 411, null, null, 39, "Madhya Nepal", null, null, 3, 10 },
                    { 412, null, null, 39, "Rainas", null, null, 3, 10 },
                    { 413, null, null, 39, "Sundarbazar", null, null, 3, 11 },
                    { 414, null, null, 39, "Kabahola Sothar", null, null, 4, 9 },
                    { 415, null, null, 39, "Dudh Pokhari", null, null, 4, 6 },
                    { 416, null, null, 39, "Dordi", null, null, 4, 9 },
                    { 397, null, null, 37, "Siranchok", null, null, 4, 8 },
                    { 417, null, null, 39, "Marsyangdi", null, null, 4, 9 },
                    { 396, null, null, 37, "Sulikot", null, null, 4, 8 },
                    { 394, null, null, 37, "Gorkha", null, null, 3, 14 },
                    { 375, null, null, 35, "Indrawati", null, null, 4, 12 },
                    { 376, null, null, 35, "Jugal", null, null, 4, 7 },
                    { 377, null, null, 35, "Panchapokhari", null, null, 4, 8 },
                    { 378, null, null, 35, "Balephi", null, null, 4, 8 },
                    { 379, null, null, 35, "Bhotekoshi", null, null, 4, 5 },
                    { 380, null, null, 35, "Lishankhu Pakhar", null, null, 4, 7 },
                    { 381, null, null, 35, "Sunkoshi", null, null, 4, 7 },
                    { 382, null, null, 35, "Helambu", null, null, 4, 7 },
                    { 383, null, null, 35, "Tripurasundari", null, null, 4, 6 },
                    { 384, null, null, 36, "Baglung", null, null, 3, 14 },
                    { 385, null, null, 36, "Galkot", null, null, 3, 11 },
                    { 386, null, null, 36, "Jaimini", null, null, 3, 10 },
                    { 387, null, null, 36, "Dhorpatan", null, null, 3, 9 },
                    { 388, null, null, 36, "Bareng", null, null, 4, 5 },
                    { 389, null, null, 36, "Kathe Khola", null, null, 4, 8 },
                    { 390, null, null, 36, "Taman Khola", null, null, 4, 6 },
                    { 391, null, null, 36, "Tara Khola", null, null, 4, 5 },
                    { 392, null, null, 36, "Nisi Khola", null, null, 4, 7 },
                    { 393, null, null, 36, "Badi Gad", null, null, 4, 10 },
                    { 395, null, null, 37, "Palungtar", null, null, 3, 10 },
                    { 418, null, null, 40, "Chame", null, null, 4, 5 },
                    { 419, null, null, 40, "Nar phu", null, null, 4, 5 },
                    { 420, null, null, 40, "Nashong", null, null, 4, 9 },
                    { 445, null, null, 44, "Maha Shila", null, null, 4, 6 },
                    { 446, null, null, 44, "Modi", null, null, 4, 8 },
                    { 447, null, null, 44, "Bihadi", null, null, 4, 6 },
                    { 448, null, null, 45, "Galyang", null, null, 3, 11 },
                    { 449, null, null, 45, "Chapakot", null, null, 3, 10 },
                    { 450, null, null, 45, "Putalibazar", null, null, 3, 14 },
                    { 451, null, null, 45, "Bhirkot", null, null, 3, 9 },
                    { 452, null, null, 45, "Waling", null, null, 3, 14 },
                    { 453, null, null, 45, "Arjun Chaupari", null, null, 4, 6 },
                    { 454, null, null, 45, "Aandhi Khola", null, null, 4, 6 },
                    { 455, null, null, 45, "Kali Gandaki", null, null, 4, 7 },
                    { 456, null, null, 45, "Phedi Khola", null, null, 4, 5 },
                    { 457, null, null, 45, "Biruwa", null, null, 4, 8 },
                    { 458, null, null, 45, "Harinas", null, null, 4, 7 },
                    { 459, null, null, 46, "Bhanu", null, null, 3, 13 },
                    { 460, null, null, 46, "Bhimad", null, null, 3, 9 },
                    { 461, null, null, 46, "Byas", null, null, 3, 14 },
                    { 462, null, null, 46, "Sukla Gandaki", null, null, 3, 12 },
                    { 463, null, null, 46, "Aanbu Khaireni", null, null, 4, 6 },
                    { 444, null, null, 44, "Painyoo", null, null, 4, 7 },
                    { 443, null, null, 44, "Jaljala", null, null, 4, 9 },
                    { 442, null, null, 44, "Phalebas", null, null, 3, 11 },
                    { 441, null, null, 44, "Kushma", null, null, 3, 14 },
                    { 421, null, null, 40, "Nesyang", null, null, 4, 9 },
                    { 422, null, null, 41, "Gharpajhong", null, null, 4, 5 },
                    { 423, null, null, 41, "Thasang", null, null, 4, 5 },
                    { 424, null, null, 41, "Dalome", null, null, 4, 5 },
                    { 425, null, null, 41, "Lomanthang", null, null, 4, 5 },
                    { 426, null, null, 41, "Barha Gaun Muktichhetra", null, null, 4, 5 },
                    { 427, null, null, 42, "Beni", null, null, 3, 10 },
                    { 428, null, null, 42, "Annapurna", null, null, 4, 8 },
                    { 429, null, null, 42, "Dhawalagiri", null, null, 4, 7 },
                    { 465, null, null, 46, "Ghiring", null, null, 4, 5 },
                    { 430, null, null, 42, "Mangala", null, null, 4, 5 },
                    { 432, null, null, 42, "Raghu Ganga", null, null, 4, 8 },
                    { 433, null, null, 43, "Kawasoti", null, null, 3, 17 },
                    { 434, null, null, 43, "Gaindakot", null, null, 3, 18 },
                    { 435, null, null, 43, "Devachuli", null, null, 3, 17 },
                    { 557, null, null, 57, "Lungri", null, null, 4, 7 },
                    { 437, null, null, 43, "Bungdikali", null, null, 4, 6 },
                    { 438, null, null, 43, "Bulingtar", null, null, 4, 6 },
                    { 439, null, null, 43, "Binayi Triveni", null, null, 4, 5 },
                    { 440, null, null, 43, "Hupsekot", null, null, 4, 6 },
                    { 431, null, null, 42, "Malika", null, null, 4, 7 },
                    { 558, null, null, 57, "Sukidaha", null, null, 4, 7 },
                    { 588, null, null, 59, "Thantikandh", null, null, 4, 6 },
                    { 560, null, null, 57, "Subarnawati", null, null, 4, 8 },
                    { 678, null, null, 71, "Bungal", null, null, 3, 11 },
                    { 679, null, null, 71, "Talkot", null, null, 4, 7 },
                    { 680, null, null, 71, "Masta", null, null, 4, 7 },
                    { 681, null, null, 71, "Khaptadchhanna", null, null, 4, 7 },
                    { 682, null, null, 71, "Thalara", null, null, 4, 9 }
                });

            migrationBuilder.InsertData(
                table: "MunVdc",
                columns: new[] { "Id", "DateCreated", "DateModified", "DistrictId", "Name", "UserCreated", "UserModified", "VdcMunType", "WardCount" },
                values: new object[,]
                {
                    { 683, null, null, 71, "Bitthadchir", null, null, 4, 9 },
                    { 684, null, null, 71, "Surma", null, null, 4, 5 },
                    { 685, null, null, 71, "Chhabis Pathibhera", null, null, 4, 7 },
                    { 686, null, null, 71, "Durgathali", null, null, 4, 7 },
                    { 687, null, null, 71, "Kedarsyun", null, null, 4, 9 },
                    { 688, null, null, 71, "Kanda", null, null, 4, 5 },
                    { 689, null, null, 72, "Badi Malika", null, null, 3, 9 },
                    { 690, null, null, 72, "Budhi Ganga", null, null, 3, 9 },
                    { 691, null, null, 72, "Budhi Nanda", null, null, 3, 10 },
                    { 692, null, null, 72, "Gaumul", null, null, 3, 10 },
                    { 693, null, null, 72, "Pandav Gupha", null, null, 4, 6 },
                    { 694, null, null, 72, "Swamikartik", null, null, 4, 6 },
                    { 695, null, null, 72, "Chhededaha", null, null, 4, 5 },
                    { 696, null, null, 72, "Himali", null, null, 4, 7 },
                    { 677, null, null, 71, "Jaya Prithvi", null, null, 3, 11 },
                    { 697, null, null, 73, "Amargadhi", null, null, 3, 11 },
                    { 676, null, null, 70, "Dilasaini", null, null, 4, 7 },
                    { 674, null, null, 70, "Pancheshwor", null, null, 4, 6 },
                    { 655, null, null, 68, "Barphikot", null, null, 4, 10 },
                    { 656, null, null, 68, "Sani Bheri", null, null, 4, 11 },
                    { 657, null, null, 69, "Mangalsen", null, null, 3, 14 },
                    { 658, null, null, 69, "Sanfebagar", null, null, 3, 14 },
                    { 659, null, null, 69, "Kamalbazar", null, null, 3, 10 },
                    { 660, null, null, 69, "Panchdeval Jayagad", null, null, 3, 9 },
                    { 661, null, null, 69, "Chourpati", null, null, 4, 7 },
                    { 662, null, null, 69, "Mellekh", null, null, 4, 8 },
                    { 663, null, null, 69, "Bannigadhi Jayagadh", null, null, 4, 6 },
                    { 664, null, null, 69, "RamaRoshan", null, null, 4, 7 },
                    { 665, null, null, 69, "Dhakari", null, null, 4, 8 },
                    { 666, null, null, 69, "Turmakhand", null, null, 4, 11 },
                    { 667, null, null, 70, "Dasharath Chanda", null, null, 3, 11 },
                    { 668, null, null, 70, "Patan", null, null, 3, 10 },
                    { 669, null, null, 70, "Melauli", null, null, 3, 9 },
                    { 670, null, null, 70, "Purchaundi", null, null, 3, 10 },
                    { 671, null, null, 70, "Surnaiya", null, null, 4, 8 },
                    { 672, null, null, 70, "Sigas", null, null, 4, 9 },
                    { 673, null, null, 70, "Shivanath", null, null, 4, 6 },
                    { 675, null, null, 70, "Dogada Kedar", null, null, 4, 8 },
                    { 698, null, null, 73, "Parashuram", null, null, 3, 12 },
                    { 699, null, null, 73, "Aalitaal", null, null, 4, 8 },
                    { 700, null, null, 73, "Bhageshwor", null, null, 4, 5 },
                    { 725, null, null, 76, "Lamki Chuha", null, null, 3, 10 },
                    { 726, null, null, 76, "Bhajani", null, null, 3, 9 },
                    { 727, null, null, 76, "Godavari", null, null, 3, 12 },
                    { 728, null, null, 76, "Gauri Ganga", null, null, 3, 11 },
                    { 729, null, null, 76, "Janaki", null, null, 4, 9 },
                    { 730, null, null, 76, "Bardagoriya", null, null, 4, 6 },
                    { 731, null, null, 76, "Mohanyal", null, null, 4, 7 },
                    { 732, null, null, 76, "Kailari", null, null, 4, 9 },
                    { 733, null, null, 76, "Joshipur", null, null, 4, 7 },
                    { 734, null, null, 76, "Chure", null, null, 4, 6 },
                    { 735, null, null, 77, "Bhimdatta", null, null, 3, 19 },
                    { 736, null, null, 77, "Punarbas", null, null, 3, 11 },
                    { 737, null, null, 77, "Bedkot", null, null, 3, 10 },
                    { 738, null, null, 77, "Mahakali", null, null, 3, 10 },
                    { 739, null, null, 77, "Shuklaphanta", null, null, 3, 10 },
                    { 740, null, null, 77, "Belauri", null, null, 3, 10 },
                    { 741, null, null, 77, "Krishnapur", null, null, 3, 9 },
                    { 742, null, null, 77, "Beldandi", null, null, 4, 5 },
                    { 743, null, null, 77, "Laljhadi", null, null, 4, 6 },
                    { 724, null, null, 76, "Ghodaghodi", null, null, 3, 12 },
                    { 723, null, null, 76, "Tikapur", null, null, 3, 9 },
                    { 722, null, null, 76, "Dhangadi", null, null, 2, 19 },
                    { 721, null, null, 75, "Bogtan", null, null, 4, 7 },
                    { 701, null, null, 73, "Navadurga", null, null, 4, 5 },
                    { 702, null, null, 73, "Ajaymeru", null, null, 4, 6 },
                    { 703, null, null, 73, "Ganyapdhura", null, null, 4, 5 },
                    { 704, null, null, 74, "Mahakali", null, null, 3, 9 },
                    { 705, null, null, 74, "Sailya Shikhar", null, null, 3, 9 },
                    { 706, null, null, 74, "Malikarjun", null, null, 4, 8 },
                    { 707, null, null, 74, "Api Himal", null, null, 4, 6 },
                    { 708, null, null, 74, "Duhun", null, null, 4, 5 },
                    { 709, null, null, 74, "Naugad", null, null, 4, 6 },
                    { 654, null, null, 68, "Triveni", null, null, 4, 10 },
                    { 710, null, null, 74, "Marma", null, null, 4, 6 },
                    { 712, null, null, 74, "Byans", null, null, 4, 6 },
                    { 713, null, null, 75, "Dipayal Silgadi", null, null, 3, 9 },
                    { 714, null, null, 75, "Shikhar", null, null, 3, 11 },
                    { 715, null, null, 75, "Purbi Chouki", null, null, 4, 7 },
                    { 716, null, null, 75, "Badikedar", null, null, 4, 5 },
                    { 717, null, null, 75, "Jorayal", null, null, 4, 6 },
                    { 718, null, null, 75, "Sayal", null, null, 4, 6 },
                    { 719, null, null, 75, "Aadarsha", null, null, 4, 7 },
                    { 720, null, null, 75, "K.I.Singh", null, null, 4, 7 },
                    { 711, null, null, 74, "Lekam", null, null, 4, 6 },
                    { 653, null, null, 68, "Aathabiskot", null, null, 3, 14 },
                    { 652, null, null, 68, "Chaujahari", null, null, 3, 14 },
                    { 651, null, null, 68, "Musikot", null, null, 3, 14 },
                    { 585, null, null, 59, "Naumule", null, null, 4, 8 },
                    { 586, null, null, 59, "Mahabu", null, null, 4, 6 },
                    { 587, null, null, 59, "Bairavi", null, null, 4, 7 },
                    { 374, null, null, 35, "Melamchi", null, null, 3, 13 },
                    { 589, null, null, 60, "Thuli Bheri", null, null, 3, 11 },
                    { 590, null, null, 60, "Tripura Sundari", null, null, 3, 11 },
                    { 591, null, null, 60, "Dolpo Buddha", null, null, 4, 6 },
                    { 592, null, null, 60, "She-Phoksundo", null, null, 4, 9 },
                    { 593, null, null, 60, "Jagadulla", null, null, 4, 6 },
                    { 594, null, null, 60, "Mudke Chula Gaun", null, null, 4, 9 },
                    { 595, null, null, 60, "Kaieke", null, null, 4, 7 },
                    { 596, null, null, 60, "Chharka Tongsong", null, null, 4, 6 },
                    { 597, null, null, 61, "Simkot", null, null, 4, 8 },
                    { 598, null, null, 61, "Namkha", null, null, 4, 6 },
                    { 599, null, null, 61, "Kharpu Nath", null, null, 4, 5 },
                    { 600, null, null, 61, "Sarkegad", null, null, 4, 8 },
                    { 601, null, null, 61, "Chankheli", null, null, 4, 6 },
                    { 602, null, null, 61, "Adanchuli", null, null, 4, 6 },
                    { 603, null, null, 61, "Tanjakot", null, null, 4, 5 },
                    { 584, null, null, 59, "Dungeshwor", null, null, 4, 6 },
                    { 583, null, null, 59, "Gurans", null, null, 4, 8 },
                    { 582, null, null, 59, "Bhagawati Mai", null, null, 4, 7 },
                    { 581, null, null, 59, "Aathabis", null, null, 3, 9 },
                    { 561, null, null, 57, "Thawang", null, null, 4, 5 },
                    { 562, null, null, 58, "Butwal", null, null, 2, 19 },
                    { 563, null, null, 58, "Devdaha", null, null, 3, 12 },
                    { 564, null, null, 58, "Lumbini Sanskritik", null, null, 3, 13 },
                    { 565, null, null, 58, "Siddharthanagar", null, null, 3, 13 },
                    { 566, null, null, 58, "Saina Maina", null, null, 3, 11 },
                    { 567, null, null, 58, "Tilottama", null, null, 3, 17 },
                    { 568, null, null, 58, "Gaidahawa", null, null, 4, 9 },
                    { 569, null, null, 58, "Kanchan", null, null, 4, 5 },
                    { 604, null, null, 62, "Bheri", null, null, 3, 13 },
                    { 570, null, null, 58, "Kotahi Mai", null, null, 4, 7 },
                    { 572, null, null, 58, "Mayadevi", null, null, 4, 8 },
                    { 573, null, null, 58, "Om Satiya", null, null, 4, 6 },
                    { 574, null, null, 58, "Rohini", null, null, 4, 7 },
                    { 575, null, null, 58, "Sammari Mai", null, null, 4, 7 },
                    { 576, null, null, 58, "Siyari", null, null, 4, 7 },
                    { 577, null, null, 58, "Suddodhana", null, null, 4, 7 },
                    { 578, null, null, 59, "Narayan", null, null, 3, 11 },
                    { 579, null, null, 59, "Dullu", null, null, 3, 13 },
                    { 580, null, null, 59, "Chamunda Bindrasaini", null, null, 3, 9 },
                    { 571, null, null, 58, "Marchawari", null, null, 4, 7 },
                    { 559, null, null, 57, "Sunchhahari", null, null, 4, 7 },
                    { 605, null, null, 62, "Chhedagad", null, null, 3, 13 },
                    { 607, null, null, 62, "Kuse", null, null, 4, 9 },
                    { 632, null, null, 66, "Sharada", null, null, 3, 15 },
                    { 633, null, null, 66, "Bagchaur", null, null, 3, 12 },
                    { 634, null, null, 66, "Bangad Kupinde", null, null, 3, 12 },
                    { 635, null, null, 66, "Kalimati", null, null, 4, 7 },
                    { 636, null, null, 66, "Triveni", null, null, 4, 6 },
                    { 637, null, null, 66, "Kapurkot", null, null, 4, 6 },
                    { 638, null, null, 66, "Chhatreshwori", null, null, 4, 7 },
                    { 639, null, null, 66, "Dhorchaur", null, null, 4, 5 },
                    { 640, null, null, 66, "Kumakha Malika", null, null, 4, 7 },
                    { 641, null, null, 66, "Darma", null, null, 4, 6 },
                    { 642, null, null, 67, "Birendra Nagar", null, null, 3, 16 },
                    { 643, null, null, 67, "Bheri Ganga", null, null, 3, 13 },
                    { 644, null, null, 67, "Gurbhakot", null, null, 3, 14 },
                    { 645, null, null, 67, "Panchapuri", null, null, 3, 11 },
                    { 646, null, null, 67, "Lek Besi", null, null, 3, 10 },
                    { 647, null, null, 67, "Chaukune", null, null, 4, 10 },
                    { 648, null, null, 67, "Baraha Tal", null, null, 4, 10 },
                    { 649, null, null, 67, "Chingad", null, null, 4, 6 },
                    { 650, null, null, 67, "Simta", null, null, 4, 9 },
                    { 631, null, null, 65, "Khatyad", null, null, 4, 11 },
                    { 630, null, null, 65, "Soru", null, null, 4, 11 },
                    { 629, null, null, 65, "Mugumakarmarong", null, null, 4, 11 },
                    { 628, null, null, 65, "Chhaya Nath Rara", null, null, 3, 11 },
                    { 608, null, null, 62, "Junichande", null, null, 4, 11 },
                    { 609, null, null, 62, "Barekot", null, null, 4, 9 },
                    { 610, null, null, 62, "Shivalaya", null, null, 4, 9 },
                    { 611, null, null, 63, "Chandannath", null, null, 3, 10 },
                    { 612, null, null, 63, "Kanaka Sundari", null, null, 4, 8 },
                    { 613, null, null, 63, "Sinja", null, null, 4, 6 },
                    { 614, null, null, 63, "Hima", null, null, 4, 7 },
                    { 615, null, null, 63, "Tila", null, null, 4, 9 },
                    { 616, null, null, 63, "Guthichaur", null, null, 4, 5 },
                    { 606, null, null, 62, "Triveni Nalghad", null, null, 3, 13 },
                    { 617, null, null, 63, "Tatopani", null, null, 4, 8 },
                    { 619, null, null, 64, "Khandachakra", null, null, 3, 11 },
                    { 620, null, null, 64, "Raskot", null, null, 3, 9 },
                    { 621, null, null, 64, "Tila Gupha", null, null, 3, 11 },
                    { 622, null, null, 64, "Pachal Jharana", null, null, 4, 9 },
                    { 623, null, null, 64, "Sanni Triveni", null, null, 4, 9 },
                    { 624, null, null, 64, "Narhari Nath", null, null, 4, 9 },
                    { 625, null, null, 64, "Kalika", null, null, 4, 8 },
                    { 626, null, null, 64, "Mahawai", null, null, 4, 7 },
                    { 627, null, null, 64, "Palata", null, null, 4, 9 },
                    { 618, null, null, 63, "Patarasi", null, null, 4, 7 },
                    { 373, null, null, 35, "Barhabise", null, null, 3, 9 },
                    { 367, null, null, 34, "Teen Patan", null, null, 4, 11 },
                    { 371, null, null, 34, "Hariharpur", null, null, 4, 8 },
                    { 118, null, null, 12, "Phakatanglung", null, null, 4, 7 },
                    { 119, null, null, 12, "Mikwa Khola", null, null, 4, 5 },
                    { 120, null, null, 12, "Meringden", null, null, 4, 6 },
                    { 121, null, null, 12, "Maiwa Khola", null, null, 4, 6 },
                    { 122, null, null, 12, "Yangbarak", null, null, 4, 6 },
                    { 123, null, null, 12, "Sirijunga", null, null, 3, 8 },
                    { 124, null, null, 13, "Myanglung", null, null, 3, 10 },
                    { 125, null, null, 13, "Laligurans", null, null, 3, 9 },
                    { 126, null, null, 13, "Aatharai", null, null, 4, 7 },
                    { 127, null, null, 13, "Chhathar", null, null, 4, 6 },
                    { 128, null, null, 13, "Phedap", null, null, 4, 5 },
                    { 129, null, null, 13, "Menchayayem", null, null, 4, 6 },
                    { 130, null, null, 14, "Katari", null, null, 3, 14 },
                    { 131, null, null, 14, "ChaudandiGadhi", null, null, 3, 10 },
                    { 132, null, null, 14, "Triyuga", null, null, 3, 16 },
                    { 133, null, null, 14, "Belaka", null, null, 3, 9 },
                    { 134, null, null, 14, "Udayapur Gadhi", null, null, 4, 8 },
                    { 135, null, null, 14, "Tapli", null, null, 4, 5 },
                    { 136, null, null, 14, "Rautamai", null, null, 4, 8 },
                    { 117, null, null, 12, "Sidingawa", null, null, 4, 7 },
                    { 137, null, null, 14, "Sunkoshi", null, null, 4, 5 },
                    { 116, null, null, 12, "Aatharai Triveni", null, null, 4, 5 },
                    { 114, null, null, 11, "Harinagara", null, null, 4, 7 },
                    { 95, null, null, 10, "SoluDudhakund", null, null, 3, 10 },
                    { 96, null, null, 10, "Dudhakoshi", null, null, 4, 7 },
                    { 97, null, null, 10, "Khumbu PasangLhamu", null, null, 4, 5 },
                    { 98, null, null, 10, "Dudhakaushika", null, null, 4, 9 },
                    { 99, null, null, 10, "Necha Salyan", null, null, 4, 6 },
                    { 100, null, null, 10, "Maha Kulung", null, null, 4, 5 },
                    { 101, null, null, 10, "Likhu Pike", null, null, 4, 5 },
                    { 102, null, null, 10, "Sotang", null, null, 4, 5 },
                    { 103, null, null, 11, "Itahari", null, null, 2, 20 },
                    { 104, null, null, 11, "Dharan", null, null, 2, 20 },
                    { 105, null, null, 11, "Inaruwa", null, null, 3, 10 },
                    { 106, null, null, 11, "Duhabi", null, null, 3, 12 },
                    { 107, null, null, 11, "Ramdhuni", null, null, 3, 9 },
                    { 108, null, null, 11, "Baraha", null, null, 3, 11 },
                    { 109, null, null, 11, "Dewangunj", null, null, 4, 7 },
                    { 110, null, null, 11, "Koshi", null, null, 4, 8 },
                    { 111, null, null, 11, "Gadhi", null, null, 4, 6 },
                    { 112, null, null, 11, "Barju", null, null, 4, 6 },
                    { 113, null, null, 11, "Bhokraha", null, null, 4, 8 },
                    { 115, null, null, 12, "Phungling", null, null, 3, 11 },
                    { 138, null, null, 15, "Rajbiraj", null, null, 3, 15 },
                    { 139, null, null, 15, "Kanchanrup", null, null, 3, 12 },
                    { 140, null, null, 15, "Dakneshwori", null, null, 3, 11 },
                    { 165, null, null, 16, "Parsa Gadhi", null, null, 4, 6 },
                    { 166, null, null, 16, "Sakhuwa Prasouni", null, null, 4, 6 },
                    { 167, null, null, 16, "Paterwa Sugauli", null, null, 4, 7 },
                    { 168, null, null, 17, "Ishworpur", null, null, 3, 15 },
                    { 169, null, null, 17, "Malangawa", null, null, 3, 12 }
                });

            migrationBuilder.InsertData(
                table: "MunVdc",
                columns: new[] { "Id", "DateCreated", "DateModified", "DistrictId", "Name", "UserCreated", "UserModified", "VdcMunType", "WardCount" },
                values: new object[,]
                {
                    { 170, null, null, 17, "Lalbandi", null, null, 3, 17 },
                    { 171, null, null, 17, "Haripur", null, null, 3, 10 },
                    { 172, null, null, 17, "Haripurwa", null, null, 3, 11 },
                    { 173, null, null, 17, "Hariwan", null, null, 3, 11 },
                    { 174, null, null, 17, "Barahathawa", null, null, 3, 18 },
                    { 175, null, null, 17, "Balara", null, null, 3, 12 },
                    { 176, null, null, 17, "Godaita", null, null, 3, 11 },
                    { 177, null, null, 17, "Bagmati", null, null, 3, 10 },
                    { 178, null, null, 17, "Kabilasi", null, null, 4, 8 },
                    { 179, null, null, 17, "Chakraghatta", null, null, 4, 13 },
                    { 180, null, null, 17, "Chandra Nagar", null, null, 4, 7 },
                    { 181, null, null, 17, "Dhanakoul", null, null, 4, 9 },
                    { 182, null, null, 17, "Bramhapuri", null, null, 4, 9 },
                    { 183, null, null, 17, "Ram Nagar", null, null, 4, 10 },
                    { 164, null, null, 16, "Belawa", null, null, 4, 7 },
                    { 163, null, null, 16, "Bahudar Mai", null, null, 4, 8 },
                    { 162, null, null, 16, "Bindabasini", null, null, 4, 5 },
                    { 372, null, null, 35, "Chautara Sangachokgadhi", null, null, 3, 14 },
                    { 141, null, null, 15, "BodeBarsain", null, null, 3, 16 },
                    { 142, null, null, 15, "Khadak", null, null, 3, 11 },
                    { 143, null, null, 15, "Shambhunath", null, null, 3, 11 },
                    { 144, null, null, 15, "Surnga", null, null, 3, 11 },
                    { 145, null, null, 15, "HanumanNagar", null, null, 3, 14 },
                    { 146, null, null, 15, "Krishna Sawaran", null, null, 4, 5 },
                    { 147, null, null, 15, "Chhinnamasta", null, null, 4, 8 },
                    { 148, null, null, 15, "Mahadeva", null, null, 4, 6 },
                    { 149, null, null, 15, "Saptkoshi", null, null, 4, 11 },
                    { 94, null, null, 9, "Silingchong", null, null, 4, 5 },
                    { 150, null, null, 15, "Tirhut", null, null, 4, 5 },
                    { 152, null, null, 15, "Rupani", null, null, 4, 6 },
                    { 153, null, null, 15, "Belhi Chapani", null, null, 4, 5 },
                    { 154, null, null, 15, "Bishnupura", null, null, 4, 7 },
                    { 155, null, null, 16, "Birjunj", null, null, 1, 27 },
                    { 156, null, null, 16, "Pokhariya", null, null, 3, 11 },
                    { 157, null, null, 16, "Subarnapur", null, null, 4, 7 },
                    { 158, null, null, 16, "Jagarnathapur", null, null, 4, 6 },
                    { 159, null, null, 16, "Dhobini", null, null, 4, 5 },
                    { 160, null, null, 16, "Chhipahar Mai", null, null, 4, 5 },
                    { 151, null, null, 15, "Tilathi Koiladi", null, null, 4, 8 },
                    { 93, null, null, 9, "Sabhapokhari", null, null, 4, 6 },
                    { 92, null, null, 9, "Makalu", null, null, 4, 6 },
                    { 91, null, null, 9, "Chichila", null, null, 4, 5 },
                    { 25, null, null, 3, "Mangsebung", null, null, 4, 6 },
                    { 26, null, null, 3, "Sandakpur", null, null, 4, 5 },
                    { 27, null, null, 4, "MechiNagar", null, null, 3, 15 },
                    { 28, null, null, 4, "Damak", null, null, 3, 10 },
                    { 29, null, null, 4, "Kankai", null, null, 3, 9 },
                    { 30, null, null, 4, "Bhadrapur", null, null, 3, 10 },
                    { 31, null, null, 4, "Arjundhara", null, null, 3, 11 },
                    { 32, null, null, 4, "ShivaSataxi", null, null, 3, 11 },
                    { 33, null, null, 4, "Gauradaha", null, null, 3, 9 },
                    { 34, null, null, 4, "Birtamod", null, null, 3, 10 },
                    { 35, null, null, 4, "Kamal", null, null, 4, 7 },
                    { 36, null, null, 4, "Gaurigunj", null, null, 4, 6 },
                    { 37, null, null, 4, "Barhadashi", null, null, 4, 7 },
                    { 38, null, null, 4, "Jhapa", null, null, 4, 7 },
                    { 39, null, null, 4, "BuddaShanti", null, null, 4, 7 },
                    { 40, null, null, 4, "Haldibari", null, null, 4, 5 },
                    { 41, null, null, 4, "Kanchankawal", null, null, 4, 7 },
                    { 42, null, null, 5, "Rupakot Majhuwagadhi", null, null, 3, 15 },
                    { 43, null, null, 5, "Halesi Tuwachung", null, null, 3, 11 },
                    { 24, null, null, 3, "Rong", null, null, 4, 6 },
                    { 23, null, null, 3, "Chulachuli", null, null, 4, 6 },
                    { 22, null, null, 3, "Mai Jogmai", null, null, 4, 6 },
                    { 21, null, null, 3, "Phakphokthum", null, null, 4, 7 },
                    { 1, null, null, 1, "Bhojpur", null, null, 3, 12 },
                    { 2, null, null, 1, "Shadanand", null, null, 3, 14 },
                    { 3, null, null, 1, "Hatuwagadhi", null, null, 4, 9 },
                    { 4, null, null, 1, "Ramprasad Rai", null, null, 4, 8 },
                    { 5, null, null, 1, "Aamchok", null, null, 4, 10 },
                    { 6, null, null, 1, "Tyamke Maiyunm", null, null, 4, 9 },
                    { 7, null, null, 1, "Arun Gaunpalika", null, null, 4, 7 },
                    { 8, null, null, 1, "Pauwadungma", null, null, 4, 6 },
                    { 9, null, null, 1, "Salpasilichho", null, null, 4, 6 },
                    { 44, null, null, 5, "Khotehang", null, null, 4, 9 },
                    { 10, null, null, 2, "Dhankuta", null, null, 3, 10 },
                    { 12, null, null, 2, "Mahalaxmi", null, null, 3, 9 },
                    { 13, null, null, 2, "Sangurigadhi", null, null, 4, 10 },
                    { 14, null, null, 2, "Chaubise", null, null, 4, 8 },
                    { 15, null, null, 2, "Khalsa Chhintang Sahidbhumi", null, null, 4, 7 },
                    { 16, null, null, 2, "Chhathar Jorpati", null, null, 4, 6 },
                    { 17, null, null, 3, "Ilam", null, null, 3, 12 },
                    { 18, null, null, 3, "Deumai", null, null, 3, 9 },
                    { 19, null, null, 3, "Mai Municipality", null, null, 3, 10 },
                    { 20, null, null, 3, "Suryodaya", null, null, 3, 14 },
                    { 11, null, null, 2, "Pakhribas", null, null, 3, 10 },
                    { 184, null, null, 17, "Bishnu", null, null, 4, 12 },
                    { 45, null, null, 5, "Diprung", null, null, 4, 7 },
                    { 47, null, null, 5, "Jantedhunga", null, null, 4, 6 },
                    { 72, null, null, 7, "ChishankhuGadhi", null, null, 4, 8 },
                    { 73, null, null, 7, "ManeBhanjyang", null, null, 4, 9 },
                    { 74, null, null, 7, "Molung", null, null, 4, 8 },
                    { 75, null, null, 7, "Likhu", null, null, 4, 9 },
                    { 76, null, null, 7, "Sunkoshi", null, null, 4, 10 },
                    { 77, null, null, 8, "Phidim", null, null, 3, 14 },
                    { 78, null, null, 8, "Phalelung", null, null, 4, 8 },
                    { 79, null, null, 8, "Palgunanda", null, null, 4, 7 },
                    { 80, null, null, 8, "Hilihang", null, null, 4, 7 },
                    { 81, null, null, 8, "Kummayak", null, null, 4, 5 },
                    { 82, null, null, 8, "Miklajung", null, null, 3, 8 },
                    { 83, null, null, 8, "Tumbewa", null, null, 4, 5 },
                    { 84, null, null, 8, "Yangbarak", null, null, 4, 6 },
                    { 85, null, null, 9, "Chainpur", null, null, 3, 11 },
                    { 86, null, null, 9, "DharmaDevi", null, null, 4, 9 },
                    { 87, null, null, 9, "Khadbari", null, null, 4, 11 },
                    { 88, null, null, 9, "Madi", null, null, 4, 9 },
                    { 89, null, null, 9, "PanchKhapan", null, null, 4, 9 },
                    { 90, null, null, 9, "Bhot Khola", null, null, 3, 5 },
                    { 71, null, null, 7, "Champadevi", null, null, 3, 10 },
                    { 70, null, null, 7, "Khiji Demba", null, null, 4, 9 },
                    { 69, null, null, 7, "SiddiCharan", null, null, 3, 12 },
                    { 68, null, null, 6, "Jahada", null, null, 4, 7 },
                    { 48, null, null, 5, "Kepilasgadhi", null, null, 4, 7 },
                    { 49, null, null, 5, "Barahapokhari", null, null, 4, 6 },
                    { 50, null, null, 5, "Lamidanda ", null, null, 4, 6 },
                    { 51, null, null, 5, "Sakela", null, null, 4, 5 },
                    { 52, null, null, 6, "Biratnagar", null, null, 1, 19 },
                    { 53, null, null, 6, "SundarHaraincha", null, null, 3, 12 },
                    { 54, null, null, 6, "Belbari", null, null, 3, 11 },
                    { 55, null, null, 6, "Pathari-Sanishchare", null, null, 3, 10 },
                    { 56, null, null, 6, "Urlabari", null, null, 3, 9 },
                    { 46, null, null, 5, "Aiselukharka", null, null, 4, 7 },
                    { 57, null, null, 6, "Rangeli", null, null, 3, 9 },
                    { 59, null, null, 6, "Ratuwamai", null, null, 3, 10 },
                    { 60, null, null, 6, "Sunbarshi", null, null, 3, 9 },
                    { 61, null, null, 6, "Kerabari", null, null, 4, 10 },
                    { 62, null, null, 6, "Miklajung", null, null, 4, 9 },
                    { 63, null, null, 6, "Kanepokhari", null, null, 4, 7 },
                    { 64, null, null, 6, "BudhiGanga", null, null, 4, 7 },
                    { 65, null, null, 6, "Gramthan", null, null, 4, 7 },
                    { 66, null, null, 6, "Katahari", null, null, 4, 7 },
                    { 67, null, null, 6, "Dhanpalthan", null, null, 4, 7 },
                    { 58, null, null, 6, "Letang Bhogateni", null, null, 3, 9 },
                    { 185, null, null, 18, "Kalaiya", null, null, 2, 27 },
                    { 161, null, null, 16, "Pakaha Mainpur", null, null, 4, 5 },
                    { 187, null, null, 18, "Kolhabi", null, null, 3, 11 },
                    { 304, null, null, 27, "Tamakoshi", null, null, 4, 7 },
                    { 305, null, null, 27, "Melung", null, null, 4, 7 },
                    { 306, null, null, 27, "Bigu", null, null, 4, 8 },
                    { 307, null, null, 27, "Baiteshwor", null, null, 4, 8 },
                    { 308, null, null, 27, "Shailung", null, null, 4, 8 },
                    { 309, null, null, 28, "Dhulikhel", null, null, 3, 12 },
                    { 310, null, null, 28, "Banepa", null, null, 3, 14 },
                    { 311, null, null, 28, "Panauti", null, null, 3, 12 },
                    { 312, null, null, 28, "Panchkhal", null, null, 3, 13 },
                    { 313, null, null, 28, "Namobuddha", null, null, 3, 11 },
                    { 314, null, null, 28, "Mandan Deupur", null, null, 3, 12 },
                    { 315, null, null, 28, "Khanikhola", null, null, 4, 7 },
                    { 316, null, null, 28, "Chaunri Deurali", null, null, 4, 9 },
                    { 317, null, null, 28, "Temal", null, null, 4, 9 },
                    { 318, null, null, 28, "Bethanchok", null, null, 4, 6 },
                    { 319, null, null, 28, "Bhumlu", null, null, 4, 10 },
                    { 320, null, null, 28, "Mahabharat", null, null, 4, 8 },
                    { 321, null, null, 28, "Roshi", null, null, 4, 12 },
                    { 322, null, null, 29, "Lalitpur", null, null, 1, 29 },
                    { 186, null, null, 18, "Jitpur Simara", null, null, 2, 23 },
                    { 323, null, null, 29, "Godawari", null, null, 3, 14 },
                    { 302, null, null, 27, "Kalinchok", null, null, 4, 9 },
                    { 300, null, null, 27, "Jiri", null, null, 3, 9 },
                    { 281, null, null, 25, "Ganga Jamuna", null, null, 4, 7 },
                    { 282, null, null, 25, "Jwalamukhi", null, null, 4, 7 },
                    { 283, null, null, 25, "Thakre", null, null, 4, 11 },
                    { 284, null, null, 25, "Netrawati", null, null, 4, 5 },
                    { 285, null, null, 25, "Benighat Rorang", null, null, 4, 10 },
                    { 286, null, null, 25, "Rubi Valley", null, null, 4, 6 },
                    { 287, null, null, 25, "Sidda Lekh", null, null, 4, 7 },
                    { 288, null, null, 25, "Tripura Sundari", null, null, 4, 7 },
                    { 289, null, null, 26, "Kathmandu", null, null, 1, 32 },
                    { 290, null, null, 26, "Kageshwori Manohara", null, null, 3, 12 },
                    { 291, null, null, 26, "Kirtipur", null, null, 3, 10 },
                    { 292, null, null, 26, "Gokarneswor", null, null, 3, 9 },
                    { 293, null, null, 26, "Chandragiri", null, null, 3, 15 },
                    { 294, null, null, 26, "Tokha", null, null, 3, 11 },
                    { 295, null, null, 26, "Tarkeshwor", null, null, 3, 11 },
                    { 296, null, null, 26, "Dakshinkali", null, null, 3, 9 },
                    { 297, null, null, 26, "Nagarjun", null, null, 3, 10 },
                    { 298, null, null, 26, "Budhanilakantha", null, null, 3, 13 },
                    { 299, null, null, 26, "Sankharapur", null, null, 4, 9 },
                    { 301, null, null, 27, "Bhimeshwor", null, null, 3, 9 },
                    { 324, null, null, 29, "Mahalaxmi", null, null, 3, 10 },
                    { 325, null, null, 29, "Konjyosom", null, null, 4, 5 },
                    { 326, null, null, 29, "Bagmati", null, null, 4, 7 },
                    { 351, null, null, 32, "Ramechhap", null, null, 3, 9 },
                    { 352, null, null, 32, "Umakunda", null, null, 4, 7 },
                    { 353, null, null, 32, "KhandaDevi", null, null, 4, 9 },
                    { 354, null, null, 32, "Gokul Ganga", null, null, 4, 6 },
                    { 355, null, null, 32, "Doramba", null, null, 4, 7 },
                    { 356, null, null, 32, "Likhu", null, null, 4, 7 },
                    { 357, null, null, 32, "Sunapati", null, null, 4, 5 },
                    { 358, null, null, 33, "Uttar Gaya", null, null, 4, 5 },
                    { 359, null, null, 33, "Kalika", null, null, 4, 5 },
                    { 360, null, null, 33, "Gosaikunda", null, null, 4, 6 },
                    { 361, null, null, 33, "Naukunda", null, null, 4, 6 },
                    { 362, null, null, 33, "Parbatikunda", null, null, 4, 5 },
                    { 363, null, null, 34, "Kamalamai", null, null, 3, 14 },
                    { 364, null, null, 34, "Dudhauli", null, null, 3, 14 },
                    { 365, null, null, 34, "Golanjor", null, null, 4, 7 },
                    { 366, null, null, 34, "Ghyanglekh", null, null, 4, 5 },
                    { 368, null, null, 34, "Phikkal", null, null, 4, 6 },
                    { 369, null, null, 34, "Marin", null, null, 4, 8 },
                    { 370, null, null, 34, "Sunkoshi", null, null, 4, 7 },
                    { 350, null, null, 32, "Manthali", null, null, 3, 14 },
                    { 349, null, null, 31, "Surya Gadhi", null, null, 4, 5 },
                    { 348, null, null, 31, "Shivpuri", null, null, 4, 8 },
                    { 347, null, null, 31, "Meghang", null, null, 4, 6 },
                    { 327, null, null, 29, "Mahankal", null, null, 4, 6 },
                    { 328, null, null, 30, "Hetauda", null, null, 2, 19 },
                    { 329, null, null, 30, "Thaha", null, null, 3, 12 },
                    { 330, null, null, 30, "Indra Sarobar", null, null, 4, 5 },
                    { 331, null, null, 30, "Kailash", null, null, 4, 10 },
                    { 332, null, null, 30, "Bakaiya", null, null, 4, 12 },
                    { 333, null, null, 30, "Bagmati", null, null, 4, 9 },
                    { 334, null, null, 30, "Bhimphedi", null, null, 4, 9 },
                    { 335, null, null, 30, "Makawanpur Gadhi", null, null, 4, 8 },
                    { 280, null, null, 25, "Galchi", null, null, 4, 8 },
                    { 336, null, null, 30, "Manahari", null, null, 4, 9 },
                    { 338, null, null, 31, "Bidur", null, null, 3, 13 },
                    { 339, null, null, 31, "Belkot Gadhi", null, null, 3, 13 },
                    { 340, null, null, 31, "Kakani", null, null, 4, 8 },
                    { 341, null, null, 31, "Kispang", null, null, 4, 5 },
                    { 342, null, null, 31, "Tadi", null, null, 4, 6 },
                    { 343, null, null, 31, "Tarkeshwor", null, null, 4, 6 },
                    { 344, null, null, 31, "Dupcheshwor", null, null, 4, 7 },
                    { 345, null, null, 31, "Panchakanya", null, null, 4, 5 },
                    { 346, null, null, 31, "Likhu", null, null, 4, 6 },
                    { 337, null, null, 30, "Raksirang", null, null, 4, 9 },
                    { 279, null, null, 25, "Gajuri", null, null, 4, 8 },
                    { 303, null, null, 27, "Gauri Shankar", null, null, 4, 9 },
                    { 277, null, null, 25, "Nilkantha", null, null, 3, 14 },
                    { 211, null, null, 19, "Bariyarpatti", null, null, 4, 5 },
                    { 212, null, null, 19, "Laxmipur Patari", null, null, 4, 6 },
                    { 213, null, null, 19, "Naraha", null, null, 4, 5 },
                    { 214, null, null, 19, "Sakhuwanankarkatti", null, null, 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "MunVdc",
                columns: new[] { "Id", "DateCreated", "DateModified", "DistrictId", "Name", "UserCreated", "UserModified", "VdcMunType", "WardCount" },
                values: new object[,]
                {
                    { 215, null, null, 19, "Arnama", null, null, 4, 5 },
                    { 216, null, null, 19, "Nawarajpur", null, null, 4, 5 },
                    { 217, null, null, 20, "Janakpur", null, null, 2, 24 },
                    { 218, null, null, 20, "Chhireshwarnath", null, null, 3, 11 },
                    { 219, null, null, 20, "Ganeshman Charnath", null, null, 3, 11 },
                    { 220, null, null, 20, "DhanusaDham", null, null, 3, 9 },
                    { 221, null, null, 20, "Nagaraen", null, null, 3, 10 },
                    { 222, null, null, 20, "Bideh", null, null, 3, 10 },
                    { 223, null, null, 20, "Mithila", null, null, 3, 10 },
                    { 224, null, null, 20, "Shahid Nagar", null, null, 3, 9 },
                    { 225, null, null, 20, "Sabaila", null, null, 3, 13 },
                    { 226, null, null, 20, "Kamala Siddidatri", null, null, 4, 6 },
                    { 227, null, null, 20, "Janak Nandini", null, null, 4, 6 },
                    { 228, null, null, 20, "Bateshwor", null, null, 4, 5 },
                    { 229, null, null, 20, "Mithila Bihari", null, null, 4, 10 },
                    { 210, null, null, 19, "Karjanha", null, null, 4, 7 },
                    { 230, null, null, 20, "Mukhiyapatti Musaharmiya", null, null, 4, 6 },
                    { 209, null, null, 19, "Sukhipur", null, null, 4, 8 },
                    { 278, null, null, 25, "Khaniyabas", null, null, 4, 5 },
                    { 188, null, null, 18, "Nijgadh", null, null, 3, 13 },
                    { 189, null, null, 18, "Maha Gahdimai", null, null, 3, 11 },
                    { 190, null, null, 18, "Simraun Gadh", null, null, 3, 11 },
                    { 191, null, null, 18, "Adarsha Kotwal", null, null, 4, 8 },
                    { 192, null, null, 18, "Karaiya mai", null, null, 4, 8 },
                    { 193, null, null, 18, "Devtaal", null, null, 4, 7 },
                    { 194, null, null, 18, "PachaRouta", null, null, 4, 9 },
                    { 195, null, null, 18, "Parawanipur", null, null, 4, 9 },
                    { 196, null, null, 18, "Prasouni", null, null, 4, 7 },
                    { 197, null, null, 18, "Pheta", null, null, 4, 8 },
                    { 198, null, null, 18, "Bara Gadhi", null, null, 4, 6 },
                    { 199, null, null, 18, "Subarna", null, null, 4, 8 },
                    { 200, null, null, 19, "Lahan", null, null, 3, 24 },
                    { 201, null, null, 19, "Dhanagadhi Mai", null, null, 3, 14 },
                    { 202, null, null, 19, "Siraha", null, null, 3, 22 },
                    { 203, null, null, 19, "GolBazaar", null, null, 3, 13 },
                    { 204, null, null, 19, "Mirchaiya", null, null, 3, 12 },
                    { 205, null, null, 19, "Kalyanpur", null, null, 3, 12 },
                    { 206, null, null, 19, "Bhaganwanpur", null, null, 4, 5 },
                    { 208, null, null, 19, "Bishnupur", null, null, 4, 5 },
                    { 231, null, null, 20, "Laxminiya", null, null, 4, 7 },
                    { 207, null, null, 19, "Aaurahi", null, null, 4, 5 },
                    { 233, null, null, 20, "Aaurahi", null, null, 4, 8 },
                    { 258, null, null, 22, "Mahottari", null, null, 4, 6 },
                    { 259, null, null, 22, "Manara", null, null, 4, 8 },
                    { 260, null, null, 22, "Matihani", null, null, 4, 6 },
                    { 261, null, null, 22, "Bhangaha", null, null, 4, 9 },
                    { 262, null, null, 22, "Balawa", null, null, 4, 7 },
                    { 263, null, null, 22, "Pipara", null, null, 4, 7 },
                    { 264, null, null, 22, "Aaurahi", null, null, 4, 7 },
                    { 265, null, null, 23, "Changunarayan", null, null, 3, 9 },
                    { 266, null, null, 23, "Bhaktapur", null, null, 3, 10 },
                    { 267, null, null, 23, "Madhyapur", null, null, 3, 9 },
                    { 268, null, null, 23, "Surya Binayak", null, null, 3, 10 },
                    { 269, null, null, 24, "Bharatpur", null, null, 1, 29 },
                    { 270, null, null, 24, "Kalika", null, null, 3, 11 },
                    { 271, null, null, 24, "Khairhani", null, null, 3, 13 },
                    { 272, null, null, 24, "Madi", null, null, 3, 9 },
                    { 273, null, null, 24, "Ratna Nagar", null, null, 3, 16 },
                    { 274, null, null, 24, "Rapti", null, null, 3, 13 },
                    { 275, null, null, 24, "Ichchhakamana", null, null, 4, 7 },
                    { 276, null, null, 25, "Dhunibesi", null, null, 3, 9 },
                    { 232, null, null, 20, "Hanspur", null, null, 4, 8 },
                    { 256, null, null, 22, "Loharpatti", null, null, 4, 8 },
                    { 257, null, null, 22, "RamGopalpur", null, null, 4, 6 },
                    { 254, null, null, 22, "Sonama", null, null, 4, 8 },
                    { 234, null, null, 21, "Chandrapur", null, null, 3, 10 },
                    { 235, null, null, 21, "Garuda", null, null, 3, 9 },
                    { 236, null, null, 21, "Gaur", null, null, 3, 13 },
                    { 237, null, null, 21, "BoudhiMai", null, null, 4, 7 },
                    { 238, null, null, 21, "Brindaban", null, null, 4, 8 },
                    { 239, null, null, 21, "Devahi Gonahi", null, null, 4, 7 },
                    { 240, null, null, 21, "Durga Bhagawati", null, null, 4, 8 },
                    { 241, null, null, 21, "GadhiMai", null, null, 4, 7 },
                    { 255, null, null, 22, "Samsi", null, null, 4, 7 },
                    { 243, null, null, 21, "Katahariya", null, null, 4, 9 },
                    { 242, null, null, 21, "Gujara", null, null, 4, 9 },
                    { 245, null, null, 21, "Moulapur", null, null, 4, 7 },
                    { 246, null, null, 21, "Phatuwa Bijayapur", null, null, 4, 5 },
                    { 247, null, null, 21, "IshNath", null, null, 4, 9 },
                    { 248, null, null, 21, "Paroha", null, null, 4, 8 },
                    { 249, null, null, 21, "Rajpur", null, null, 4, 7 },
                    { 250, null, null, 22, "Jaleshwor", null, null, 3, 12 },
                    { 251, null, null, 22, "Bardibas", null, null, 3, 13 },
                    { 252, null, null, 22, "Gaushala", null, null, 3, 12 },
                    { 253, null, null, 22, "Ekadara", null, null, 4, 8 },
                    { 244, null, null, 21, "Madhav Narayan", null, null, 4, 9 }
                });

            migrationBuilder.InsertData(
                table: "Occupation",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 9, null, null, "Personal Industry", null, null },
                    { 8, null, null, "Non-Government Service", null, null },
                    { 7, null, null, "Student", null, null },
                    { 6, null, null, "Unemployed", null, null },
                    { 3, null, null, "Trade", null, null },
                    { 4, null, null, "Pension", null, null },
                    { 2, null, null, "Government School/Office", null, null },
                    { 1, null, null, "Agriculture", null, null },
                    { 5, null, null, "Daily Wages", null, null }
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 7, null, null, "Sudurpashchim Pradesh", null, null },
                    { 6, null, null, "Karnali Pradesh", null, null },
                    { 4, null, null, "Gandaki Pradesh", null, null },
                    { 5, null, null, "Province No. 5", null, null },
                    { 2, null, null, "Province No. 2", null, null },
                    { 1, null, null, "Province No. 1", null, null },
                    { 3, null, null, "Province No. 3", null, null }
                });

            migrationBuilder.InsertData(
                table: "Relation",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 9, null, null, "Sister - In - Law / Brother", null, null },
                    { 13, null, null, "Relatives", null, null },
                    { 14, null, null, "No Relation", null, null },
                    { 11, null, null, "Married Daughter", null, null },
                    { 10, null, null, "Father & Mother - In - Law", null, null },
                    { 8, null, null, "Brotehr & Son - In - Law", null, null },
                    { 12, null, null, "Brother - In - Law / Sister / Sister - In - Law", null, null },
                    { 6, null, null, "Brother/Sister", null, null },
                    { 5, null, null, "Father/Mother", null, null },
                    { 4, null, null, "Grand Daughter/Son", null, null },
                    { 3, null, null, "Son/Daughter", null, null },
                    { 2, null, null, "Wife/Husband", null, null },
                    { 1, null, null, "House Hold Head", null, null },
                    { 7, null, null, "Daughter & Son - In - Law / Son & Daughter - In - Law", null, null }
                });

            migrationBuilder.InsertData(
                table: "Religion",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, null, null, "Hindu", null, null },
                    { 2, null, null, "Buddhist", null, null },
                    { 3, null, null, "Islam", null, null },
                    { 4, null, null, "Kirat", null, null },
                    { 5, null, null, "Christian", null, null },
                    { 6, null, null, "Other", null, null }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 2, new DateTime(2019, 7, 9, 12, 42, 5, 176, DateTimeKind.Local).AddTicks(2002), new DateTime(2019, 7, 9, 12, 42, 5, 176, DateTimeKind.Local).AddTicks(2012), "Operator", "Admin", "Admin" },
                    { 1, new DateTime(2019, 7, 9, 12, 42, 5, 173, DateTimeKind.Local).AddTicks(2300), new DateTime(2019, 7, 9, 12, 42, 5, 176, DateTimeKind.Local).AddTicks(754), "Admin", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, null, null, "Swening", null, null },
                    { 2, null, null, "Handicraft", null, null },
                    { 3, null, null, "Carpentry", null, null },
                    { 4, null, null, "Mason", null, null },
                    { 5, null, null, "Computer Training", null, null },
                    { 6, null, null, "ZTA", null, null },
                    { 7, null, null, "Cook/Waiter", null, null },
                    { 8, null, null, "Beauty Palour", null, null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "Password", "PersonId", "RoleId", "UserCreated", "UserModified", "Username" },
                values: new object[] { 1, null, null, "Admin", "th6V8/FO5mRXksxvBhm0gg==", null, 1, null, null, "admin" });

            migrationBuilder.InsertData(
                table: "WorkType",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, null, null, "Permanent", null, null },
                    { 2, null, null, "Temporary", null, null },
                    { 3, null, null, "Contract", null, null }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "ProvinceId", "UserCreated", "UserModified" },
                values: new object[,]
                {
                    { 1, null, null, "Bhojpur District", 1, null, null },
                    { 55, null, null, "Palpa District", 5, null, null },
                    { 54, null, null, "Parasi District", 5, null, null },
                    { 53, null, null, "Kapilvastu District", 5, null, null },
                    { 52, null, null, "Gulmi District", 5, null, null },
                    { 51, null, null, "Eastern Rukum District", 5, null, null },
                    { 50, null, null, "Dang District", 5, null, null },
                    { 49, null, null, "Bardiya District", 5, null, null },
                    { 48, null, null, "Banke District", 5, null, null },
                    { 47, null, null, "Arghakhanchi District", 5, null, null },
                    { 46, null, null, "Tanahun District", 4, null, null },
                    { 45, null, null, "Syangja District", 4, null, null },
                    { 44, null, null, "Parbat District", 4, null, null },
                    { 43, null, null, "Nawalpur District", 4, null, null },
                    { 42, null, null, "Myagdi District", 4, null, null },
                    { 41, null, null, "Mustang District", 4, null, null },
                    { 56, null, null, "Pyuthan District", 5, null, null },
                    { 57, null, null, "Rolpa District", 5, null, null },
                    { 58, null, null, "Rupandehi District", 5, null, null },
                    { 59, null, null, "Dailekh District", 6, null, null },
                    { 75, null, null, "Doti District", 7, null, null },
                    { 74, null, null, "Darchula District", 7, null, null },
                    { 73, null, null, "Dadeldhura District", 7, null, null },
                    { 72, null, null, "Bajura District", 7, null, null },
                    { 71, null, null, "Bajhang District", 7, null, null },
                    { 70, null, null, "Baitadi District", 7, null, null },
                    { 69, null, null, "Achham District", 7, null, null },
                    { 40, null, null, "Manang District", 4, null, null },
                    { 68, null, null, "Western Rukum District", 6, null, null },
                    { 66, null, null, "Salyan District", 6, null, null },
                    { 65, null, null, "Mugu District", 6, null, null },
                    { 64, null, null, "Kalikot District", 6, null, null },
                    { 63, null, null, "Jumla District", 6, null, null },
                    { 62, null, null, "Jajarkot District", 6, null, null },
                    { 61, null, null, "Humla District", 6, null, null },
                    { 60, null, null, "Dolpa District", 6, null, null },
                    { 67, null, null, "Surkhet District", 6, null, null },
                    { 76, null, null, "Kailali District", 7, null, null },
                    { 39, null, null, "Lamjung District", 4, null, null },
                    { 37, null, null, "Gorkha District", 4, null, null },
                    { 16, null, null, "Parsa District", 2, null, null },
                    { 15, null, null, "Saptari District", 2, null, null },
                    { 14, null, null, "Udayapur District", 1, null, null },
                    { 13, null, null, "Terhathum District", 1, null, null },
                    { 12, null, null, "Taplejung District", 1, null, null },
                    { 11, null, null, "Sunsari District", 1, null, null },
                    { 10, null, null, "Solukhumbu District", 1, null, null },
                    { 9, null, null, "Sankhuwasabha District", 1, null, null },
                    { 8, null, null, "Panchthar District", 1, null, null },
                    { 7, null, null, "	Okhaldhunga District", 1, null, null },
                    { 6, null, null, "Morang District", 1, null, null },
                    { 5, null, null, "Khotang District", 1, null, null },
                    { 4, null, null, "Jhapa District", 1, null, null },
                    { 3, null, null, "Ilam District", 1, null, null },
                    { 2, null, null, "Dhankuta District", 1, null, null },
                    { 17, null, null, "Sarlahi District", 2, null, null },
                    { 18, null, null, "Bara District", 2, null, null },
                    { 19, null, null, "Siraha District", 2, null, null },
                    { 20, null, null, "Dhanusa District", 2, null, null },
                    { 36, null, null, "Baglung District", 4, null, null },
                    { 35, null, null, "Sindhupalchok District", 3, null, null },
                    { 34, null, null, "Sindhuli District", 3, null, null },
                    { 33, null, null, "Rasuwa District", 3, null, null },
                    { 32, null, null, "Ramechhap District", 3, null, null },
                    { 31, null, null, "Nuwakot District", 3, null, null },
                    { 30, null, null, "Makwanpur District", 3, null, null },
                    { 38, null, null, "Kaski District", 4, null, null },
                    { 29, null, null, "Lalitpur District", 3, null, null },
                    { 27, null, null, "Kathmandu District", 3, null, null },
                    { 26, null, null, "Dolakha District", 3, null, null },
                    { 25, null, null, "Dhading District", 3, null, null },
                    { 24, null, null, "Chitwan District", 3, null, null },
                    { 23, null, null, "Bhaktapur District", 3, null, null },
                    { 22, null, null, "Mahottari District", 2, null, null },
                    { 21, null, null, "Rautahat District", 2, null, null },
                    { 28, null, null, "Kavrepalanchok District", 3, null, null },
                    { 77, null, null, "Kanchanpur District", 7, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_AddressTypeId",
                table: "Address",
                column: "AddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CountryId",
                table: "Address",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_DistrictId",
                table: "Address",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_MunVdcId",
                table: "Address",
                column: "MunVdcId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_ProvinceId",
                table: "Address",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_OfficeId",
                table: "Department",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_District_ProvinceId",
                table: "District",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeJobId",
                table: "Employee",
                column: "EmployeeJobId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ManagerId",
                table: "Employee",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_NomineeId",
                table: "Employee",
                column: "NomineeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PersonId",
                table: "Employee",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDependent_EmployeeId",
                table: "EmployeeDependent",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDependent_PersonId",
                table: "EmployeeDependent",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Approver");

            migrationBuilder.DropTable(
                name: "CarbonCopyer");

            migrationBuilder.DropTable(
                name: "Cast");

            migrationBuilder.DropTable(
                name: "DayType");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "DocumentRecord");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "EduInstutionType");

            migrationBuilder.DropTable(
                name: "EmployeeDependent");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "HealthStatus");

            migrationBuilder.DropTable(
                name: "Holiday");

            migrationBuilder.DropTable(
                name: "IdentityType");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Leave");

            migrationBuilder.DropTable(
                name: "LeaveType");

            migrationBuilder.DropTable(
                name: "Level");

            migrationBuilder.DropTable(
                name: "Litracy");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "Occupation");

            migrationBuilder.DropTable(
                name: "OfficeDepartment");

            migrationBuilder.DropTable(
                name: "PayGrade");

            migrationBuilder.DropTable(
                name: "PersonEducation");

            migrationBuilder.DropTable(
                name: "PersonLanguage");

            migrationBuilder.DropTable(
                name: "PersonSkill");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "PostCategory");

            migrationBuilder.DropTable(
                name: "Relation");

            migrationBuilder.DropTable(
                name: "Religion");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "WorkType");

            migrationBuilder.DropTable(
                name: "AddressType");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "MunVdc");

            migrationBuilder.DropTable(
                name: "Office");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "EmployeeJob");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
