using Microsoft.EntityFrameworkCore;
using CloudHR.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace CloudHR.Data
{
    public class ApplicationDbContext:DbContext//IdentityDbContext<ApplicationUser>
    {
        private IServiceProvider _services;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IServiceProvider services) :base(options)
        {
            _services = services;
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Role>().ToTable("Role").HasData(new Role {Id=1, Name="Admin", DateCreated=DateTime.Now, UserCreated="Admin", DateModified=DateTime.Now, UserModified="Admin" }, new Role { Id = 2, Name = "Operator", DateCreated = DateTime.Now, UserCreated = "Admin", DateModified = DateTime.Now, UserModified = "Admin" });
            builder.Entity<User>().ToTable("User").HasData(new User {Id=1, Name="Admin", RoleId=1, Username="admin", Password= "th6V8/FO5mRXksxvBhm0gg==" });
            
            builder.Entity<Country>().ToTable("Country").HasData(new Country { Code="NP",Name= "Nepal", Id=1 },
                                                                             new Country { Code = "IN", Name = "India", Id=2 },
                                                                             new Country { Code = "US", Name = "United States", Id=3},
                                                                             new Country { Code = "CA", Name = "Canada", Id=4},
                                                                             new Country { Code = "GB", Name = "United Kingdom", Id=5});
            builder.Entity<Province>().ToTable("Province").HasData(new Province {Id=1, Name= "Province No. 1" }, 
                                                                    new Province { Id = 2, Name = "Province No. 2" },
                                                                    new Province { Id = 3, Name = "Province No. 3" },
                                                                    new Province { Id = 4, Name = "Gandaki Pradesh" },
                                                                    new Province { Id = 5, Name = "Province No. 5" },
                                                                    new Province { Id = 6, Name = "Karnali Pradesh" },
                                                                    new Province { Id = 7, Name = "Sudurpashchim Pradesh" });
            builder.Entity<District>().ToTable("District").HasData(new District { Id = 1, Name = "Bhojpur District", ProvinceId = 1 },
                                                                    new District { Id = 2, Name = "Dhankuta District", ProvinceId = 1 },
                                                                    new District { Id = 3, Name = "Ilam District", ProvinceId = 1 },
                                                                    new District { Id = 4, Name = "Jhapa District", ProvinceId = 1 },
                                                                    new District { Id = 5, Name = "Khotang District", ProvinceId = 1 },
                                                                    new District { Id = 6, Name = "Morang District", ProvinceId = 1 },
                                                                    new District { Id = 7, Name = "	Okhaldhunga District", ProvinceId = 1 },
                                                                    new District { Id = 8, Name = "Panchthar District", ProvinceId = 1 },
                                                                    new District { Id = 9, Name = "Sankhuwasabha District", ProvinceId = 1 },
                                                                    new District { Id = 10, Name = "Solukhumbu District", ProvinceId = 1 },
                                                                    new District { Id = 11, Name = "Sunsari District", ProvinceId = 1 },
                                                                    new District { Id = 12, Name = "Taplejung District", ProvinceId = 1 },
                                                                    new District { Id = 13, Name = "Terhathum District", ProvinceId = 1 },
                                                                    new District { Id = 14, Name = "Udayapur District", ProvinceId = 1 },
                                                                    new District { Id = 15, Name = "Saptari District", ProvinceId = 2 },
                                                                    new District { Id = 16, Name = "Parsa District", ProvinceId = 2 },
                                                                    new District { Id = 17, Name = "Sarlahi District", ProvinceId = 2 },
                                                                    new District { Id = 18, Name = "Bara District", ProvinceId = 2 },
                                                                    new District { Id = 19, Name = "Siraha District", ProvinceId = 2 },
                                                                    new District { Id = 20, Name = "Dhanusa District", ProvinceId = 2 },
                                                                    new District { Id = 21, Name = "Rautahat District", ProvinceId = 2 },
                                                                    new District { Id = 22, Name = "Mahottari District", ProvinceId = 2 },
                                                                    new District { Id = 23, Name = "Bhaktapur District", ProvinceId = 3 },
                                                                    new District { Id = 24, Name = "Chitwan District", ProvinceId = 3 },
                                                                    new District { Id = 25, Name = "Dhading District", ProvinceId = 3 },
                                                                    new District { Id = 26, Name = "Dolakha District", ProvinceId = 3 },
                                                                    new District { Id = 27, Name = "Kathmandu District", ProvinceId = 3 },
                                                                    new District { Id = 28, Name = "Kavrepalanchok District", ProvinceId = 3 },
                                                                    new District { Id = 29, Name = "Lalitpur District", ProvinceId = 3 },
                                                                    new District { Id = 30, Name = "Makwanpur District", ProvinceId = 3 },
                                                                    new District { Id = 31, Name = "Nuwakot District", ProvinceId = 3 },
                                                                    new District { Id = 32, Name = "Ramechhap District", ProvinceId = 3 },
                                                                    new District { Id = 33, Name = "Rasuwa District", ProvinceId = 3 },
                                                                    new District { Id = 34, Name = "Sindhuli District", ProvinceId = 3 },
                                                                    new District { Id = 35, Name = "Sindhupalchok District", ProvinceId = 3 },
                                                                    new District { Id = 36, Name = "Baglung District", ProvinceId = 4 },
                                                                    new District { Id = 37, Name = "Gorkha District", ProvinceId = 4 },
                                                                    new District { Id = 38, Name = "Kaski District", ProvinceId = 4 },
                                                                    new District { Id = 39, Name = "Lamjung District", ProvinceId = 4 },
                                                                    new District { Id = 40, Name = "Manang District", ProvinceId = 4 },
                                                                    new District { Id = 41, Name = "Mustang District", ProvinceId = 4 },
                                                                    new District { Id = 42, Name = "Myagdi District", ProvinceId = 4 },
                                                                    new District { Id = 43, Name = "Nawalpur District", ProvinceId = 4 },
                                                                    new District { Id = 44, Name = "Parbat District", ProvinceId = 4 },
                                                                    new District { Id = 45, Name = "Syangja District", ProvinceId = 4 },
                                                                    new District { Id = 46, Name = "Tanahun District", ProvinceId = 4 },
                                                                    new District { Id = 47, Name = "Arghakhanchi District", ProvinceId = 5 },
                                                                    new District { Id = 48, Name = "Banke District", ProvinceId = 5 },
                                                                    new District { Id = 49, Name = "Bardiya District", ProvinceId = 5 },
                                                                    new District { Id = 50, Name = "Dang District", ProvinceId = 5 },
                                                                    new District { Id = 51, Name = "Eastern Rukum District", ProvinceId = 5 },
                                                                    new District { Id = 52, Name = "Gulmi District", ProvinceId = 5 },
                                                                    new District { Id = 53, Name = "Kapilvastu District", ProvinceId = 5 },
                                                                    new District { Id = 54, Name = "Parasi District", ProvinceId = 5 },
                                                                    new District { Id = 55, Name = "Palpa District", ProvinceId = 5 },
                                                                    new District { Id = 56, Name = "Pyuthan District", ProvinceId = 5 },
                                                                    new District { Id = 57, Name = "Rolpa District", ProvinceId = 5 },
                                                                    new District { Id = 58, Name = "Rupandehi District", ProvinceId = 5 },
                                                                    new District { Id = 59, Name = "Dailekh District", ProvinceId = 6 },
                                                                    new District { Id = 60, Name = "Dolpa District", ProvinceId = 6 },
                                                                    new District { Id = 61, Name = "Humla District", ProvinceId = 6 },
                                                                    new District { Id = 62, Name = "Jajarkot District", ProvinceId = 6 },
                                                                    new District { Id = 63, Name = "Jumla District", ProvinceId = 6 },
                                                                    new District { Id = 64, Name = "Kalikot District", ProvinceId = 6 },
                                                                    new District { Id = 65, Name = "Mugu District", ProvinceId = 6 },
                                                                    new District { Id = 66, Name = "Salyan District", ProvinceId = 6 },
                                                                    new District { Id = 67, Name = "Surkhet District", ProvinceId = 6 },
                                                                    new District { Id = 68, Name = "Western Rukum District", ProvinceId = 6 },
                                                                    new District { Id = 69, Name = "Achham District", ProvinceId = 7 },
                                                                    new District { Id = 70, Name = "Baitadi District", ProvinceId = 7 },
                                                                    new District { Id = 71, Name = "Bajhang District", ProvinceId = 7 },
                                                                    new District { Id = 72, Name = "Bajura District", ProvinceId = 7 },
                                                                    new District { Id = 73, Name = "Dadeldhura District", ProvinceId = 7 },
                                                                    new District { Id = 74, Name = "Darchula District", ProvinceId = 7 },
                                                                    new District { Id = 75, Name = "Doti District", ProvinceId = 7 },
                                                                    new District { Id = 76, Name = "Kailali District", ProvinceId = 7 },
                                                                    new District { Id = 77, Name = "Kanchanpur District", ProvinceId = 7 });
            builder.Entity<MunVdc>().ToTable("MunVdc").HasData(new MunVdc { Id = 1, DistrictId = 1, VdcMunType = 3, Name = "Bhojpur", WardCount = 12 },
                                                                new MunVdc { Id = 2, DistrictId = 1, VdcMunType = 3, Name = "Shadanand", WardCount = 14 },
                                                                 new MunVdc { Id = 3, DistrictId = 1, VdcMunType = 4, Name = "Hatuwagadhi", WardCount = 9 },
                                                                 new MunVdc { Id = 4, DistrictId = 1, VdcMunType = 4, Name = "Ramprasad Rai", WardCount = 8 },
                                                                 new MunVdc { Id = 5, DistrictId = 1, VdcMunType = 4, Name = "Aamchok", WardCount = 10 },
                                                                 new MunVdc { Id = 6, DistrictId = 1, VdcMunType = 4, Name = "Tyamke Maiyunm", WardCount = 9 },
                                                                 new MunVdc { Id = 7, DistrictId = 1, VdcMunType = 4, Name = "Arun Gaunpalika", WardCount = 7 },
                                                                 new MunVdc { Id = 8, DistrictId = 1, VdcMunType = 4, Name = "Pauwadungma", WardCount = 6 },
                                                                 new MunVdc { Id = 9, DistrictId = 1, VdcMunType = 4, Name = "Salpasilichho", WardCount = 6 },


                                                                 new MunVdc { Id = 10, DistrictId = 2, VdcMunType = 3, Name = "Dhankuta", WardCount = 10 },
                                                                new MunVdc { Id = 11, DistrictId = 2, VdcMunType = 3, Name = "Pakhribas", WardCount = 10 },
                                                                 new MunVdc { Id = 12, DistrictId = 2, VdcMunType = 3, Name = "Mahalaxmi", WardCount = 9 },
                                                                 new MunVdc { Id = 13, DistrictId = 2, VdcMunType = 4, Name = "Sangurigadhi", WardCount = 10 },
                                                                 new MunVdc { Id = 14, DistrictId = 2, VdcMunType = 4, Name = "Chaubise", WardCount = 8 },
                                                                 new MunVdc { Id = 15, DistrictId = 2, VdcMunType = 4, Name = "Khalsa Chhintang Sahidbhumi", WardCount = 7 },
                                                                 new MunVdc { Id = 16, DistrictId = 2, VdcMunType = 4, Name = "Chhathar Jorpati", WardCount = 6 },

                                                                 new MunVdc { Id = 17, DistrictId = 3, VdcMunType = 3, Name = "Ilam", WardCount = 12 },
                                                                 new MunVdc { Id = 18, DistrictId = 3, VdcMunType = 3, Name = "Deumai", WardCount = 9 },
                                                                 new MunVdc { Id = 19, DistrictId = 3, VdcMunType = 3, Name = "Mai Municipality", WardCount = 10 },
                                                                 new MunVdc { Id = 20, DistrictId = 3, VdcMunType = 3, Name = "Suryodaya", WardCount = 14 },
                                                                 new MunVdc { Id = 21, DistrictId = 3, VdcMunType = 4, Name = "Phakphokthum", WardCount = 7 },
                                                                 new MunVdc { Id = 22, DistrictId = 3, VdcMunType = 4, Name = "Mai Jogmai", WardCount = 6 },
                                                                 new MunVdc { Id = 23, DistrictId = 3, VdcMunType = 4, Name = "Chulachuli", WardCount = 6 },
                                                                 new MunVdc { Id = 24, DistrictId = 3, VdcMunType = 4, Name = "Rong", WardCount = 6 },
                                                                 new MunVdc { Id = 25, DistrictId = 3, VdcMunType = 4, Name = "Mangsebung", WardCount = 6 },
                                                                 new MunVdc { Id = 26, DistrictId = 3, VdcMunType = 4, Name = "Sandakpur", WardCount = 5 },

                                                                 new MunVdc { Id = 27, DistrictId = 4, VdcMunType = 3, Name = "MechiNagar", WardCount = 15 },
                                                                 new MunVdc { Id = 28, DistrictId = 4, VdcMunType = 3, Name = "Damak", WardCount = 10 },
                                                                 new MunVdc { Id = 29, DistrictId = 4, VdcMunType = 3, Name = "Kankai", WardCount = 9 },
                                                                 new MunVdc { Id = 30, DistrictId = 4, VdcMunType = 3, Name = "Bhadrapur", WardCount = 10 },
                                                                 new MunVdc { Id = 31, DistrictId = 4, VdcMunType = 3, Name = "Arjundhara", WardCount = 11 },
                                                                 new MunVdc { Id = 32, DistrictId = 4, VdcMunType = 3, Name = "ShivaSataxi", WardCount = 11 },
                                                                 new MunVdc { Id = 33, DistrictId = 4, VdcMunType = 3, Name = "Gauradaha", WardCount = 9 },
                                                                 new MunVdc { Id = 34, DistrictId = 4, VdcMunType = 3, Name = "Birtamod", WardCount = 10 },
                                                                 new MunVdc { Id = 35, DistrictId = 4, VdcMunType = 4, Name = "Kamal", WardCount = 7 },
                                                                 new MunVdc { Id = 36, DistrictId = 4, VdcMunType = 4, Name = "Gaurigunj", WardCount = 6 },
                                                                 new MunVdc { Id = 37, DistrictId = 4, VdcMunType = 4, Name = "Barhadashi", WardCount = 7 },
                                                                 new MunVdc { Id = 38, DistrictId = 4, VdcMunType = 4, Name = "Jhapa", WardCount = 7 },
                                                                 new MunVdc { Id = 39, DistrictId = 4, VdcMunType = 4, Name = "BuddaShanti", WardCount = 7 },
                                                                 new MunVdc { Id = 40, DistrictId = 4, VdcMunType = 4, Name = "Haldibari", WardCount = 5 },
                                                                 new MunVdc { Id = 41, DistrictId = 4, VdcMunType = 4, Name = "Kanchankawal", WardCount = 7 },

                                                                 new MunVdc { Id = 42, DistrictId = 5, VdcMunType = 3, Name = "Rupakot Majhuwagadhi", WardCount = 15 },
                                                                 new MunVdc { Id = 43, DistrictId = 5, VdcMunType = 3, Name = "Halesi Tuwachung", WardCount = 11 },
                                                                 new MunVdc { Id = 44, DistrictId = 5, VdcMunType = 4, Name = "Khotehang", WardCount = 9 },
                                                                 new MunVdc { Id = 45, DistrictId = 5, VdcMunType = 4, Name = "Diprung", WardCount = 7 },
                                                                 new MunVdc { Id = 46, DistrictId = 5, VdcMunType = 4, Name = "Aiselukharka", WardCount = 7 },
                                                                 new MunVdc { Id = 47, DistrictId = 5, VdcMunType = 4, Name = "Jantedhunga", WardCount = 6 },
                                                                 new MunVdc { Id = 48, DistrictId = 5, VdcMunType = 4, Name = "Kepilasgadhi", WardCount = 7 },
                                                                 new MunVdc { Id = 49, DistrictId = 5, VdcMunType = 4, Name = "Barahapokhari", WardCount = 6 },
                                                                 new MunVdc { Id = 50, DistrictId = 5, VdcMunType = 4, Name = "Lamidanda ", WardCount = 6 },
                                                                 new MunVdc { Id = 51, DistrictId = 5, VdcMunType = 4, Name = "Sakela", WardCount = 5 },

                                                                 new MunVdc { Id = 52, DistrictId = 6, VdcMunType = 1, Name = "Biratnagar", WardCount = 19 },
                                                                 new MunVdc { Id = 53, DistrictId = 6, VdcMunType = 3, Name = "SundarHaraincha", WardCount = 12 },
                                                                 new MunVdc { Id = 54, DistrictId = 6, VdcMunType = 3, Name = "Belbari", WardCount = 11 },
                                                                 new MunVdc { Id = 55, DistrictId = 6, VdcMunType = 3, Name = "Pathari-Sanishchare", WardCount = 10 },
                                                                 new MunVdc { Id = 56, DistrictId = 6, VdcMunType = 3, Name = "Urlabari", WardCount = 9 },
                                                                 new MunVdc { Id = 57, DistrictId = 6, VdcMunType = 3, Name = "Rangeli", WardCount = 9 },
                                                                 new MunVdc { Id = 58, DistrictId = 6, VdcMunType = 3, Name = "Letang Bhogateni", WardCount = 9 },
                                                                 new MunVdc { Id = 59, DistrictId = 6, VdcMunType = 3, Name = "Ratuwamai", WardCount = 10 },
                                                                 new MunVdc { Id = 60, DistrictId = 6, VdcMunType = 3, Name = "Sunbarshi", WardCount = 9 },
                                                                 new MunVdc { Id = 61, DistrictId = 6, VdcMunType = 4, Name = "Kerabari", WardCount = 10 },
                                                                 new MunVdc { Id = 62, DistrictId = 6, VdcMunType = 4, Name = "Miklajung", WardCount = 9 },
                                                                 new MunVdc { Id = 63, DistrictId = 6, VdcMunType = 4, Name = "Kanepokhari", WardCount = 7 },
                                                                 new MunVdc { Id = 64, DistrictId = 6, VdcMunType = 4, Name = "BudhiGanga", WardCount = 7 },
                                                                 new MunVdc { Id = 65, DistrictId = 6, VdcMunType = 4, Name = "Gramthan", WardCount = 7 },
                                                                 new MunVdc { Id = 66, DistrictId = 6, VdcMunType = 4, Name = "Katahari", WardCount = 7 },
                                                                 new MunVdc { Id = 67, DistrictId = 6, VdcMunType = 4, Name = "Dhanpalthan", WardCount = 7 },
                                                                 new MunVdc { Id = 68, DistrictId = 6, VdcMunType = 4, Name = "Jahada", WardCount = 7 },

                                                                 new MunVdc { Id = 69, DistrictId = 7, VdcMunType = 3, Name = "SiddiCharan", WardCount = 12 },
                                                                 new MunVdc { Id = 70, DistrictId = 7, VdcMunType = 4, Name = "Khiji Demba", WardCount = 9 },
                                                                 new MunVdc { Id = 71, DistrictId = 7, VdcMunType = 3, Name = "Champadevi", WardCount = 10 },
                                                                 new MunVdc { Id = 72, DistrictId = 7, VdcMunType = 4, Name = "ChishankhuGadhi", WardCount = 8 },
                                                                 new MunVdc { Id = 73, DistrictId = 7, VdcMunType = 4, Name = "ManeBhanjyang", WardCount = 9 },
                                                                 new MunVdc { Id = 74, DistrictId = 7, VdcMunType = 4, Name = "Molung", WardCount = 8 },
                                                                 new MunVdc { Id = 75, DistrictId = 7, VdcMunType = 4, Name = "Likhu", WardCount = 9 },
                                                                 new MunVdc { Id = 76, DistrictId = 7, VdcMunType = 4, Name = "Sunkoshi", WardCount = 10 },


                                                                 new MunVdc { Id = 77, DistrictId = 8, VdcMunType = 3, Name = "Phidim", WardCount = 14 },
                                                                 new MunVdc { Id = 78, DistrictId = 8, VdcMunType = 4, Name = "Phalelung", WardCount = 8 },
                                                                 new MunVdc { Id = 79, DistrictId = 8, VdcMunType = 4, Name = "Palgunanda", WardCount = 7 },
                                                                 new MunVdc { Id = 80, DistrictId = 8, VdcMunType = 4, Name = "Hilihang", WardCount = 7 },
                                                                 new MunVdc { Id = 81, DistrictId = 8, VdcMunType = 4, Name = "Kummayak", WardCount = 5 },
                                                                 new MunVdc { Id = 82, DistrictId = 8, VdcMunType = 3, Name = "Miklajung", WardCount = 8 },
                                                                 new MunVdc { Id = 83, DistrictId = 8, VdcMunType = 4, Name = "Tumbewa", WardCount = 5 },
                                                                 new MunVdc { Id = 84, DistrictId = 8, VdcMunType = 4, Name = "Yangbarak", WardCount = 6 },

                                                                 new MunVdc { Id = 85, DistrictId = 9, VdcMunType = 3, Name = "Chainpur", WardCount = 11 },
                                                                 new MunVdc { Id = 86, DistrictId = 9, VdcMunType = 4, Name = "DharmaDevi", WardCount = 9 },
                                                                 new MunVdc { Id = 87, DistrictId = 9, VdcMunType = 4, Name = "Khadbari", WardCount = 11 },
                                                                 new MunVdc { Id = 88, DistrictId = 9, VdcMunType = 4, Name = "Madi", WardCount = 9 },
                                                                 new MunVdc { Id = 89, DistrictId = 9, VdcMunType = 4, Name = "PanchKhapan", WardCount = 9 },
                                                                 new MunVdc { Id = 90, DistrictId = 9, VdcMunType = 3, Name = "Bhot Khola", WardCount = 5 },
                                                                 new MunVdc { Id = 91, DistrictId = 9, VdcMunType = 4, Name = "Chichila", WardCount = 5 },
                                                                 new MunVdc { Id = 92, DistrictId = 9, VdcMunType = 4, Name = "Makalu", WardCount = 6 },
                                                                 new MunVdc { Id = 93, DistrictId = 9, VdcMunType = 4, Name = "Sabhapokhari", WardCount = 6 },
                                                                 new MunVdc { Id = 94, DistrictId = 9, VdcMunType = 4, Name = "Silingchong", WardCount = 5 },

                                                                 new MunVdc { Id = 95, DistrictId = 10, VdcMunType = 3, Name = "SoluDudhakund", WardCount = 10 },
                                                                 new MunVdc { Id = 96, DistrictId = 10, VdcMunType = 4, Name = "Dudhakoshi", WardCount = 7 },
                                                                 new MunVdc { Id = 97, DistrictId = 10, VdcMunType = 4, Name = "Khumbu PasangLhamu", WardCount = 5 },
                                                                 new MunVdc { Id = 98, DistrictId = 10, VdcMunType = 4, Name = "Dudhakaushika", WardCount = 9 },
                                                                 new MunVdc { Id = 99, DistrictId = 10, VdcMunType = 4, Name = "Necha Salyan", WardCount = 6 },
                                                                 new MunVdc { Id = 100, DistrictId = 10, VdcMunType = 4, Name = "Maha Kulung", WardCount = 5 },
                                                                 new MunVdc { Id = 101, DistrictId = 10, VdcMunType = 4, Name = "Likhu Pike", WardCount = 5 },
                                                                 new MunVdc { Id = 102, DistrictId = 10, VdcMunType = 4, Name = "Sotang", WardCount = 5 },

                                                                 new MunVdc { Id = 103, DistrictId = 11, VdcMunType = 2, Name = "Itahari", WardCount = 20 },
                                                                 new MunVdc { Id = 104, DistrictId = 11, VdcMunType = 2, Name = "Dharan", WardCount = 20 },
                                                                 new MunVdc { Id = 105, DistrictId = 11, VdcMunType = 3, Name = "Inaruwa", WardCount = 10 },
                                                                 new MunVdc { Id = 106, DistrictId = 11, VdcMunType = 3, Name = "Duhabi", WardCount = 12 },
                                                                 new MunVdc { Id = 107, DistrictId = 11, VdcMunType = 3, Name = "Ramdhuni", WardCount = 9 },
                                                                 new MunVdc { Id = 108, DistrictId = 11, VdcMunType = 3, Name = "Baraha", WardCount = 11 },
                                                                 new MunVdc { Id = 109, DistrictId = 11, VdcMunType = 4, Name = "Dewangunj", WardCount = 7 },
                                                                 new MunVdc { Id = 110, DistrictId = 11, VdcMunType = 4, Name = "Koshi", WardCount = 8 },
                                                                 new MunVdc { Id = 111, DistrictId = 11, VdcMunType = 4, Name = "Gadhi", WardCount = 6 },
                                                                 new MunVdc { Id = 112, DistrictId = 11, VdcMunType = 4, Name = "Barju", WardCount = 6 },
                                                                 new MunVdc { Id = 113, DistrictId = 11, VdcMunType = 4, Name = "Bhokraha", WardCount = 8 },
                                                                 new MunVdc { Id = 114, DistrictId = 11, VdcMunType = 4, Name = "Harinagara", WardCount = 7 },

                                                                 new MunVdc { Id = 115, DistrictId = 12, VdcMunType = 3, Name = "Phungling", WardCount = 11 },
                                                                 new MunVdc { Id = 116, DistrictId = 12, VdcMunType = 4, Name = "Aatharai Triveni", WardCount = 5 },
                                                                 new MunVdc { Id = 117, DistrictId = 12, VdcMunType = 4, Name = "Sidingawa", WardCount = 7 },
                                                                 new MunVdc { Id = 118, DistrictId = 12, VdcMunType = 4, Name = "Phakatanglung", WardCount = 7 },
                                                                 new MunVdc { Id = 119, DistrictId = 12, VdcMunType = 4, Name = "Mikwa Khola", WardCount = 5 },
                                                                 new MunVdc { Id = 120, DistrictId = 12, VdcMunType = 4, Name = "Meringden", WardCount = 6 },
                                                                 new MunVdc { Id = 121, DistrictId = 12, VdcMunType = 4, Name = "Maiwa Khola", WardCount = 6 },
                                                                 new MunVdc { Id = 122, DistrictId = 12, VdcMunType = 4, Name = "Yangbarak", WardCount = 6 },
                                                                 new MunVdc { Id = 123, DistrictId = 12, VdcMunType = 3, Name = "Sirijunga", WardCount = 8 },

                                                                 new MunVdc { Id = 124, DistrictId = 13, VdcMunType = 3, Name = "Myanglung", WardCount = 10 },
                                                                 new MunVdc { Id = 125, DistrictId = 13, VdcMunType = 3, Name = "Laligurans", WardCount = 9 },
                                                                 new MunVdc { Id = 126, DistrictId = 13, VdcMunType = 4, Name = "Aatharai", WardCount = 7 },
                                                                 new MunVdc { Id = 127, DistrictId = 13, VdcMunType = 4, Name = "Chhathar", WardCount = 6 },
                                                                 new MunVdc { Id = 128, DistrictId = 13, VdcMunType = 4, Name = "Phedap", WardCount = 5 },
                                                                 new MunVdc { Id = 129, DistrictId = 13, VdcMunType = 4, Name = "Menchayayem", WardCount = 6 },

                                                                 new MunVdc { Id = 130, DistrictId = 14, VdcMunType = 3, Name = "Katari", WardCount = 14 },
                                                                 new MunVdc { Id = 131, DistrictId = 14, VdcMunType = 3, Name = "ChaudandiGadhi", WardCount = 10 },
                                                                 new MunVdc { Id = 132, DistrictId = 14, VdcMunType = 3, Name = "Triyuga", WardCount = 16 },
                                                                 new MunVdc { Id = 133, DistrictId = 14, VdcMunType = 3, Name = "Belaka", WardCount = 9 },
                                                                 new MunVdc { Id = 134, DistrictId = 14, VdcMunType = 4, Name = "Udayapur Gadhi", WardCount = 8 },
                                                                 new MunVdc { Id = 135, DistrictId = 14, VdcMunType = 4, Name = "Tapli", WardCount = 5 },
                                                                 new MunVdc { Id = 136, DistrictId = 14, VdcMunType = 4, Name = "Rautamai", WardCount = 8 },
                                                                 new MunVdc { Id = 137, DistrictId = 14, VdcMunType = 4, Name = "Sunkoshi", WardCount = 5 },

                                                                 new MunVdc { Id = 138, DistrictId = 15, VdcMunType = 3, Name = "Rajbiraj", WardCount = 15 },
                                                                 new MunVdc { Id = 139, DistrictId = 15, VdcMunType = 3, Name = "Kanchanrup", WardCount = 12 },
                                                                 new MunVdc { Id = 140, DistrictId = 15, VdcMunType = 3, Name = "Dakneshwori", WardCount = 11 },
                                                                 new MunVdc { Id = 141, DistrictId = 15, VdcMunType = 3, Name = "BodeBarsain", WardCount = 16 },
                                                                 new MunVdc { Id = 142, DistrictId = 15, VdcMunType = 3, Name = "Khadak", WardCount = 11 },
                                                                 new MunVdc { Id = 143, DistrictId = 15, VdcMunType = 3, Name = "Shambhunath", WardCount = 11 },
                                                                 new MunVdc { Id = 144, DistrictId = 15, VdcMunType = 3, Name = "Surnga", WardCount = 11 },
                                                                 new MunVdc { Id = 145, DistrictId = 15, VdcMunType = 3, Name = "HanumanNagar", WardCount = 14 },
                                                                 new MunVdc { Id = 146, DistrictId = 15, VdcMunType = 4, Name = "Krishna Sawaran", WardCount = 5 },
                                                                 new MunVdc { Id = 147, DistrictId = 15, VdcMunType = 4, Name = "Chhinnamasta", WardCount = 8 },
                                                                 new MunVdc { Id = 148, DistrictId = 15, VdcMunType = 4, Name = "Mahadeva", WardCount = 6 },
                                                                 new MunVdc { Id = 149, DistrictId = 15, VdcMunType = 4, Name = "Saptkoshi", WardCount = 11 },
                                                                 new MunVdc { Id = 150, DistrictId = 15, VdcMunType = 4, Name = "Tirhut", WardCount = 5 },
                                                                 new MunVdc { Id = 151, DistrictId = 15, VdcMunType = 4, Name = "Tilathi Koiladi", WardCount = 8 },
                                                                 new MunVdc { Id = 152, DistrictId = 15, VdcMunType = 4, Name = "Rupani", WardCount = 6 },
                                                                 new MunVdc { Id = 153, DistrictId = 15, VdcMunType = 4, Name = "Belhi Chapani", WardCount = 5 },
                                                                 new MunVdc { Id = 154, DistrictId = 15, VdcMunType = 4, Name = "Bishnupura", WardCount = 7 },

                                                                 new MunVdc { Id = 155, DistrictId = 16, VdcMunType = 1, Name = "Birjunj", WardCount = 27 },
                                                                 new MunVdc { Id = 156, DistrictId = 16, VdcMunType = 3, Name = "Pokhariya", WardCount = 11 },
                                                                 new MunVdc { Id = 157, DistrictId = 16, VdcMunType = 4, Name = "Subarnapur", WardCount = 7 },
                                                                 new MunVdc { Id = 158, DistrictId = 16, VdcMunType = 4, Name = "Jagarnathapur", WardCount = 6 },
                                                                 new MunVdc { Id = 159, DistrictId = 16, VdcMunType = 4, Name = "Dhobini", WardCount = 5 },
                                                                 new MunVdc { Id = 160, DistrictId = 16, VdcMunType = 4, Name = "Chhipahar Mai", WardCount = 5 },
                                                                 new MunVdc { Id = 161, DistrictId = 16, VdcMunType = 4, Name = "Pakaha Mainpur", WardCount = 5 },
                                                                 new MunVdc { Id = 162, DistrictId = 16, VdcMunType = 4, Name = "Bindabasini", WardCount = 5 },
                                                                 new MunVdc { Id = 163, DistrictId = 16, VdcMunType = 4, Name = "Bahudar Mai", WardCount = 8 },
                                                                 new MunVdc { Id = 164, DistrictId = 16, VdcMunType = 4, Name = "Belawa", WardCount = 7 },
                                                                 new MunVdc { Id = 165, DistrictId = 16, VdcMunType = 4, Name = "Parsa Gadhi", WardCount = 6 },
                                                                 new MunVdc { Id = 166, DistrictId = 16, VdcMunType = 4, Name = "Sakhuwa Prasouni", WardCount = 6 },
                                                                 new MunVdc { Id = 167, DistrictId = 16, VdcMunType = 4, Name = "Paterwa Sugauli", WardCount = 7 },


                                                                 new MunVdc { Id = 168, DistrictId = 17, VdcMunType = 3, Name = "Ishworpur", WardCount = 15 },
                                                                 new MunVdc { Id = 169, DistrictId = 17, VdcMunType = 3, Name = "Malangawa", WardCount = 12 },
                                                                 new MunVdc { Id = 170, DistrictId = 17, VdcMunType = 3, Name = "Lalbandi", WardCount = 17 },
                                                                 new MunVdc { Id = 171, DistrictId = 17, VdcMunType = 3, Name = "Haripur", WardCount = 10 },
                                                                 new MunVdc { Id = 172, DistrictId = 17, VdcMunType = 3, Name = "Haripurwa", WardCount = 11 },
                                                                 new MunVdc { Id = 173, DistrictId = 17, VdcMunType = 3, Name = "Hariwan", WardCount = 11 },
                                                                 new MunVdc { Id = 174, DistrictId = 17, VdcMunType = 3, Name = "Barahathawa", WardCount = 18 },
                                                                 new MunVdc { Id = 175, DistrictId = 17, VdcMunType = 3, Name = "Balara", WardCount = 12 },
                                                                 new MunVdc { Id = 176, DistrictId = 17, VdcMunType = 3, Name = "Godaita", WardCount = 11 },
                                                                 new MunVdc { Id = 177, DistrictId = 17, VdcMunType = 3, Name = "Bagmati", WardCount = 10 },
                                                                 new MunVdc { Id = 178, DistrictId = 17, VdcMunType = 4, Name = "Kabilasi", WardCount = 8 },
                                                                 new MunVdc { Id = 179, DistrictId = 17, VdcMunType = 4, Name = "Chakraghatta", WardCount = 13 },
                                                                 new MunVdc { Id = 180, DistrictId = 17, VdcMunType = 4, Name = "Chandra Nagar", WardCount = 7 },
                                                                 new MunVdc { Id = 181, DistrictId = 17, VdcMunType = 4, Name = "Dhanakoul", WardCount = 9 },
                                                                 new MunVdc { Id = 182, DistrictId = 17, VdcMunType = 4, Name = "Bramhapuri", WardCount = 9 },
                                                                 new MunVdc { Id = 183, DistrictId = 17, VdcMunType = 4, Name = "Ram Nagar", WardCount = 10 },
                                                                 new MunVdc { Id = 184, DistrictId = 17, VdcMunType = 4, Name = "Bishnu", WardCount = 12 },


                                                                 new MunVdc { Id = 185, DistrictId = 18, VdcMunType = 2, Name = "Kalaiya", WardCount = 27 },
                                                                 new MunVdc { Id = 186, DistrictId = 18, VdcMunType = 2, Name = "Jitpur Simara", WardCount = 23 },
                                                                 new MunVdc { Id = 187, DistrictId = 18, VdcMunType = 3, Name = "Kolhabi", WardCount = 11 },
                                                                 new MunVdc { Id = 188, DistrictId = 18, VdcMunType = 3, Name = "Nijgadh", WardCount = 13 },
                                                                 new MunVdc { Id = 189, DistrictId = 18, VdcMunType = 3, Name = "Maha Gahdimai", WardCount = 11 },
                                                                 new MunVdc { Id = 190, DistrictId = 18, VdcMunType = 3, Name = "Simraun Gadh", WardCount = 11 },
                                                                 new MunVdc { Id = 191, DistrictId = 18, VdcMunType = 4, Name = "Adarsha Kotwal", WardCount = 8 },
                                                                 new MunVdc { Id = 192, DistrictId = 18, VdcMunType = 4, Name = "Karaiya mai", WardCount = 8 },
                                                                 new MunVdc { Id = 193, DistrictId = 18, VdcMunType = 4, Name = "Devtaal", WardCount = 7 },
                                                                 new MunVdc { Id = 194, DistrictId = 18, VdcMunType = 4, Name = "PachaRouta", WardCount = 9 },
                                                                 new MunVdc { Id = 195, DistrictId = 18, VdcMunType = 4, Name = "Parawanipur", WardCount = 9 },
                                                                 new MunVdc { Id = 196, DistrictId = 18, VdcMunType = 4, Name = "Prasouni", WardCount = 7 },
                                                                 new MunVdc { Id = 197, DistrictId = 18, VdcMunType = 4, Name = "Pheta", WardCount = 8 },
                                                                 new MunVdc { Id = 198, DistrictId = 18, VdcMunType = 4, Name = "Bara Gadhi", WardCount = 6 },
                                                                 new MunVdc { Id = 199, DistrictId = 18, VdcMunType = 4, Name = "Subarna", WardCount = 8 },


                                                                 new MunVdc { Id = 200, DistrictId = 19, VdcMunType = 3, Name = "Lahan", WardCount = 24 },
                                                                 new MunVdc { Id = 201, DistrictId = 19, VdcMunType = 3, Name = "Dhanagadhi Mai", WardCount = 14 },
                                                                 new MunVdc { Id = 202, DistrictId = 19, VdcMunType = 3, Name = "Siraha", WardCount = 22 },
                                                                 new MunVdc { Id = 203, DistrictId = 19, VdcMunType = 3, Name = "GolBazaar", WardCount = 13 },
                                                                 new MunVdc { Id = 204, DistrictId = 19, VdcMunType = 3, Name = "Mirchaiya", WardCount = 12 },
                                                                 new MunVdc { Id = 205, DistrictId = 19, VdcMunType = 3, Name = "Kalyanpur", WardCount = 12 },
                                                                 new MunVdc { Id = 206, DistrictId = 19, VdcMunType = 4, Name = "Bhaganwanpur", WardCount = 5 },
                                                                 new MunVdc { Id = 207, DistrictId = 19, VdcMunType = 4, Name = "Aaurahi", WardCount = 5 },
                                                                 new MunVdc { Id = 208, DistrictId = 19, VdcMunType = 4, Name = "Bishnupur", WardCount = 5 },
                                                                 new MunVdc { Id = 209, DistrictId = 19, VdcMunType = 4, Name = "Sukhipur", WardCount = 8 },
                                                                 new MunVdc { Id = 210, DistrictId = 19, VdcMunType = 4, Name = "Karjanha", WardCount = 7 },
                                                                 new MunVdc { Id = 211, DistrictId = 19, VdcMunType = 4, Name = "Bariyarpatti", WardCount = 5 },
                                                                 new MunVdc { Id = 212, DistrictId = 19, VdcMunType = 4, Name = "Laxmipur Patari", WardCount = 6 },
                                                                 new MunVdc { Id = 213, DistrictId = 19, VdcMunType = 4, Name = "Naraha", WardCount = 5 },
                                                                 new MunVdc { Id = 214, DistrictId = 19, VdcMunType = 4, Name = "Sakhuwanankarkatti", WardCount = 5 },
                                                                 new MunVdc { Id = 215, DistrictId = 19, VdcMunType = 4, Name = "Arnama", WardCount = 5 },
                                                                 new MunVdc { Id = 216, DistrictId = 19, VdcMunType = 4, Name = "Nawarajpur", WardCount = 5 },


                                                                 new MunVdc { Id = 217, DistrictId = 20, VdcMunType = 2, Name = "Janakpur", WardCount = 24 },
                                                                 new MunVdc { Id = 218, DistrictId = 20, VdcMunType = 3, Name = "Chhireshwarnath", WardCount = 11 },
                                                                 new MunVdc { Id = 219, DistrictId = 20, VdcMunType = 3, Name = "Ganeshman Charnath", WardCount = 11 },
                                                                 new MunVdc { Id = 220, DistrictId = 20, VdcMunType = 3, Name = "DhanusaDham", WardCount = 9 },
                                                                 new MunVdc { Id = 221, DistrictId = 20, VdcMunType = 3, Name = "Nagaraen", WardCount = 10 },
                                                                 new MunVdc { Id = 222, DistrictId = 20, VdcMunType = 3, Name = "Bideh", WardCount = 10 },
                                                                 new MunVdc { Id = 223, DistrictId = 20, VdcMunType = 3, Name = "Mithila", WardCount = 10 },
                                                                 new MunVdc { Id = 224, DistrictId = 20, VdcMunType = 3, Name = "Shahid Nagar", WardCount = 9 },
                                                                 new MunVdc { Id = 225, DistrictId = 20, VdcMunType = 3, Name = "Sabaila", WardCount = 13 },
                                                                 new MunVdc { Id = 226, DistrictId = 20, VdcMunType = 4, Name = "Kamala Siddidatri", WardCount = 6 },
                                                                 new MunVdc { Id = 227, DistrictId = 20, VdcMunType = 4, Name = "Janak Nandini", WardCount = 6 },
                                                                 new MunVdc { Id = 228, DistrictId = 20, VdcMunType = 4, Name = "Bateshwor", WardCount = 5 },
                                                                 new MunVdc { Id = 229, DistrictId = 20, VdcMunType = 4, Name = "Mithila Bihari", WardCount = 10 },
                                                                 new MunVdc { Id = 230, DistrictId = 20, VdcMunType = 4, Name = "Mukhiyapatti Musaharmiya", WardCount = 6 },
                                                                 new MunVdc { Id = 231, DistrictId = 20, VdcMunType = 4, Name = "Laxminiya", WardCount = 7 },
                                                                 new MunVdc { Id = 232, DistrictId = 20, VdcMunType = 4, Name = "Hanspur", WardCount = 8 },
                                                                 new MunVdc { Id = 233, DistrictId = 20, VdcMunType = 4, Name = "Aaurahi", WardCount = 8 },


                                                                 new MunVdc { Id = 234, DistrictId = 21, VdcMunType = 3, Name = "Chandrapur", WardCount = 10 },
                                                                 new MunVdc { Id = 235, DistrictId = 21, VdcMunType = 3, Name = "Garuda", WardCount = 9 },
                                                                 new MunVdc { Id = 236, DistrictId = 21, VdcMunType = 3, Name = "Gaur", WardCount = 13 },
                                                                 new MunVdc { Id = 237, DistrictId = 21, VdcMunType = 4, Name = "BoudhiMai", WardCount = 7 },
                                                                 new MunVdc { Id = 238, DistrictId = 21, VdcMunType = 4, Name = "Brindaban", WardCount = 8 },
                                                                 new MunVdc { Id = 239, DistrictId = 21, VdcMunType = 4, Name = "Devahi Gonahi", WardCount = 7 },
                                                                 new MunVdc { Id = 240, DistrictId = 21, VdcMunType = 4, Name = "Durga Bhagawati", WardCount = 8 },
                                                                 new MunVdc { Id = 241, DistrictId = 21, VdcMunType = 4, Name = "GadhiMai", WardCount = 7 },
                                                                 new MunVdc { Id = 242, DistrictId = 21, VdcMunType = 4, Name = "Gujara", WardCount = 9 },
                                                                 new MunVdc { Id = 243, DistrictId = 21, VdcMunType = 4, Name = "Katahariya", WardCount = 9 },
                                                                 new MunVdc { Id = 244, DistrictId = 21, VdcMunType = 4, Name = "Madhav Narayan", WardCount = 9 },
                                                                 new MunVdc { Id = 245, DistrictId = 21, VdcMunType = 4, Name = "Moulapur", WardCount = 7 },
                                                                 new MunVdc { Id = 246, DistrictId = 21, VdcMunType = 4, Name = "Phatuwa Bijayapur", WardCount = 5 },
                                                                 new MunVdc { Id = 247, DistrictId = 21, VdcMunType = 4, Name = "IshNath", WardCount = 9 },
                                                                 new MunVdc { Id = 248, DistrictId = 21, VdcMunType = 4, Name = "Paroha", WardCount = 8 },
                                                                 new MunVdc { Id = 249, DistrictId = 21, VdcMunType = 4, Name = "Rajpur", WardCount = 7 },


                                                                 new MunVdc { Id = 250, DistrictId = 22, VdcMunType = 3, Name = "Jaleshwor", WardCount = 12 },
                                                                 new MunVdc { Id = 251, DistrictId = 22, VdcMunType = 3, Name = "Bardibas", WardCount = 13 },
                                                                 new MunVdc { Id = 252, DistrictId = 22, VdcMunType = 3, Name = "Gaushala", WardCount = 12 },
                                                                 new MunVdc { Id = 253, DistrictId = 22, VdcMunType = 4, Name = "Ekadara", WardCount = 8 },
                                                                 new MunVdc { Id = 254, DistrictId = 22, VdcMunType = 4, Name = "Sonama", WardCount = 8 },
                                                                 new MunVdc { Id = 255, DistrictId = 22, VdcMunType = 4, Name = "Samsi", WardCount = 7 },
                                                                 new MunVdc { Id = 256, DistrictId = 22, VdcMunType = 4, Name = "Loharpatti", WardCount = 8 },
                                                                 new MunVdc { Id = 257, DistrictId = 22, VdcMunType = 4, Name = "RamGopalpur", WardCount = 6 },
                                                                 new MunVdc { Id = 258, DistrictId = 22, VdcMunType = 4, Name = "Mahottari", WardCount = 6 },
                                                                 new MunVdc { Id = 259, DistrictId = 22, VdcMunType = 4, Name = "Manara", WardCount = 8 },
                                                                 new MunVdc { Id = 260, DistrictId = 22, VdcMunType = 4, Name = "Matihani", WardCount = 6 },
                                                                 new MunVdc { Id = 261, DistrictId = 22, VdcMunType = 4, Name = "Bhangaha", WardCount = 9 },
                                                                 new MunVdc { Id = 262, DistrictId = 22, VdcMunType = 4, Name = "Balawa", WardCount = 7 },
                                                                 new MunVdc { Id = 263, DistrictId = 22, VdcMunType = 4, Name = "Pipara", WardCount = 7 },
                                                                 new MunVdc { Id = 264, DistrictId = 22, VdcMunType = 4, Name = "Aaurahi", WardCount = 7 },


                                                                 new MunVdc { Id = 265, DistrictId = 23, VdcMunType = 3, Name = "Changunarayan", WardCount = 9 },
                                                                 new MunVdc { Id = 266, DistrictId = 23, VdcMunType = 3, Name = "Bhaktapur", WardCount = 10 },
                                                                 new MunVdc { Id = 267, DistrictId = 23, VdcMunType = 3, Name = "Madhyapur", WardCount = 9 },
                                                                 new MunVdc { Id = 268, DistrictId = 23, VdcMunType = 3, Name = "Surya Binayak", WardCount = 10 },


                                                                 new MunVdc { Id = 269, DistrictId = 24, VdcMunType = 1, Name = "Bharatpur", WardCount = 29 },
                                                                 new MunVdc { Id = 270, DistrictId = 24, VdcMunType = 3, Name = "Kalika", WardCount = 11 },
                                                                 new MunVdc { Id = 271, DistrictId = 24, VdcMunType = 3, Name = "Khairhani", WardCount = 13 },
                                                                 new MunVdc { Id = 272, DistrictId = 24, VdcMunType = 3, Name = "Madi", WardCount = 9 },
                                                                 new MunVdc { Id = 273, DistrictId = 24, VdcMunType = 3, Name = "Ratna Nagar", WardCount = 16 },
                                                                 new MunVdc { Id = 274, DistrictId = 24, VdcMunType = 3, Name = "Rapti", WardCount = 13 },
                                                                 new MunVdc { Id = 275, DistrictId = 24, VdcMunType = 4, Name = "Ichchhakamana", WardCount = 7 },


                                                                 new MunVdc { Id = 276, DistrictId = 25, VdcMunType = 3, Name = "Dhunibesi", WardCount = 9 },
                                                                 new MunVdc { Id = 277, DistrictId = 25, VdcMunType = 3, Name = "Nilkantha", WardCount = 14 },
                                                                 new MunVdc { Id = 278, DistrictId = 25, VdcMunType = 4, Name = "Khaniyabas", WardCount = 5 },
                                                                 new MunVdc { Id = 279, DistrictId = 25, VdcMunType = 4, Name = "Gajuri", WardCount = 8 },
                                                                 new MunVdc { Id = 280, DistrictId = 25, VdcMunType = 4, Name = "Galchi", WardCount = 8 },
                                                                 new MunVdc { Id = 281, DistrictId = 25, VdcMunType = 4, Name = "Ganga Jamuna", WardCount = 7 },
                                                                 new MunVdc { Id = 282, DistrictId = 25, VdcMunType = 4, Name = "Jwalamukhi", WardCount = 7 },
                                                                 new MunVdc { Id = 283, DistrictId = 25, VdcMunType = 4, Name = "Thakre", WardCount = 11 },
                                                                 new MunVdc { Id = 284, DistrictId = 25, VdcMunType = 4, Name = "Netrawati", WardCount = 5 },
                                                                 new MunVdc { Id = 285, DistrictId = 25, VdcMunType = 4, Name = "Benighat Rorang", WardCount = 10 },
                                                                 new MunVdc { Id = 286, DistrictId = 25, VdcMunType = 4, Name = "Rubi Valley", WardCount = 6 },
                                                                 new MunVdc { Id = 287, DistrictId = 25, VdcMunType = 4, Name = "Sidda Lekh", WardCount = 7 },
                                                                 new MunVdc { Id = 288, DistrictId = 25, VdcMunType = 4, Name = "Tripura Sundari", WardCount = 7 },


                                                                 new MunVdc { Id = 289, DistrictId = 26, VdcMunType = 1, Name = "Kathmandu", WardCount = 32 },
                                                                 new MunVdc { Id = 290, DistrictId = 26, VdcMunType = 3, Name = "Kageshwori Manohara", WardCount = 12 },
                                                                 new MunVdc { Id = 291, DistrictId = 26, VdcMunType = 3, Name = "Kirtipur", WardCount = 10 },
                                                                 new MunVdc { Id = 292, DistrictId = 26, VdcMunType = 3, Name = "Gokarneswor", WardCount = 9 },
                                                                 new MunVdc { Id = 293, DistrictId = 26, VdcMunType = 3, Name = "Chandragiri", WardCount = 15 },
                                                                 new MunVdc { Id = 294, DistrictId = 26, VdcMunType = 3, Name = "Tokha", WardCount = 11 },
                                                                 new MunVdc { Id = 295, DistrictId = 26, VdcMunType = 3, Name = "Tarkeshwor", WardCount = 11 },
                                                                 new MunVdc { Id = 296, DistrictId = 26, VdcMunType = 3, Name = "Dakshinkali", WardCount = 9 },
                                                                 new MunVdc { Id = 297, DistrictId = 26, VdcMunType = 3, Name = "Nagarjun", WardCount = 10 },
                                                                 new MunVdc { Id = 298, DistrictId = 26, VdcMunType = 3, Name = "Budhanilakantha", WardCount = 13 },
                                                                 new MunVdc { Id = 299, DistrictId = 26, VdcMunType = 4, Name = "Sankharapur", WardCount = 9 },


                                                                 new MunVdc { Id = 300, DistrictId = 27, VdcMunType = 3, Name = "Jiri", WardCount = 9 },
                                                                 new MunVdc { Id = 301, DistrictId = 27, VdcMunType = 3, Name = "Bhimeshwor", WardCount = 9 },
                                                                 new MunVdc { Id = 302, DistrictId = 27, VdcMunType = 4, Name = "Kalinchok", WardCount = 9 },
                                                                 new MunVdc { Id = 303, DistrictId = 27, VdcMunType = 4, Name = "Gauri Shankar", WardCount = 9 },
                                                                 new MunVdc { Id = 304, DistrictId = 27, VdcMunType = 4, Name = "Tamakoshi", WardCount = 7 },
                                                                 new MunVdc { Id = 305, DistrictId = 27, VdcMunType = 4, Name = "Melung", WardCount = 7 },
                                                                 new MunVdc { Id = 306, DistrictId = 27, VdcMunType = 4, Name = "Bigu", WardCount = 8 },
                                                                 new MunVdc { Id = 307, DistrictId = 27, VdcMunType = 4, Name = "Baiteshwor", WardCount = 8 },
                                                                 new MunVdc { Id = 308, DistrictId = 27, VdcMunType = 4, Name = "Shailung", WardCount = 8 },


                                                                 new MunVdc { Id = 309, DistrictId = 28, VdcMunType = 3, Name = "Dhulikhel", WardCount = 12 },
                                                                 new MunVdc { Id = 310, DistrictId = 28, VdcMunType = 3, Name = "Banepa", WardCount = 14 },
                                                                 new MunVdc { Id = 311, DistrictId = 28, VdcMunType = 3, Name = "Panauti", WardCount = 12 },
                                                                 new MunVdc { Id = 312, DistrictId = 28, VdcMunType = 3, Name = "Panchkhal", WardCount = 13 },
                                                                 new MunVdc { Id = 313, DistrictId = 28, VdcMunType = 3, Name = "Namobuddha", WardCount = 11 },
                                                                 new MunVdc { Id = 314, DistrictId = 28, VdcMunType = 3, Name = "Mandan Deupur", WardCount = 12 },
                                                                 new MunVdc { Id = 315, DistrictId = 28, VdcMunType = 4, Name = "Khanikhola", WardCount = 7 },
                                                                 new MunVdc { Id = 316, DistrictId = 28, VdcMunType = 4, Name = "Chaunri Deurali", WardCount = 9 },
                                                                 new MunVdc { Id = 317, DistrictId = 28, VdcMunType = 4, Name = "Temal", WardCount = 9 },
                                                                 new MunVdc { Id = 318, DistrictId = 28, VdcMunType = 4, Name = "Bethanchok", WardCount = 6 },
                                                                 new MunVdc { Id = 319, DistrictId = 28, VdcMunType = 4, Name = "Bhumlu", WardCount = 10 },
                                                                 new MunVdc { Id = 320, DistrictId = 28, VdcMunType = 4, Name = "Mahabharat", WardCount = 8 },
                                                                 new MunVdc { Id = 321, DistrictId = 28, VdcMunType = 4, Name = "Roshi", WardCount = 12 },


                                                                 new MunVdc { Id = 322, DistrictId = 29, VdcMunType = 1, Name = "Lalitpur", WardCount = 29 },
                                                                 new MunVdc { Id = 323, DistrictId = 29, VdcMunType = 3, Name = "Godawari", WardCount = 14 },
                                                                 new MunVdc { Id = 324, DistrictId = 29, VdcMunType = 3, Name = "Mahalaxmi", WardCount = 10 },
                                                                 new MunVdc { Id = 325, DistrictId = 29, VdcMunType = 4, Name = "Konjyosom", WardCount = 5 },
                                                                 new MunVdc { Id = 326, DistrictId = 29, VdcMunType = 4, Name = "Bagmati", WardCount = 7 },
                                                                 new MunVdc { Id = 327, DistrictId = 29, VdcMunType = 4, Name = "Mahankal", WardCount = 6 },


                                                                 new MunVdc { Id = 328, DistrictId = 30, VdcMunType = 2, Name = "Hetauda", WardCount = 19 },
                                                                 new MunVdc { Id = 329, DistrictId = 30, VdcMunType = 3, Name = "Thaha", WardCount = 12 },
                                                                 new MunVdc { Id = 330, DistrictId = 30, VdcMunType = 4, Name = "Indra Sarobar", WardCount = 5 },
                                                                 new MunVdc { Id = 331, DistrictId = 30, VdcMunType = 4, Name = "Kailash", WardCount = 10 },
                                                                 new MunVdc { Id = 332, DistrictId = 30, VdcMunType = 4, Name = "Bakaiya", WardCount = 12 },
                                                                 new MunVdc { Id = 333, DistrictId = 30, VdcMunType = 4, Name = "Bagmati", WardCount = 9 },
                                                                 new MunVdc { Id = 334, DistrictId = 30, VdcMunType = 4, Name = "Bhimphedi", WardCount = 9 },
                                                                 new MunVdc { Id = 335, DistrictId = 30, VdcMunType = 4, Name = "Makawanpur Gadhi", WardCount = 8 },
                                                                 new MunVdc { Id = 336, DistrictId = 30, VdcMunType = 4, Name = "Manahari", WardCount = 9 },
                                                                 new MunVdc { Id = 337, DistrictId = 30, VdcMunType = 4, Name = "Raksirang", WardCount = 9 },


                                                                 new MunVdc { Id = 338, DistrictId = 31, VdcMunType = 3, Name = "Bidur", WardCount = 13 },
                                                                 new MunVdc { Id = 339, DistrictId = 31, VdcMunType = 3, Name = "Belkot Gadhi", WardCount = 13 },
                                                                 new MunVdc { Id = 340, DistrictId = 31, VdcMunType = 4, Name = "Kakani", WardCount = 8 },
                                                                 new MunVdc { Id = 341, DistrictId = 31, VdcMunType = 4, Name = "Kispang", WardCount = 5 },
                                                                 new MunVdc { Id = 342, DistrictId = 31, VdcMunType = 4, Name = "Tadi", WardCount = 6 },
                                                                 new MunVdc { Id = 343, DistrictId = 31, VdcMunType = 4, Name = "Tarkeshwor", WardCount = 6 },
                                                                 new MunVdc { Id = 344, DistrictId = 31, VdcMunType = 4, Name = "Dupcheshwor", WardCount = 7 },
                                                                 new MunVdc { Id = 345, DistrictId = 31, VdcMunType = 4, Name = "Panchakanya", WardCount = 5 },
                                                                 new MunVdc { Id = 346, DistrictId = 31, VdcMunType = 4, Name = "Likhu", WardCount = 6 },
                                                                 new MunVdc { Id = 347, DistrictId = 31, VdcMunType = 4, Name = "Meghang", WardCount = 6 },
                                                                 new MunVdc { Id = 348, DistrictId = 31, VdcMunType = 4, Name = "Shivpuri", WardCount = 8 },
                                                                 new MunVdc { Id = 349, DistrictId = 31, VdcMunType = 4, Name = "Surya Gadhi", WardCount = 5 },


                                                                 new MunVdc { Id = 350, DistrictId = 32, VdcMunType = 3, Name = "Manthali", WardCount = 14 },
                                                                 new MunVdc { Id = 351, DistrictId = 32, VdcMunType = 3, Name = "Ramechhap", WardCount = 9 },
                                                                 new MunVdc { Id = 352, DistrictId = 32, VdcMunType = 4, Name = "Umakunda", WardCount = 7 },
                                                                 new MunVdc { Id = 353, DistrictId = 32, VdcMunType = 4, Name = "KhandaDevi", WardCount = 9 },
                                                                 new MunVdc { Id = 354, DistrictId = 32, VdcMunType = 4, Name = "Gokul Ganga", WardCount = 6 },
                                                                 new MunVdc { Id = 355, DistrictId = 32, VdcMunType = 4, Name = "Doramba", WardCount = 7 },
                                                                 new MunVdc { Id = 356, DistrictId = 32, VdcMunType = 4, Name = "Likhu", WardCount = 7 },
                                                                 new MunVdc { Id = 357, DistrictId = 32, VdcMunType = 4, Name = "Sunapati", WardCount = 5 },


                                                                 new MunVdc { Id = 358, DistrictId = 33, VdcMunType = 4, Name = "Uttar Gaya", WardCount = 5 },
                                                                 new MunVdc { Id = 359, DistrictId = 33, VdcMunType = 4, Name = "Kalika", WardCount = 5 },
                                                                 new MunVdc { Id = 360, DistrictId = 33, VdcMunType = 4, Name = "Gosaikunda", WardCount = 6 },
                                                                 new MunVdc { Id = 361, DistrictId = 33, VdcMunType = 4, Name = "Naukunda", WardCount = 6 },
                                                                 new MunVdc { Id = 362, DistrictId = 33, VdcMunType = 4, Name = "Parbatikunda", WardCount = 5 },


                                                                 new MunVdc { Id = 363, DistrictId = 34, VdcMunType = 3, Name = "Kamalamai", WardCount = 14 },
                                                                 new MunVdc { Id = 364, DistrictId = 34, VdcMunType = 3, Name = "Dudhauli", WardCount = 14 },
                                                                 new MunVdc { Id = 365, DistrictId = 34, VdcMunType = 4, Name = "Golanjor", WardCount = 7 },
                                                                 new MunVdc { Id = 366, DistrictId = 34, VdcMunType = 4, Name = "Ghyanglekh", WardCount = 5 },
                                                                 new MunVdc { Id = 367, DistrictId = 34, VdcMunType = 4, Name = "Teen Patan", WardCount = 11 },
                                                                 new MunVdc { Id = 368, DistrictId = 34, VdcMunType = 4, Name = "Phikkal", WardCount = 6 },
                                                                 new MunVdc { Id = 369, DistrictId = 34, VdcMunType = 4, Name = "Marin", WardCount = 8 },
                                                                 new MunVdc { Id = 370, DistrictId = 34, VdcMunType = 4, Name = "Sunkoshi", WardCount = 7 },
                                                                 new MunVdc { Id = 371, DistrictId = 34, VdcMunType = 4, Name = "Hariharpur", WardCount = 8 },


                                                                 new MunVdc { Id = 372, DistrictId = 35, VdcMunType = 3, Name = "Chautara Sangachokgadhi", WardCount = 14 },
                                                                 new MunVdc { Id = 373, DistrictId = 35, VdcMunType = 3, Name = "Barhabise", WardCount = 9 },
                                                                 new MunVdc { Id = 374, DistrictId = 35, VdcMunType = 3, Name = "Melamchi", WardCount = 13 },
                                                                 new MunVdc { Id = 375, DistrictId = 35, VdcMunType = 4, Name = "Indrawati", WardCount = 12 },
                                                                 new MunVdc { Id = 376, DistrictId = 35, VdcMunType = 4, Name = "Jugal", WardCount = 7 },
                                                                 new MunVdc { Id = 377, DistrictId = 35, VdcMunType = 4, Name = "Panchapokhari", WardCount = 8 },
                                                                 new MunVdc { Id = 378, DistrictId = 35, VdcMunType = 4, Name = "Balephi", WardCount = 8 },
                                                                 new MunVdc { Id = 379, DistrictId = 35, VdcMunType = 4, Name = "Bhotekoshi", WardCount = 5 },
                                                                 new MunVdc { Id = 380, DistrictId = 35, VdcMunType = 4, Name = "Lishankhu Pakhar", WardCount = 7 },
                                                                 new MunVdc { Id = 381, DistrictId = 35, VdcMunType = 4, Name = "Sunkoshi", WardCount = 7 },
                                                                 new MunVdc { Id = 382, DistrictId = 35, VdcMunType = 4, Name = "Helambu", WardCount = 7 },
                                                                 new MunVdc { Id = 383, DistrictId = 35, VdcMunType = 4, Name = "Tripurasundari", WardCount = 6 },


                                                                 new MunVdc { Id = 384, DistrictId = 36, VdcMunType = 3, Name = "Baglung", WardCount = 14 },
                                                                 new MunVdc { Id = 385, DistrictId = 36, VdcMunType = 3, Name = "Galkot", WardCount = 11 },
                                                                 new MunVdc { Id = 386, DistrictId = 36, VdcMunType = 3, Name = "Jaimini", WardCount = 10 },
                                                                 new MunVdc { Id = 387, DistrictId = 36, VdcMunType = 3, Name = "Dhorpatan", WardCount = 9 },
                                                                 new MunVdc { Id = 388, DistrictId = 36, VdcMunType = 4, Name = "Bareng", WardCount = 5 },
                                                                 new MunVdc { Id = 389, DistrictId = 36, VdcMunType = 4, Name = "Kathe Khola", WardCount = 8 },
                                                                 new MunVdc { Id = 390, DistrictId = 36, VdcMunType = 4, Name = "Taman Khola", WardCount = 6 },
                                                                 new MunVdc { Id = 391, DistrictId = 36, VdcMunType = 4, Name = "Tara Khola", WardCount = 5 },
                                                                 new MunVdc { Id = 392, DistrictId = 36, VdcMunType = 4, Name = "Nisi Khola", WardCount = 7 },
                                                                 new MunVdc { Id = 393, DistrictId = 36, VdcMunType = 4, Name = "Badi Gad", WardCount = 10 },
                                                                 

                                                                 new MunVdc { Id = 394, DistrictId = 37, VdcMunType = 3, Name = "Gorkha", WardCount = 14 },
                                                                 new MunVdc { Id = 395, DistrictId = 37, VdcMunType = 3, Name = "Palungtar", WardCount = 10 },
                                                                 new MunVdc { Id = 396, DistrictId = 37, VdcMunType = 4, Name = "Sulikot", WardCount = 8 },
                                                                 new MunVdc { Id = 397, DistrictId = 37, VdcMunType = 4, Name = "Siranchok", WardCount = 8 },
                                                                 new MunVdc { Id = 398, DistrictId = 37, VdcMunType = 4, Name = "Ajirkot", WardCount = 5 },
                                                                 new MunVdc { Id = 399, DistrictId = 37, VdcMunType = 4, Name = "Aarughat", WardCount = 10 },
                                                                 new MunVdc { Id = 400, DistrictId = 37, VdcMunType = 4, Name = "Gandaki", WardCount = 8 },
                                                                 new MunVdc { Id = 401, DistrictId = 37, VdcMunType = 4, Name = "Chumanubri", WardCount = 7 },
                                                                 new MunVdc { Id = 402, DistrictId = 37, VdcMunType = 4, Name = "Dharche", WardCount = 7 },
                                                                 new MunVdc { Id = 403, DistrictId = 37, VdcMunType = 4, Name = "Bhimsen", WardCount = 8 },
                                                                 new MunVdc { Id = 404, DistrictId = 37, VdcMunType = 4, Name = "Sahid Lakhnath", WardCount = 9 },


                                                                 new MunVdc { Id = 405, DistrictId = 38, VdcMunType = 1, Name = "Pokhara Lekhnath", WardCount = 33 },
                                                                 new MunVdc { Id = 406, DistrictId = 38, VdcMunType = 4, Name = "Annapurna", WardCount = 11 },
                                                                 new MunVdc { Id = 407, DistrictId = 38, VdcMunType = 4, Name = "Machhapuchhre", WardCount = 9 },
                                                                 new MunVdc { Id = 408, DistrictId = 38, VdcMunType = 4, Name = "Madi", WardCount = 12 },
                                                                 new MunVdc { Id = 409, DistrictId = 38, VdcMunType = 4, Name = "Rupa", WardCount = 7 },


                                                                 new MunVdc { Id = 410, DistrictId = 39, VdcMunType = 3, Name = "Besishahar", WardCount = 11 },
                                                                 new MunVdc { Id = 411, DistrictId = 39, VdcMunType = 3, Name = "Madhya Nepal", WardCount = 10 },
                                                                 new MunVdc { Id = 412, DistrictId = 39, VdcMunType = 3, Name = "Rainas", WardCount = 10 },
                                                                 new MunVdc { Id = 413, DistrictId = 39, VdcMunType = 3, Name = "Sundarbazar", WardCount = 11 },
                                                                 new MunVdc { Id = 414, DistrictId = 39, VdcMunType = 4, Name = "Kabahola Sothar", WardCount = 9 },
                                                                 new MunVdc { Id = 415, DistrictId = 39, VdcMunType = 4, Name = "Dudh Pokhari", WardCount = 6 },
                                                                 new MunVdc { Id = 416, DistrictId = 39, VdcMunType = 4, Name = "Dordi", WardCount = 9 },
                                                                 new MunVdc { Id = 417, DistrictId = 39, VdcMunType = 4, Name = "Marsyangdi", WardCount = 9 },


                                                                 new MunVdc { Id = 418, DistrictId = 40, VdcMunType = 4, Name = "Chame", WardCount = 5 },
                                                                 new MunVdc { Id = 419, DistrictId = 40, VdcMunType = 4, Name = "Nar phu", WardCount = 5 },
                                                                 new MunVdc { Id = 420, DistrictId = 40, VdcMunType = 4, Name = "Nashong", WardCount = 9 },
                                                                 new MunVdc { Id = 421, DistrictId = 40, VdcMunType = 4, Name = "Nesyang", WardCount = 9 },


                                                                 new MunVdc { Id = 422, DistrictId = 41, VdcMunType = 4, Name = "Gharpajhong", WardCount = 5 },
                                                                 new MunVdc { Id = 423, DistrictId = 41, VdcMunType = 4, Name = "Thasang", WardCount = 5 },
                                                                 new MunVdc { Id = 424, DistrictId = 41, VdcMunType = 4, Name = "Dalome", WardCount = 5 },
                                                                 new MunVdc { Id = 425, DistrictId = 41, VdcMunType = 4, Name = "Lomanthang", WardCount = 5 },
                                                                 new MunVdc { Id = 426, DistrictId = 41, VdcMunType = 4, Name = "Barha Gaun Muktichhetra", WardCount = 5 },


                                                                 new MunVdc { Id = 427, DistrictId = 42, VdcMunType = 3, Name = "Beni", WardCount = 10 },
                                                                 new MunVdc { Id = 428, DistrictId = 42, VdcMunType = 4, Name = "Annapurna", WardCount = 8 },
                                                                 new MunVdc { Id = 429, DistrictId = 42, VdcMunType = 4, Name = "Dhawalagiri", WardCount = 7 },
                                                                 new MunVdc { Id = 430, DistrictId = 42, VdcMunType = 4, Name = "Mangala", WardCount = 5 },
                                                                 new MunVdc { Id = 431, DistrictId = 42, VdcMunType = 4, Name = "Malika", WardCount = 7 },
                                                                 new MunVdc { Id = 432, DistrictId = 42, VdcMunType = 4, Name = "Raghu Ganga", WardCount = 8 },


                                                                 new MunVdc { Id = 433, DistrictId = 43, VdcMunType = 3, Name = "Kawasoti", WardCount = 17 },
                                                                 new MunVdc { Id = 434, DistrictId = 43, VdcMunType = 3, Name = "Gaindakot", WardCount = 18 },
                                                                 new MunVdc { Id = 435, DistrictId = 43, VdcMunType = 3, Name = "Devachuli", WardCount = 17 },
                                                                 new MunVdc { Id = 436, DistrictId = 43, VdcMunType = 4, Name = "Madhyabindu", WardCount = 15 },
                                                                 new MunVdc { Id = 437, DistrictId = 43, VdcMunType = 4, Name = "Bungdikali", WardCount = 6 },
                                                                 new MunVdc { Id = 438, DistrictId = 43, VdcMunType = 4, Name = "Bulingtar", WardCount = 6 },
                                                                 new MunVdc { Id = 439, DistrictId = 43, VdcMunType = 4, Name = "Binayi Triveni", WardCount = 5 },
                                                                 new MunVdc { Id = 440, DistrictId = 43, VdcMunType = 4, Name = "Hupsekot", WardCount = 6 },


                                                                 new MunVdc { Id = 441, DistrictId = 44, VdcMunType = 3, Name = "Kushma", WardCount = 14 },
                                                                 new MunVdc { Id = 442, DistrictId = 44, VdcMunType = 3, Name = "Phalebas", WardCount = 11 },
                                                                 new MunVdc { Id = 443, DistrictId = 44, VdcMunType = 4, Name = "Jaljala", WardCount = 9 },
                                                                 new MunVdc { Id = 444, DistrictId = 44, VdcMunType = 4, Name = "Painyoo", WardCount = 7 },
                                                                 new MunVdc { Id = 445, DistrictId = 44, VdcMunType = 4, Name = "Maha Shila", WardCount = 6 },
                                                                 new MunVdc { Id = 446, DistrictId = 44, VdcMunType = 4, Name = "Modi", WardCount = 8 },
                                                                 new MunVdc { Id = 447, DistrictId = 44, VdcMunType = 4, Name = "Bihadi", WardCount = 6 },


                                                                 new MunVdc { Id = 448, DistrictId = 45, VdcMunType = 3, Name = "Galyang", WardCount = 11 },
                                                                 new MunVdc { Id = 449, DistrictId = 45, VdcMunType = 3, Name = "Chapakot", WardCount = 10 },
                                                                 new MunVdc { Id = 450, DistrictId = 45, VdcMunType = 3, Name = "Putalibazar", WardCount = 14 },
                                                                 new MunVdc { Id = 451, DistrictId = 45, VdcMunType = 3, Name = "Bhirkot", WardCount = 9 },
                                                                 new MunVdc { Id = 452, DistrictId = 45, VdcMunType = 3, Name = "Waling", WardCount = 14 },
                                                                 new MunVdc { Id = 453, DistrictId = 45, VdcMunType = 4, Name = "Arjun Chaupari", WardCount = 6 },
                                                                 new MunVdc { Id = 454, DistrictId = 45, VdcMunType = 4, Name = "Aandhi Khola", WardCount = 6 },
                                                                 new MunVdc { Id = 455, DistrictId = 45, VdcMunType = 4, Name = "Kali Gandaki", WardCount = 7 },
                                                                 new MunVdc { Id = 456, DistrictId = 45, VdcMunType = 4, Name = "Phedi Khola", WardCount = 5 },
                                                                 new MunVdc { Id = 457, DistrictId = 45, VdcMunType = 4, Name = "Biruwa", WardCount = 8 },
                                                                 new MunVdc { Id = 458, DistrictId = 45, VdcMunType = 4, Name = "Harinas", WardCount = 7 },


                                                                 new MunVdc { Id = 459, DistrictId = 46, VdcMunType = 3, Name = "Bhanu", WardCount = 13 },
                                                                 new MunVdc { Id = 460, DistrictId = 46, VdcMunType = 3, Name = "Bhimad", WardCount = 9 },
                                                                 new MunVdc { Id = 461, DistrictId = 46, VdcMunType = 3, Name = "Byas", WardCount = 14 },
                                                                 new MunVdc { Id = 462, DistrictId = 46, VdcMunType = 3, Name = "Sukla Gandaki", WardCount = 12 },
                                                                 new MunVdc { Id = 463, DistrictId = 46, VdcMunType = 4, Name = "Aanbu Khaireni", WardCount = 6 },
                                                                 new MunVdc { Id = 464, DistrictId = 46, VdcMunType = 4, Name = "Rishing", WardCount = 8 },
                                                                 new MunVdc { Id = 465, DistrictId = 46, VdcMunType = 4, Name = "Ghiring", WardCount = 5 },
                                                                 new MunVdc { Id = 466, DistrictId = 46, VdcMunType = 4, Name = "Devghat", WardCount = 5 },
                                                                 new MunVdc { Id = 467, DistrictId = 46, VdcMunType = 4, Name = "Myagde", WardCount = 7 },
                                                                 new MunVdc { Id = 468, DistrictId = 46, VdcMunType = 4, Name = "Bandipur", WardCount = 6 },


                                                                 new MunVdc { Id = 469, DistrictId = 47, VdcMunType = 3, Name = "Sandhikharka", WardCount = 12 },
                                                                 new MunVdc { Id = 470, DistrictId = 47, VdcMunType = 3, Name = "Shit Ganga", WardCount = 14 },
                                                                 new MunVdc { Id = 471, DistrictId = 47, VdcMunType = 3, Name = "Bhumikasthan", WardCount = 10 },
                                                                 new MunVdc { Id = 472, DistrictId = 47, VdcMunType = 4, Name = "Chhatra Dev", WardCount = 8 },
                                                                 new MunVdc { Id = 473, DistrictId = 47, VdcMunType = 4, Name = "Panini", WardCount = 8 },
                                                                 new MunVdc { Id = 474, DistrictId = 47, VdcMunType = 4, Name = "Malarani", WardCount = 9 },


                                                                 new MunVdc { Id = 475, DistrictId = 48, VdcMunType = 2, Name = "Nepalgunj", WardCount = 23 },
                                                                 new MunVdc { Id = 476, DistrictId = 48, VdcMunType = 3, Name = "Kohalpur", WardCount = 15 },
                                                                 new MunVdc { Id = 477, DistrictId = 48, VdcMunType = 4, Name = "Narainapur", WardCount = 6 },
                                                                 new MunVdc { Id = 478, DistrictId = 48, VdcMunType = 4, Name = "Raptisonari", WardCount = 9 },
                                                                 new MunVdc { Id = 479, DistrictId = 48, VdcMunType = 4, Name = "Baijanath", WardCount = 8 },
                                                                 new MunVdc { Id = 480, DistrictId = 48, VdcMunType = 4, Name = "Khajura", WardCount = 8 },
                                                                 new MunVdc { Id = 481, DistrictId = 48, VdcMunType = 4, Name = "Duduwa", WardCount = 6 },
                                                                 new MunVdc { Id = 482, DistrictId = 48, VdcMunType = 4, Name = "Janaki", WardCount = 6 },


                                                                 new MunVdc { Id = 483, DistrictId = 49, VdcMunType = 3, Name = "Gulariya", WardCount = 12 },
                                                                 new MunVdc { Id = 484, DistrictId = 49, VdcMunType = 3, Name = "Madhuvan", WardCount = 9 },
                                                                 new MunVdc { Id = 485, DistrictId = 49, VdcMunType = 3, Name = "Rajapur Tratal", WardCount = 10 },
                                                                 new MunVdc { Id = 486, DistrictId = 49, VdcMunType = 3, Name = "Thakura Baba", WardCount = 9 },
                                                                 new MunVdc { Id = 487, DistrictId = 49, VdcMunType = 3, Name = "Bansgadhi", WardCount = 9 },
                                                                 new MunVdc { Id = 488, DistrictId = 49, VdcMunType = 3, Name = "Bar Bardiya", WardCount = 11 },
                                                                 new MunVdc { Id = 489, DistrictId = 49, VdcMunType = 4, Name = "Badhaiya Tal", WardCount = 9 },
                                                                 new MunVdc { Id = 490, DistrictId = 49, VdcMunType = 4, Name = "Geruwa", WardCount = 6 },


                                                                 new MunVdc { Id = 491, DistrictId = 50, VdcMunType = 2, Name = "Tulsipur", WardCount = 19 },
                                                                 new MunVdc { Id = 492, DistrictId = 50, VdcMunType = 2, Name = "Ghorahi", WardCount = 19 },
                                                                 new MunVdc { Id = 493, DistrictId = 50, VdcMunType = 3, Name = "Lamahi", WardCount = 9 },
                                                                 new MunVdc { Id = 494, DistrictId = 50, VdcMunType = 4, Name = "Banglachuli", WardCount = 8 },
                                                                 new MunVdc { Id = 495, DistrictId = 50, VdcMunType = 4, Name = "Dangi Sharan", WardCount = 7 },
                                                                 new MunVdc { Id = 496, DistrictId = 50, VdcMunType = 4, Name = "Gadhawa", WardCount = 8 },
                                                                 new MunVdc { Id = 497, DistrictId = 50, VdcMunType = 4, Name = "Rajpur", WardCount = 7 },
                                                                 new MunVdc { Id = 498, DistrictId = 50, VdcMunType = 4, Name = "Rapti", WardCount = 9 },
                                                                 new MunVdc { Id = 499, DistrictId = 50, VdcMunType = 4, Name = "Shanti Nagar", WardCount = 7 },
                                                                 new MunVdc { Id = 500, DistrictId = 50, VdcMunType = 4, Name = "Babai", WardCount = 7 },


                                                                 new MunVdc { Id = 501, DistrictId = 51, VdcMunType = 4, Name = "Putha Uttar Ganga", WardCount = 14 },
                                                                 new MunVdc { Id = 502, DistrictId = 51, VdcMunType = 4, Name = "Bhume", WardCount = 9 },
                                                                 new MunVdc { Id = 503, DistrictId = 51, VdcMunType = 4, Name = "Sisne", WardCount = 8 },
                                                                 

                                                                 new MunVdc { Id = 504, DistrictId = 52, VdcMunType = 3, Name = "Musikot", WardCount = 9 },
                                                                 new MunVdc { Id = 505, DistrictId = 52, VdcMunType = 3, Name = "Resunga", WardCount = 14 },
                                                                 new MunVdc { Id = 506, DistrictId = 52, VdcMunType = 4, Name = "Isma", WardCount = 6 },
                                                                 new MunVdc { Id = 507, DistrictId = 52, VdcMunType = 4, Name = "Kali Gandaki", WardCount = 7 },
                                                                 new MunVdc { Id = 508, DistrictId = 52, VdcMunType = 4, Name = "Gulmi Darbar", WardCount = 7 },
                                                                 new MunVdc { Id = 509, DistrictId = 52, VdcMunType = 4, Name = "Satyawati", WardCount = 8 },
                                                                 new MunVdc { Id = 510, DistrictId = 52, VdcMunType = 4, Name = "Chandrakot", WardCount = 8 },
                                                                 new MunVdc { Id = 511, DistrictId = 52, VdcMunType = 4, Name = "Ruru", WardCount = 6 },
                                                                 new MunVdc { Id = 512, DistrictId = 52, VdcMunType = 4, Name = "chhatrakot", WardCount = 6 },
                                                                 new MunVdc { Id = 513, DistrictId = 52, VdcMunType = 4, Name = "Dhurkot", WardCount = 7 },
                                                                 new MunVdc { Id = 514, DistrictId = 52, VdcMunType = 4, Name = "Madane", WardCount = 7 },
                                                                 new MunVdc { Id = 515, DistrictId = 52, VdcMunType = 4, Name = "Malika", WardCount = 8 },


                                                                 new MunVdc { Id = 516, DistrictId = 53, VdcMunType = 3, Name = "Kapilbastu", WardCount = 12 },
                                                                 new MunVdc { Id = 517, DistrictId = 53, VdcMunType = 3, Name = "Buddabhumi", WardCount = 10 },
                                                                 new MunVdc { Id = 518, DistrictId = 53, VdcMunType = 3, Name = "Shivaraj", WardCount = 11 },
                                                                 new MunVdc { Id = 519, DistrictId = 53, VdcMunType = 3, Name = "Maharajganj", WardCount = 11 },
                                                                 new MunVdc { Id = 520, DistrictId = 53, VdcMunType = 3, Name = "Krishna Nagar", WardCount = 12 },
                                                                 new MunVdc { Id = 521, DistrictId = 53, VdcMunType = 3, Name = "Banganga", WardCount = 11 },
                                                                 new MunVdc { Id = 522, DistrictId = 53, VdcMunType = 4, Name = "Mayadevi", WardCount = 8 },
                                                                 new MunVdc { Id = 523, DistrictId = 53, VdcMunType = 4, Name = "Yashodhara", WardCount = 8 },
                                                                 new MunVdc { Id = 524, DistrictId = 53, VdcMunType = 4, Name = "Suddodhana", WardCount = 6 },
                                                                 new MunVdc { Id = 525, DistrictId = 53, VdcMunType = 4, Name = "Bijay Nagar", WardCount = 7 },


                                                                 new MunVdc { Id = 526, DistrictId = 54, VdcMunType = 3, Name = "Bardghat", WardCount = 16 },
                                                                 new MunVdc { Id = 527, DistrictId = 54, VdcMunType = 3, Name = "Ramgram", WardCount = 18 },
                                                                 new MunVdc { Id = 528, DistrictId = 54, VdcMunType = 3, Name = "Sunwal", WardCount = 13 },
                                                                 new MunVdc { Id = 529, DistrictId = 54, VdcMunType = 4, Name = "Susta", WardCount = 7 },
                                                                 new MunVdc { Id = 530, DistrictId = 54, VdcMunType = 4, Name = "Palhinand", WardCount = 6 },
                                                                 new MunVdc { Id = 531, DistrictId = 54, VdcMunType = 4, Name = "Pratappur", WardCount = 9 },
                                                                 new MunVdc { Id = 532, DistrictId = 54, VdcMunType = 4, Name = "Sarawal", WardCount = 7 },


                                                                 new MunVdc { Id = 533, DistrictId = 55, VdcMunType = 3, Name = "Rampur", WardCount = 10 },
                                                                 new MunVdc { Id = 534, DistrictId = 55, VdcMunType = 3, Name = "Tansen", WardCount = 14 },
                                                                 new MunVdc { Id = 535, DistrictId = 55, VdcMunType = 4, Name = "Nisdi", WardCount = 7 },
                                                                 new MunVdc { Id = 536, DistrictId = 55, VdcMunType = 4, Name = "Purba Khola", WardCount = 6 },
                                                                 new MunVdc { Id = 537, DistrictId = 55, VdcMunType = 4, Name = "Rambha", WardCount = 5 },
                                                                 new MunVdc { Id = 538, DistrictId = 55, VdcMunType = 4, Name = "Matha Gadhi", WardCount = 8 },
                                                                 new MunVdc { Id = 539, DistrictId = 55, VdcMunType = 4, Name = "Tinau", WardCount = 6 },
                                                                 new MunVdc { Id = 540, DistrictId = 55, VdcMunType = 4, Name = "Bagnaskali", WardCount = 9 },
                                                                 new MunVdc { Id = 541, DistrictId = 55, VdcMunType = 4, Name = "Ribdikot", WardCount = 8 },
                                                                 new MunVdc { Id = 542, DistrictId = 55, VdcMunType = 4, Name = "Raina Devi Chhahara", WardCount = 8 },


                                                                 new MunVdc { Id = 543, DistrictId = 56, VdcMunType = 3, Name = "Pyuthan", WardCount = 10 },
                                                                 new MunVdc { Id = 544, DistrictId = 56, VdcMunType = 3, Name = "Swargadwari", WardCount = 9 },
                                                                 new MunVdc { Id = 545, DistrictId = 56, VdcMunType = 4, Name = "Gaumukhi", WardCount = 7 },
                                                                 new MunVdc { Id = 546, DistrictId = 56, VdcMunType = 4, Name = "Mandavi", WardCount = 5 },
                                                                 new MunVdc { Id = 547, DistrictId = 56, VdcMunType = 4, Name = "Sarumarani", WardCount = 6 },
                                                                 new MunVdc { Id = 548, DistrictId = 56, VdcMunType = 4, Name = "Mallarani", WardCount = 5 },
                                                                 new MunVdc { Id = 549, DistrictId = 56, VdcMunType = 4, Name = "Nau Bahini", WardCount = 8 },
                                                                 new MunVdc { Id = 550, DistrictId = 56, VdcMunType = 4, Name = "Jhimaruk", WardCount = 8 },
                                                                 new MunVdc { Id = 551, DistrictId = 56, VdcMunType = 4, Name = "Eairabati", WardCount = 6 },


                                                                 new MunVdc { Id = 552, DistrictId = 57, VdcMunType = 3, Name = "Rolpa", WardCount = 10 },
                                                                 new MunVdc { Id = 553, DistrictId = 57, VdcMunType = 4, Name = "Triveni", WardCount = 7 },
                                                                 new MunVdc { Id = 554, DistrictId = 57, VdcMunType = 4, Name = "Dui Kholi", WardCount = 6 },
                                                                 new MunVdc { Id = 555, DistrictId = 57, VdcMunType = 4, Name = "Madi", WardCount = 6 },
                                                                 new MunVdc { Id = 556, DistrictId = 57, VdcMunType = 4, Name = "Runti Gadhi", WardCount = 9 },
                                                                 new MunVdc { Id = 557, DistrictId = 57, VdcMunType = 4, Name = "Lungri", WardCount = 7 },
                                                                 new MunVdc { Id = 558, DistrictId = 57, VdcMunType = 4, Name = "Sukidaha", WardCount = 7 },
                                                                 new MunVdc { Id = 559, DistrictId = 57, VdcMunType = 4, Name = "Sunchhahari", WardCount = 7 },
                                                                 new MunVdc { Id = 560, DistrictId = 57, VdcMunType = 4, Name = "Subarnawati", WardCount = 8 },
                                                                 new MunVdc { Id = 561, DistrictId = 57, VdcMunType = 4, Name = "Thawang", WardCount = 5 },


                                                                 new MunVdc { Id = 562, DistrictId = 58, VdcMunType = 2, Name = "Butwal", WardCount = 19 },
                                                                 new MunVdc { Id = 563, DistrictId = 58, VdcMunType = 3, Name = "Devdaha", WardCount = 12 },
                                                                 new MunVdc { Id = 564, DistrictId = 58, VdcMunType = 3, Name = "Lumbini Sanskritik", WardCount = 13 },
                                                                 new MunVdc { Id = 565, DistrictId = 58, VdcMunType = 3, Name = "Siddharthanagar", WardCount = 13 },
                                                                 new MunVdc { Id = 566, DistrictId = 58, VdcMunType = 3, Name = "Saina Maina", WardCount = 11 },
                                                                 new MunVdc { Id = 567, DistrictId = 58, VdcMunType = 3, Name = "Tilottama", WardCount = 17 },
                                                                 new MunVdc { Id = 568, DistrictId = 58, VdcMunType = 4, Name = "Gaidahawa", WardCount = 9 },
                                                                 new MunVdc { Id = 569, DistrictId = 58, VdcMunType = 4, Name = "Kanchan", WardCount = 5 },
                                                                 new MunVdc { Id = 570, DistrictId = 58, VdcMunType = 4, Name = "Kotahi Mai", WardCount = 7 },
                                                                 new MunVdc { Id = 571, DistrictId = 58, VdcMunType = 4, Name = "Marchawari", WardCount = 7 },
                                                                 new MunVdc { Id = 572, DistrictId = 58, VdcMunType = 4, Name = "Mayadevi", WardCount = 8 },
                                                                 new MunVdc { Id = 573, DistrictId = 58, VdcMunType = 4, Name = "Om Satiya", WardCount = 6 },
                                                                 new MunVdc { Id = 574, DistrictId = 58, VdcMunType = 4, Name = "Rohini", WardCount = 7 },
                                                                 new MunVdc { Id = 575, DistrictId = 58, VdcMunType = 4, Name = "Sammari Mai", WardCount = 7 },
                                                                 new MunVdc { Id = 576, DistrictId = 58, VdcMunType = 4, Name = "Siyari", WardCount = 7 },
                                                                 new MunVdc { Id = 577, DistrictId = 58, VdcMunType = 4, Name = "Suddodhana", WardCount = 7 },


                                                                 new MunVdc { Id = 578, DistrictId = 59, VdcMunType = 3, Name = "Narayan", WardCount = 11 },
                                                                 new MunVdc { Id = 579, DistrictId = 59, VdcMunType = 3, Name = "Dullu", WardCount = 13 },
                                                                 new MunVdc { Id = 580, DistrictId = 59, VdcMunType = 3, Name = "Chamunda Bindrasaini", WardCount = 9 },
                                                                 new MunVdc { Id = 581, DistrictId = 59, VdcMunType = 3, Name = "Aathabis", WardCount = 9 },
                                                                 new MunVdc { Id = 582, DistrictId = 59, VdcMunType = 4, Name = "Bhagawati Mai", WardCount = 7 },
                                                                 new MunVdc { Id = 583, DistrictId = 59, VdcMunType = 4, Name = "Gurans", WardCount = 8 },
                                                                 new MunVdc { Id = 584, DistrictId = 59, VdcMunType = 4, Name = "Dungeshwor", WardCount = 6 },
                                                                 new MunVdc { Id = 585, DistrictId = 59, VdcMunType = 4, Name = "Naumule", WardCount = 8 },
                                                                 new MunVdc { Id = 586, DistrictId = 59, VdcMunType = 4, Name = "Mahabu", WardCount = 6 },
                                                                 new MunVdc { Id = 587, DistrictId = 59, VdcMunType = 4, Name = "Bairavi", WardCount = 7 },
                                                                 new MunVdc { Id = 588, DistrictId = 59, VdcMunType = 4, Name = "Thantikandh", WardCount = 6 },


                                                                 new MunVdc { Id = 589, DistrictId = 60, VdcMunType = 3, Name = "Thuli Bheri", WardCount = 11 },
                                                                 new MunVdc { Id = 590, DistrictId = 60, VdcMunType = 3, Name = "Tripura Sundari", WardCount = 11 },
                                                                 new MunVdc { Id = 591, DistrictId = 60, VdcMunType = 4, Name = "Dolpo Buddha", WardCount = 6 },
                                                                 new MunVdc { Id = 592, DistrictId = 60, VdcMunType = 4, Name = "She-Phoksundo", WardCount = 9 },
                                                                 new MunVdc { Id = 593, DistrictId = 60, VdcMunType = 4, Name = "Jagadulla", WardCount = 6 },
                                                                 new MunVdc { Id = 594, DistrictId = 60, VdcMunType = 4, Name = "Mudke Chula Gaun", WardCount = 9 },
                                                                 new MunVdc { Id = 595, DistrictId = 60, VdcMunType = 4, Name = "Kaieke", WardCount = 7 },
                                                                 new MunVdc { Id = 596, DistrictId = 60, VdcMunType = 4, Name = "Chharka Tongsong", WardCount = 6 },


                                                                 new MunVdc { Id = 597, DistrictId = 61, VdcMunType = 4, Name = "Simkot", WardCount = 8 },
                                                                 new MunVdc { Id = 598, DistrictId = 61, VdcMunType = 4, Name = "Namkha", WardCount = 6 },
                                                                 new MunVdc { Id = 599, DistrictId = 61, VdcMunType = 4, Name = "Kharpu Nath", WardCount = 5 },
                                                                 new MunVdc { Id = 600, DistrictId = 61, VdcMunType = 4, Name = "Sarkegad", WardCount = 8 },
                                                                 new MunVdc { Id = 601, DistrictId = 61, VdcMunType = 4, Name = "Chankheli", WardCount = 6 },
                                                                 new MunVdc { Id = 602, DistrictId = 61, VdcMunType = 4, Name = "Adanchuli", WardCount = 6 },
                                                                 new MunVdc { Id = 603, DistrictId = 61, VdcMunType = 4, Name = "Tanjakot", WardCount = 5 },


                                                                 new MunVdc { Id = 604, DistrictId = 62, VdcMunType = 3, Name = "Bheri", WardCount = 13 },
                                                                 new MunVdc { Id = 605, DistrictId = 62, VdcMunType = 3, Name = "Chhedagad", WardCount = 13 },
                                                                 new MunVdc { Id = 606, DistrictId = 62, VdcMunType = 3, Name = "Triveni Nalghad", WardCount = 13 },
                                                                 new MunVdc { Id = 607, DistrictId = 62, VdcMunType = 4, Name = "Kuse", WardCount = 9 },
                                                                 new MunVdc { Id = 608, DistrictId = 62, VdcMunType = 4, Name = "Junichande", WardCount = 11 },
                                                                 new MunVdc { Id = 609, DistrictId = 62, VdcMunType = 4, Name = "Barekot", WardCount = 9 },
                                                                 new MunVdc { Id = 610, DistrictId = 62, VdcMunType = 4, Name = "Shivalaya", WardCount = 9 },


                                                                 new MunVdc { Id = 611, DistrictId = 63, VdcMunType = 3, Name = "Chandannath", WardCount = 10 },
                                                                 new MunVdc { Id = 612, DistrictId = 63, VdcMunType = 4, Name = "Kanaka Sundari", WardCount = 8 },
                                                                 new MunVdc { Id = 613, DistrictId = 63, VdcMunType = 4, Name = "Sinja", WardCount = 6 },
                                                                 new MunVdc { Id = 614, DistrictId = 63, VdcMunType = 4, Name = "Hima", WardCount = 7 },
                                                                 new MunVdc { Id = 615, DistrictId = 63, VdcMunType = 4, Name = "Tila", WardCount = 9 },
                                                                 new MunVdc { Id = 616, DistrictId = 63, VdcMunType = 4, Name = "Guthichaur", WardCount = 5 },
                                                                 new MunVdc { Id = 617, DistrictId = 63, VdcMunType = 4, Name = "Tatopani", WardCount = 8 },
                                                                 new MunVdc { Id = 618, DistrictId = 63, VdcMunType = 4, Name = "Patarasi", WardCount = 7 },


                                                                 new MunVdc { Id = 619, DistrictId = 64, VdcMunType = 3, Name = "Khandachakra", WardCount = 11 },
                                                                 new MunVdc { Id = 620, DistrictId = 64, VdcMunType = 3, Name = "Raskot", WardCount = 9 },
                                                                 new MunVdc { Id = 621, DistrictId = 64, VdcMunType = 3, Name = "Tila Gupha", WardCount = 11 },
                                                                 new MunVdc { Id = 622, DistrictId = 64, VdcMunType = 4, Name = "Pachal Jharana", WardCount = 9 },
                                                                 new MunVdc { Id = 623, DistrictId = 64, VdcMunType = 4, Name = "Sanni Triveni", WardCount = 9 },
                                                                 new MunVdc { Id = 624, DistrictId = 64, VdcMunType = 4, Name = "Narhari Nath", WardCount = 9 },
                                                                 new MunVdc { Id = 625, DistrictId = 64, VdcMunType = 4, Name = "Kalika", WardCount = 8 },
                                                                 new MunVdc { Id = 626, DistrictId = 64, VdcMunType = 4, Name = "Mahawai", WardCount = 7 },
                                                                 new MunVdc { Id = 627, DistrictId = 64, VdcMunType = 4, Name = "Palata", WardCount = 9 },


                                                                 new MunVdc { Id = 628, DistrictId = 65, VdcMunType = 3, Name = "Chhaya Nath Rara", WardCount = 11 },
                                                                 new MunVdc { Id = 629, DistrictId = 65, VdcMunType = 4, Name = "Mugumakarmarong", WardCount = 11 },
                                                                 new MunVdc { Id = 630, DistrictId = 65, VdcMunType = 4, Name = "Soru", WardCount = 11 },
                                                                 new MunVdc { Id = 631, DistrictId = 65, VdcMunType = 4, Name = "Khatyad", WardCount = 11 },


                                                                 new MunVdc { Id = 632, DistrictId = 66, VdcMunType = 3, Name = "Sharada", WardCount = 15 },
                                                                 new MunVdc { Id = 633, DistrictId = 66, VdcMunType = 3, Name = "Bagchaur", WardCount = 12 },
                                                                 new MunVdc { Id = 634, DistrictId = 66, VdcMunType = 3, Name = "Bangad Kupinde", WardCount = 12 },
                                                                 new MunVdc { Id = 635, DistrictId = 66, VdcMunType = 4, Name = "Kalimati", WardCount = 7 },
                                                                 new MunVdc { Id = 636, DistrictId = 66, VdcMunType = 4, Name = "Triveni", WardCount = 6 },
                                                                 new MunVdc { Id = 637, DistrictId = 66, VdcMunType = 4, Name = "Kapurkot", WardCount = 6 },
                                                                 new MunVdc { Id = 638, DistrictId = 66, VdcMunType = 4, Name = "Chhatreshwori", WardCount = 7 },
                                                                 new MunVdc { Id = 639, DistrictId = 66, VdcMunType = 4, Name = "Dhorchaur", WardCount = 5 },
                                                                 new MunVdc { Id = 640, DistrictId = 66, VdcMunType = 4, Name = "Kumakha Malika", WardCount = 7 },
                                                                 new MunVdc { Id = 641, DistrictId = 66, VdcMunType = 4, Name = "Darma", WardCount = 6 },


                                                                 new MunVdc { Id = 642, DistrictId = 67, VdcMunType = 3, Name = "Birendra Nagar", WardCount = 16 },
                                                                 new MunVdc { Id = 643, DistrictId = 67, VdcMunType = 3, Name = "Bheri Ganga", WardCount = 13 },
                                                                 new MunVdc { Id = 644, DistrictId = 67, VdcMunType = 3, Name = "Gurbhakot", WardCount = 14 },
                                                                 new MunVdc { Id = 645, DistrictId = 67, VdcMunType = 3, Name = "Panchapuri", WardCount = 11 },
                                                                 new MunVdc { Id = 646, DistrictId = 67, VdcMunType = 3, Name = "Lek Besi", WardCount = 10 },
                                                                 new MunVdc { Id = 647, DistrictId = 67, VdcMunType = 4, Name = "Chaukune", WardCount = 10 },
                                                                 new MunVdc { Id = 648, DistrictId = 67, VdcMunType = 4, Name = "Baraha Tal", WardCount = 10 },
                                                                 new MunVdc { Id = 649, DistrictId = 67, VdcMunType = 4, Name = "Chingad", WardCount = 6 },
                                                                 new MunVdc { Id = 650, DistrictId = 67, VdcMunType = 4, Name = "Simta", WardCount = 9 },


                                                                 new MunVdc { Id = 651, DistrictId = 68, VdcMunType = 3, Name = "Musikot", WardCount = 14 },
                                                                 new MunVdc { Id = 652, DistrictId = 68, VdcMunType = 3, Name = "Chaujahari", WardCount = 14 },
                                                                 new MunVdc { Id = 653, DistrictId = 68, VdcMunType = 3, Name = "Aathabiskot", WardCount = 14 },
                                                                 new MunVdc { Id = 654, DistrictId = 68, VdcMunType = 4, Name = "Triveni", WardCount = 10 },
                                                                 new MunVdc { Id = 655, DistrictId = 68, VdcMunType = 4, Name = "Barphikot", WardCount = 10 },
                                                                 new MunVdc { Id = 656, DistrictId = 68, VdcMunType = 4, Name = "Sani Bheri", WardCount = 11 },


                                                                 new MunVdc { Id = 657, DistrictId = 69, VdcMunType = 3, Name = "Mangalsen", WardCount = 14 },
                                                                 new MunVdc { Id = 658, DistrictId = 69, VdcMunType = 3, Name = "Sanfebagar", WardCount = 14 },
                                                                 new MunVdc { Id = 659, DistrictId = 69, VdcMunType = 3, Name = "Kamalbazar", WardCount = 10 },
                                                                 new MunVdc { Id = 660, DistrictId = 69, VdcMunType = 3, Name = "Panchdeval Jayagad", WardCount = 9 },
                                                                 new MunVdc { Id = 661, DistrictId = 69, VdcMunType = 4, Name = "Chourpati", WardCount = 7 },
                                                                 new MunVdc { Id = 662, DistrictId = 69, VdcMunType = 4, Name = "Mellekh", WardCount = 8 },
                                                                 new MunVdc { Id = 663, DistrictId = 69, VdcMunType = 4, Name = "Bannigadhi Jayagadh", WardCount = 6 },
                                                                 new MunVdc { Id = 664, DistrictId = 69, VdcMunType = 4, Name = "RamaRoshan", WardCount = 7 },
                                                                 new MunVdc { Id = 665, DistrictId = 69, VdcMunType = 4, Name = "Dhakari", WardCount = 8 },
                                                                 new MunVdc { Id = 666, DistrictId = 69, VdcMunType = 4, Name = "Turmakhand", WardCount = 11 },


                                                                 new MunVdc { Id = 667, DistrictId = 70, VdcMunType = 3, Name = "Dasharath Chanda", WardCount = 11 },
                                                                 new MunVdc { Id = 668, DistrictId = 70, VdcMunType = 3, Name = "Patan", WardCount = 10 },
                                                                 new MunVdc { Id = 669, DistrictId = 70, VdcMunType = 3, Name = "Melauli", WardCount = 9 },
                                                                 new MunVdc { Id = 670, DistrictId = 70, VdcMunType = 3, Name = "Purchaundi", WardCount = 10 },
                                                                 new MunVdc { Id = 671, DistrictId = 70, VdcMunType = 4, Name = "Surnaiya", WardCount = 8 },
                                                                 new MunVdc { Id = 672, DistrictId = 70, VdcMunType = 4, Name = "Sigas", WardCount = 9 },
                                                                 new MunVdc { Id = 673, DistrictId = 70, VdcMunType = 4, Name = "Shivanath", WardCount = 6 },
                                                                 new MunVdc { Id = 674, DistrictId = 70, VdcMunType = 4, Name = "Pancheshwor", WardCount = 6 },
                                                                 new MunVdc { Id = 675, DistrictId = 70, VdcMunType = 4, Name = "Dogada Kedar", WardCount = 8 },
                                                                 new MunVdc { Id = 676, DistrictId = 70, VdcMunType = 4, Name = "Dilasaini", WardCount = 7 },


                                                                 new MunVdc { Id = 677, DistrictId = 71, VdcMunType = 3, Name = "Jaya Prithvi", WardCount = 11 },
                                                                 new MunVdc { Id = 678, DistrictId = 71, VdcMunType = 3, Name = "Bungal", WardCount = 11 },
                                                                 new MunVdc { Id = 679, DistrictId = 71, VdcMunType = 4, Name = "Talkot", WardCount = 7 },
                                                                 new MunVdc { Id = 680, DistrictId = 71, VdcMunType = 4, Name = "Masta", WardCount = 7 },
                                                                 new MunVdc { Id = 681, DistrictId = 71, VdcMunType = 4, Name = "Khaptadchhanna", WardCount = 7 },
                                                                 new MunVdc { Id = 682, DistrictId = 71, VdcMunType = 4, Name = "Thalara", WardCount = 9 },
                                                                 new MunVdc { Id = 683, DistrictId = 71, VdcMunType = 4, Name = "Bitthadchir", WardCount = 9 },
                                                                 new MunVdc { Id = 684, DistrictId = 71, VdcMunType = 4, Name = "Surma", WardCount = 5 },
                                                                 new MunVdc { Id = 685, DistrictId = 71, VdcMunType = 4, Name = "Chhabis Pathibhera", WardCount = 7 },
                                                                 new MunVdc { Id = 686, DistrictId = 71, VdcMunType = 4, Name = "Durgathali", WardCount = 7 },
                                                                 new MunVdc { Id = 687, DistrictId = 71, VdcMunType = 4, Name = "Kedarsyun", WardCount = 9 },
                                                                 new MunVdc { Id = 688, DistrictId = 71, VdcMunType = 4, Name = "Kanda", WardCount = 5 },


                                                                 new MunVdc { Id = 689, DistrictId = 72, VdcMunType = 3, Name = "Badi Malika", WardCount = 9 },
                                                                 new MunVdc { Id = 690, DistrictId = 72, VdcMunType = 3, Name = "Budhi Ganga", WardCount = 9 },
                                                                 new MunVdc { Id = 691, DistrictId = 72, VdcMunType = 3, Name = "Budhi Nanda", WardCount = 10 },
                                                                 new MunVdc { Id = 692, DistrictId = 72, VdcMunType = 3, Name = "Gaumul", WardCount = 10 },
                                                                 new MunVdc { Id = 693, DistrictId = 72, VdcMunType = 4, Name = "Pandav Gupha", WardCount = 6 },
                                                                 new MunVdc { Id = 694, DistrictId = 72, VdcMunType = 4, Name = "Swamikartik", WardCount = 6 },
                                                                 new MunVdc { Id = 695, DistrictId = 72, VdcMunType = 4, Name = "Chhededaha", WardCount = 5 },
                                                                 new MunVdc { Id = 696, DistrictId = 72, VdcMunType = 4, Name = "Himali", WardCount = 7 },


                                                                 new MunVdc { Id = 697, DistrictId = 73, VdcMunType = 3, Name = "Amargadhi", WardCount = 11 },
                                                                 new MunVdc { Id = 698, DistrictId = 73, VdcMunType = 3, Name = "Parashuram", WardCount = 12 },
                                                                 new MunVdc { Id = 699, DistrictId = 73, VdcMunType = 4, Name = "Aalitaal", WardCount = 8 },
                                                                 new MunVdc { Id = 700, DistrictId = 73, VdcMunType = 4, Name = "Bhageshwor", WardCount = 5 },
                                                                 new MunVdc { Id = 701, DistrictId = 73, VdcMunType = 4, Name = "Navadurga", WardCount = 5 },
                                                                 new MunVdc { Id = 702, DistrictId = 73, VdcMunType = 4, Name = "Ajaymeru", WardCount = 6 },
                                                                 new MunVdc { Id = 703, DistrictId = 73, VdcMunType = 4, Name = "Ganyapdhura", WardCount = 5 },


                                                                 new MunVdc { Id = 704, DistrictId = 74, VdcMunType = 3, Name = "Mahakali", WardCount = 9 },
                                                                 new MunVdc { Id = 705, DistrictId = 74, VdcMunType = 3, Name = "Sailya Shikhar", WardCount = 9 },
                                                                 new MunVdc { Id = 706, DistrictId = 74, VdcMunType = 4, Name = "Malikarjun", WardCount = 8 },
                                                                 new MunVdc { Id = 707, DistrictId = 74, VdcMunType = 4, Name = "Api Himal", WardCount = 6 },
                                                                 new MunVdc { Id = 708, DistrictId = 74, VdcMunType = 4, Name = "Duhun", WardCount = 5 },
                                                                 new MunVdc { Id = 709, DistrictId = 74, VdcMunType = 4, Name = "Naugad", WardCount = 6 },
                                                                 new MunVdc { Id = 710, DistrictId = 74, VdcMunType = 4, Name = "Marma", WardCount = 6 },
                                                                 new MunVdc { Id = 711, DistrictId = 74, VdcMunType = 4, Name = "Lekam", WardCount = 6 },
                                                                 new MunVdc { Id = 712, DistrictId = 74, VdcMunType = 4, Name = "Byans", WardCount = 6 },


                                                                 new MunVdc { Id = 713, DistrictId = 75, VdcMunType = 3, Name = "Dipayal Silgadi", WardCount = 9 },
                                                                 new MunVdc { Id = 714, DistrictId = 75, VdcMunType = 3, Name = "Shikhar", WardCount = 11 },
                                                                 new MunVdc { Id = 715, DistrictId = 75, VdcMunType = 4, Name = "Purbi Chouki", WardCount = 7 },
                                                                 new MunVdc { Id = 716, DistrictId = 75, VdcMunType = 4, Name = "Badikedar", WardCount = 5 },
                                                                 new MunVdc { Id = 717, DistrictId = 75, VdcMunType = 4, Name = "Jorayal", WardCount = 6 },
                                                                 new MunVdc { Id = 718, DistrictId = 75, VdcMunType = 4, Name = "Sayal", WardCount = 6 },
                                                                 new MunVdc { Id = 719, DistrictId = 75, VdcMunType = 4, Name = "Aadarsha", WardCount = 7 },
                                                                 new MunVdc { Id = 720, DistrictId = 75, VdcMunType = 4, Name = "K.I.Singh", WardCount = 7 },
                                                                 new MunVdc { Id = 721, DistrictId = 75, VdcMunType = 4, Name = "Bogtan", WardCount = 7 },


                                                                 new MunVdc { Id = 722, DistrictId = 76, VdcMunType = 2, Name = "Dhangadi", WardCount = 19 },
                                                                 new MunVdc { Id = 723, DistrictId = 76, VdcMunType = 3, Name = "Tikapur", WardCount = 9 },
                                                                 new MunVdc { Id = 724, DistrictId = 76, VdcMunType = 3, Name = "Ghodaghodi", WardCount = 12 },
                                                                 new MunVdc { Id = 725, DistrictId = 76, VdcMunType = 3, Name = "Lamki Chuha", WardCount = 10 },
                                                                 new MunVdc { Id = 726, DistrictId = 76, VdcMunType = 3, Name = "Bhajani", WardCount = 9 },
                                                                 new MunVdc { Id = 727, DistrictId = 76, VdcMunType = 3, Name = "Godavari", WardCount = 12 },
                                                                 new MunVdc { Id = 728, DistrictId = 76, VdcMunType = 3, Name = "Gauri Ganga", WardCount = 11 },
                                                                 new MunVdc { Id = 729, DistrictId = 76, VdcMunType = 4, Name = "Janaki", WardCount = 9 },
                                                                 new MunVdc { Id = 730, DistrictId = 76, VdcMunType = 4, Name = "Bardagoriya", WardCount = 6 },
                                                                 new MunVdc { Id = 731, DistrictId = 76, VdcMunType = 4, Name = "Mohanyal", WardCount = 7 },
                                                                 new MunVdc { Id = 732, DistrictId = 76, VdcMunType = 4, Name = "Kailari", WardCount = 9 },
                                                                 new MunVdc { Id = 733, DistrictId = 76, VdcMunType = 4, Name = "Joshipur", WardCount = 7 },
                                                                 new MunVdc { Id = 734, DistrictId = 76, VdcMunType = 4, Name = "Chure", WardCount = 6 },


                                                                 new MunVdc { Id = 735, DistrictId = 77, VdcMunType = 3, Name = "Bhimdatta", WardCount = 19 },
                                                                 new MunVdc { Id = 736, DistrictId = 77, VdcMunType = 3, Name = "Punarbas", WardCount = 11 },
                                                                 new MunVdc { Id = 737, DistrictId = 77, VdcMunType = 3, Name = "Bedkot", WardCount = 10 },
                                                                 new MunVdc { Id = 738, DistrictId = 77, VdcMunType = 3, Name = "Mahakali", WardCount = 10 },
                                                                 new MunVdc { Id = 739, DistrictId = 77, VdcMunType = 3, Name = "Shuklaphanta", WardCount = 10 },
                                                                 new MunVdc { Id = 740, DistrictId = 77, VdcMunType = 3, Name = "Belauri", WardCount = 10 },
                                                                 new MunVdc { Id = 741, DistrictId = 77, VdcMunType = 3, Name = "Krishnapur", WardCount = 9 },
                                                                 new MunVdc { Id = 742, DistrictId = 77, VdcMunType = 4, Name = "Beldandi", WardCount = 5 },
                                                                 new MunVdc { Id = 743, DistrictId = 77, VdcMunType = 4, Name = "Laljhadi", WardCount = 6 });

            builder.Entity<AddressType>().ToTable("AddressType").HasData(new AddressType { Id=1, Name="Permanent"}, 
                                                                            new AddressType { Id = 2, Name = "Temporary" });
            builder.Entity<IdentityType>().ToTable("IdentityType").HasData(new IdentityType { Id=1, Name="Passport"},
                                                                            new IdentityType { Id = 2, Name = "Nagrikta" }, 
                                                                            new IdentityType { Id = 3, Name = "Liscence" });
            builder.Entity<Address>().ToTable("Address");
            builder.Entity<Gender>().ToTable("Gender").HasData(new Gender { Id=1, Name= "Male" }, 
                                                                new Gender { Id = 2, Name = "Female" },
                                                                new Gender { Id = 3, Name = "Third Gender" },
                                                                new Gender { Id = 4, Name = "Other" });
            builder.Entity<Cast>().ToTable("Cast").HasData(new Cast {Id=1, Name= "Magar" }, 
                                                            new Cast { Id = 2, Name = "Gurung" },
                                                            new Cast { Id = 3, Name = "Brahmin" },
                                                            new Cast { Id = 4, Name = "Chettri" },
                                                            new Cast { Id = 5, Name = "Chantayal" },
                                                            new Cast { Id = 6, Name = "Damai" },
                                                            new Cast { Id = 7, Name = "Sanyasi" },
                                                            new Cast { Id = 8, Name = "Kami" },
                                                            new Cast { Id = 9, Name = "Sarki" },
                                                            new Cast { Id = 10, Name = "Gaine" },
                                                            new Cast { Id = 11, Name = "Otehr" });
            builder.Entity<MaritalStatus>().ToTable("MaritalStatus").HasData(new MaritalStatus { Id=1, Name= "UnMarried" },
                                                                                new MaritalStatus { Id = 2, Name = "Married" },
                                                                                new MaritalStatus { Id = 3, Name = "ReMarried" },
                                                                                new MaritalStatus { Id = 4, Name = "Widow/Widower" },
                                                                                new MaritalStatus { Id = 5, Name = "Divorced" });                  
            builder.Entity<Religion>().ToTable("Religion").HasData(new Religion { Id=1, Name= "Hindu" },
                                                                    new Religion { Id = 2, Name = "Buddhist" },
                                                                    new Religion { Id = 3, Name = "Islam" },
                                                                    new Religion { Id = 4, Name = "Kirat" },
                                                                    new Religion { Id = 5, Name = "Christian" },
                                                                    new Religion { Id = 6, Name = "Other" });                          
            builder.Entity<Skill>().ToTable("Skill").HasData(new Skill { Id=1, Name= "Swening" },
                                                              new Skill { Id = 2, Name = "Handicraft" },
                                                              new Skill { Id = 3, Name = "Carpentry" },
                                                              new Skill { Id = 4, Name = "Mason" },
                                                              new Skill { Id = 5, Name = "Computer Training" },
                                                              new Skill { Id = 6, Name = "ZTA" },
                                                              new Skill { Id = 7, Name = "Cook/Waiter" },
                                                              new Skill { Id = 8, Name = "Beauty Palour" });

            builder.Entity<Language>().ToTable("Language").HasData(new Language { Id = 1, Name = "English" },
                                                              new Language { Id = 2, Name = "Nepali" },
                                                              new Language { Id = 3, Name = "Hindi" },
                                                              new Language { Id = 4, Name = "Chainees" });


            builder.Entity<Occupation>().ToTable("Occupation").HasData(new Occupation { Id=1,Name= "Agriculture" },
                                                                        new Occupation { Id = 2, Name = "Government School/Office" },
                                                                        new Occupation { Id = 3, Name = "Trade" },
                                                                        new Occupation { Id = 4, Name = "Pension" },
                                                                        new Occupation { Id = 5, Name = "Daily Wages" },
                                                                        new Occupation { Id = 6, Name = "Unemployed" },
                                                                        new Occupation { Id = 7, Name = "Student" },
                                                                        new Occupation { Id = 8, Name = "Non-Government Service" },
                                                                        new Occupation { Id = 9, Name = "Personal Industry" });                      
            builder.Entity<Litracy>().ToTable("Litracy").HasData(new Litracy { Id=1 , Name= "Illiterate" }, new Litracy { Id = 2, Name = "literate" });
            builder.Entity<HealthStatus>().ToTable("HealthStatus").HasData(new HealthStatus { Id=1, Name= "Disability" },
                                                                            new HealthStatus { Id = 2, Name = "Healthy" },
                                                                            new HealthStatus { Id = 3, Name = "Chronic Disease" },
                                                                            new HealthStatus { Id = 4, Name = "Other" });
            builder.Entity<WorkType>().ToTable("WorkType").HasData(new WorkType { Id=1, Name="Permanent"}, 
                                                                    new WorkType { Id = 2, Name = "Temporary" },
                                                                    new WorkType { Id = 3, Name = "Contract" });
            builder.Entity<Education>().ToTable("Education").HasData(new Education { Id=1, Name= "1-10" },
                                                                        new Education { Id = 2, Name = "11-12" },
                                                                         new Education { Id = 3, Name = "Bachelor" },
                                                                         new Education { Id = 4, Name = "Master" },
                                                                         new Education { Id = 5, Name = "PHD." },
                                                                         new Education { Id = 6, Name = "No Grade" });
            builder.Entity<EduInstutionType>().ToTable("EduInstutionType").HasData(new EduInstutionType { Id=1, Name= "Private School" },
                                                                                   new EduInstutionType { Id = 2, Name = "Government School" },
                                                                                   new EduInstutionType { Id = 3, Name = "Community College" },
                                                                                   new EduInstutionType { Id = 4, Name = "Private College" },
                                                                                   new EduInstutionType { Id = 5, Name = "Technical School" },
                                                                                   new EduInstutionType { Id = 6, Name = "Gurukul" },
                                                                                   new EduInstutionType { Id = 7, Name = "Other" });
            builder.Entity<Office>().ToTable("Office");
            builder.Entity<Department>().ToTable("Department");           
            builder.Entity<PostCategory>().ToTable("PostCategory");
            builder.Entity<PayGrade>().ToTable("PayGrade");
            builder.Entity<Level>().ToTable("Level");
            builder.Entity<Post>().ToTable("Post");
            builder.Entity<Relation>().ToTable("Relation").HasData(new Relation { Id=1, Name= "House Hold Head" },
                                                                    new Relation { Id = 2, Name = "Wife/Husband" },
                                                                    new Relation { Id = 3, Name = "Son/Daughter" },
                                                                    new Relation { Id = 4, Name = "Grand Daughter/Son" },
                                                                    new Relation { Id = 5, Name = "Father/Mother" },
                                                                    new Relation { Id = 6, Name = "Brother/Sister" },
                                                                    new Relation { Id = 7, Name = "Daughter & Son - In - Law / Son & Daughter - In - Law" },
                                                                    new Relation { Id = 8, Name = "Brotehr & Son - In - Law" },
                                                                    new Relation { Id = 9, Name = "Sister - In - Law / Brother" },
                                                                    new Relation { Id = 10, Name = "Father & Mother - In - Law" },
                                                                    new Relation { Id = 11, Name = "Married Daughter" },
                                                                    new Relation { Id = 12, Name = "Brother - In - Law / Sister / Sister - In - Law" },
                                                                    new Relation { Id = 13, Name = "Relatives" },
                                                                    new Relation { Id = 14, Name = "No Relation" });
            builder.Entity<Service>().ToTable("Service");
            builder.Entity<Person>().ToTable("Person");
            builder.Entity<PersonEducation>().ToTable("PersonEducation");
            builder.Entity<PersonLanguage>().ToTable("PersonLanguage");
            builder.Entity<PersonSkill>().ToTable("PersonSkill");
            builder.Entity<OfficeDepartment>().ToTable("OfficeDepartment");
            builder.Entity<EmployeeJob>().ToTable("EmployeeJob");
            builder.Entity<Employee>().ToTable("Employee");
            builder.Entity<EmployeeDependent>().ToTable("EmployeeDependent");
            builder.Entity<DocumentRecord>().ToTable("DocumentRecord");
            builder.Entity<Holiday>().ToTable("Holiday");
            builder.Entity<LeaveType>().ToTable("LeaveType").HasData(new LeaveType { Id = 1, Name = "Annual Leave", IsActive = true },
                                                                       new LeaveType { Id = 2, Name = "Emergency Leave", IsActive = true },
                                                                       new LeaveType { Id = 3, Name = "Medical Leave", IsActive = true },
                                                                       new LeaveType { Id = 4, Name = "Day Off", IsActive = true });
            builder.Entity<DayType>().ToTable("DayType").HasData(new DayType { Id=1,Name="Full Day", IsActive=true},
                                                                new DayType { Id = 2, Name = "First Half", IsActive = true },
                                                                new DayType { Id = 3, Name = "Second Half", IsActive = true });
            builder.Entity<Leave>().ToTable("Leave");
            builder.Entity<Approver>().ToTable("Approver");
            builder.Entity<CarbonCopyer>().ToTable("CarbonCopyer");




            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }


            base.OnModelCreating(builder);
        }
        public  DbSet<Role> Roles { get; set; }
        public  DbSet<User> Users { get; set; }
        public DbSet<Country> Countrys { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<MunVdc> MunVdcs { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<IdentityType> IdentityTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<Religion> Religions { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Litracy> Litracys { get; set; }
        public DbSet<HealthStatus> HealthStatuses { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EduInstutionType> EduInstutionTypes { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<PostCategory> PostCategorys { get; set; }
        public DbSet<PayGrade> PayGrades { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Relation> Relations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonEducation> PersonEducations { get; set; }
        public DbSet<PersonLanguage> PersonLanguages { get; set; }
        public DbSet<PersonSkill> PersonSkills { get; set; }
        public DbSet<OfficeDepartment> OfficeDepartments { get; set; }
        public DbSet<EmployeeJob> EmployeeJobs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDependent> EmployeeDependents { get; set; }
        public DbSet<DocumentRecord> DocumentRecords { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<DayType> DayTypes { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Approver> Approvers { get; set; }
        public DbSet<CarbonCopyer> CarbonCopyers { get; set; }


        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }
      
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            AddTimestamps();
            return base.SaveChangesAsync(cancellationToken);
        }


        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is EntityBase && (x.State == EntityState.Added || x.State == EntityState.Modified));

            var userManager = _services.GetRequiredService<IUserRepository>();
            string currentUsername = userManager.LogCurrentUser();
            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((EntityBase)entity.Entity).DateCreated = DateTime.UtcNow;
                    ((EntityBase)entity.Entity).UserCreated = currentUsername;
                }

                ((EntityBase)entity.Entity).DateModified = DateTime.UtcNow;
                ((EntityBase)entity.Entity).UserModified = currentUsername;
            }
        }
    }
}
