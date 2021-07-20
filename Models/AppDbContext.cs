using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using StudentLoan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentLoan.Models.Entities;

namespace StudentLoan.Models
{
    //Before creating a database ALWAYS BUILD SOLUTION FIRST, THEN OPEN NUGET PACKAGE MANAGER CONSOLE
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<SACourses> SACourses { get; set; }
        public DbSet<SAUniversity> SAUniversities { get; set; }
        public DbSet<SAUniCourse> SAUniCourses { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<MaritalStatus> MaritalStatus { get; set; }

        public static async Task CreateAdminAccount(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            UserManager<IdentityUser> userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = configuration["Data:AdminUser:Name"];
            string email = configuration["Data:AdminUser:Email"];
            string password = configuration["Data:AdminUser:Password"];
            string role = configuration["Data:AdminUser:Role"];
            
            if(await userManager.FindByNameAsync(username) == null)
            {
                if(await roleManager.FindByNameAsync(role) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
                IdentityUser user = new IdentityUser
                {
                    UserName = username,
                    Email = email
                };
                IdentityResult result = await userManager.CreateAsync(user, password);
                if(result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                }

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SAUniCourse>().HasKey(s => new { s.SACoursesId, s.SAUniversityId });

            modelBuilder.Entity<Gender>().HasData(
                new Gender { GenderId=1, GenderName="Female"},
                new Gender { GenderId=2, GenderName="Male"},
                new Gender { GenderId = 3, GenderName = "Prefer not to say" }
                );

            modelBuilder.Entity<Occupation>().HasData(
                new Occupation { OccupationId=1, OccupationName="Student"},
                new Occupation { OccupationId=2, OccupationName="Unemployed"},
                new Occupation { OccupationId=3, OccupationName="Employed"}
                );

            modelBuilder.Entity<MaritalStatus>().HasData(
                new MaritalStatus { MaritalStatusId=1, MaritlStatusName="Single"},
                new MaritalStatus { MaritalStatusId=2, MaritlStatusName="Married"},
                new MaritalStatus { MaritalStatusId=3, MaritlStatusName="Divorced"}
                );

            modelBuilder.Entity<SAUniversity>().HasData(
                new SAUniversity { SAUniversityId = 1, Name = "University of the Free State"},
                new SAUniversity { SAUniversityId = 2, Name = "University of Cape Town"},
                new SAUniversity { SAUniversityId = 3, Name = "University of Witwatersrand"},
                new SAUniversity { SAUniversityId = 4, Name = "University of Johannesburg"},
                new SAUniversity { SAUniversityId = 5, Name = "Cape Peninsula University of Technology"},
                new SAUniversity { SAUniversityId = 6, Name = "Tshwane University of Technology"},
                new SAUniversity { SAUniversityId = 7, Name = "Rhodes University"},
                new SAUniversity { SAUniversityId = 8, Name = "Nelson Mandela Metropolitan University"},
                new SAUniversity { SAUniversityId = 9, Name = "Stellenbosch University"},
                new SAUniversity { SAUniversityId = 10, Name = "University of Kwa-Zulu Natal"},
                new SAUniversity { SAUniversityId = 11, Name = "University of Pretoria" },
                new SAUniversity { SAUniversityId = 12, Name = "Central University of Technology"}
                );

            modelBuilder.Entity<SACourses>().HasData(
               new SACourses { SACoursesId = 1, Field = "Economics and Statistics", Course = "Economics Specialization (Development, Policy, Econometrics, Health, Mining, Transport and Financial) and Statistics Specialization", Undergrad = false, Postgrad = true, Cost = 90000 },
               new SACourses { SACoursesId = 2, Field = "Avionics", Course = "Air Craft Mechanics and Aviation Studies (Aeronautical Engineering)", Undergrad = true, Postgrad = true, Cost = 145000 },
               new SACourses { SACoursesId = 3, Field = "Avionics", Course = "Aeronautical information service (communication; navigation; surveillance)", Undergrad = true, Postgrad = true, Cost = 145000 },
               new SACourses { SACoursesId = 4, Field = "Avionics", Course = "Airport Maintenance", Undergrad = true, Postgrad = true, Cost = 145000 },
               new SACourses { SACoursesId = 5, Field = "Avionics", Course = "MBA Aviation", Undergrad = true, Postgrad = true, Cost = 145000 },
               new SACourses { SACoursesId = 6, Field = "Avionics", Course = "Cargo management (will be covered under supply chain management", Undergrad = true, Postgrad = true, Cost = 145000 },
               new SACourses { SACoursesId = 7, Field = "Health Sciences", Course = "Bsc Clinincal Psychology", Undergrad = true, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 8, Field = "Health Sciences", Course = "Medicine (MBCHB)", Undergrad = true, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 9, Field = "Health Sciences", Course = "Pharmacy", Undergrad = false, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 10, Field = "Health Sciences", Course = "Dentistry", Undergrad = true, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 11, Field = "Health Sciences", Course = "Radiography", Undergrad = true, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 12, Field = "Health Sciences", Course = "Physiotherapy", Undergrad = true, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 13, Field = "Health Sciences", Course = "Medical Emergency and Paramedics", Undergrad = true, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 14, Field = "Building Sciences", Course = "Civil Engineering", Undergrad = true, Postgrad = true, Cost = 150000 },
               new SACourses { SACoursesId = 15, Field = "Building Sciences", Course = "Construction Economics and Management", Undergrad = true, Postgrad = true, Cost = 150000 },
               new SACourses { SACoursesId = 16, Field = "Building Sciences", Course = "Hazard Safety and Risk Management", Undergrad = true, Postgrad = true, Cost = 150000 },
               new SACourses { SACoursesId = 17, Field = "Building Sciences", Course = "Quantity Survey", Undergrad = true, Postgrad = true, Cost = 150000 },
               new SACourses { SACoursesId = 18, Field = "Counselling Sciences, Policing and Investigative Studies", Course = "Policing and Criminology", Undergrad = true, Postgrad = true, Cost = 165000 },
               new SACourses { SACoursesId = 19, Field = "Counselling Sciences, Policing and Investigative Studies", Course = "Forensics and Ballistics", Undergrad = true, Postgrad = true, Cost = 165000 },
               new SACourses { SACoursesId = 20, Field = "Communiction Sciences", Course = "Communication, Broadcasting and Journalism", Undergrad = true, Postgrad = true, Cost = 165000 },
               new SACourses { SACoursesId = 21, Field = "Communication Sciences", Course = "Film studies and Photography", Undergrad = true, Postgrad = true, Cost = 165000 },
               new SACourses { SACoursesId = 22, Field = "Arts", Course = "Applied Arts, Digital Arts, Visual Arts, Artium", Undergrad = false, Postgrad = true, Cost = 85000 },
               new SACourses { SACoursesId = 23, Field = "Arts", Course = "Fashion Design and Graphic Design", Undergrad = false, Postgrad = true, Cost = 85000 },
               new SACourses { SACoursesId = 24, Field = "Arts", Course = "Textile and Clothing Technology", Undergrad = true, Postgrad = true, Cost = 85000 },
               new SACourses { SACoursesId = 25, Field = "Arts", Course = "Fine Arts", Undergrad = true, Postgrad = true, Cost = 85000 },
               new SACourses { SACoursesId = 26, Field = "Special and Technology Education and Linguistics", Course = "Foundation and Early Childhood Development", Undergrad = true, Postgrad = true, Cost = 85000 },
               new SACourses { SACoursesId = 27, Field = "Special and Technology Education and Linguistics", Course = "Special Education and Technology", Undergrad = true, Postgrad = true, Cost = 85000 },
               new SACourses { SACoursesId = 28, Field = "Special and Technology Education and Linguistics", Course = "Mathematics and Science Education", Undergrad = false, Postgrad = true, Cost = 85000 },
               new SACourses { SACoursesId = 29, Field = "Governance and Accountability", Course = "Energy Planning", Undergrad = false, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 30, Field = "Governance and Accountability", Course = "Trail Advocacy", Undergrad = false, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 31, Field = "Governance and Accountability", Course = "Contract Negotiation", Undergrad = false, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 32, Field = "Governance and Accountability", Course = "Mediation and Arbitration", Undergrad = false, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 33, Field = "Governance and Accountability", Course = "Prosecuting of Economic Offenses", Undergrad = false, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 34, Field = "Mining", Course = "Geology", Undergrad = true, Postgrad = true, Cost = 90000 },
               new SACourses { SACoursesId = 35, Field = "Mining", Course = "Geo-mechanism", Undergrad = true, Postgrad = true, Cost = 90000 },
               new SACourses { SACoursesId = 36, Field = "Mining", Course = "Geo-chemistry", Undergrad = true, Postgrad = true, Cost = 90000 },
               new SACourses { SACoursesId = 37, Field = "Mining", Course = "Geo-physics", Undergrad = true, Postgrad = true, Cost = 90000 },
               new SACourses { SACoursesId = 38, Field = "Mining", Course = "Mining Engineering and Mineral Extraction", Undergrad = true, Postgrad = true, Cost = 90000 },
               new SACourses { SACoursesId = 39, Field = "Mining", Course = "Metallurgy Engineering", Undergrad = true, Postgrad = true, Cost = 90000 },
               new SACourses { SACoursesId = 40, Field = "Engineering Science and Technology", Course = "Materials Science and Engineering", Undergrad = true, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 41, Field = "Engineering Science and Technology", Course = "Industrial and Systems Engineering", Undergrad = true, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 42, Field = "Engineering Science and Technology", Course = "Mechanical, Nuclear and Mechatronics Engineering", Undergrad = true, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 43, Field = "Engineering Science and Technology", Course = "Auto-electricity Engineering", Undergrad = true, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 44, Field = "Engineering Science and Technology", Course = "Chemical Engineering", Undergrad = true, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 45, Field = "Engineering Science and Technology", Course = "Electrical Engineering", Undergrad = true, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 46, Field = "Engineering Science and Technology", Course = "Computer Engineering", Undergrad = true, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 47, Field = "Engineering Science and Technology", Course = "Systems Engineering", Undergrad = true, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 48, Field = "Engineering Science and Technology", Course = "Information and Communication Technology", Undergrad = false, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 49, Field = "Engineering Science and Technology", Course = "Geographic Information Systems, Remote Sensing, Radar and Sonar Technology, and Cartography", Undergrad = true, Postgrad = true, Cost = 120000 },
               new SACourses { SACoursesId = 50, Field = "Disaster and Water Management", Course = "Meteorology and Agrometeorology", Undergrad = true, Postgrad = true, Cost = 105000 },
               new SACourses { SACoursesId = 51, Field = "Disaster and Water Management", Course = "Hydrology, Hydrogeology and Water Resources Management", Undergrad = true, Postgrad = true, Cost = 105000 },
               new SACourses { SACoursesId = 52, Field = "Disaster and Water Management", Course = "Water Engineering and Water Harvesting", Undergrad = true, Postgrad = true, Cost = 105000 },
               new SACourses { SACoursesId = 53, Field = "Disaster and Water Management", Course = "Water Laboratory Technology", Undergrad = true, Postgrad = true, Cost = 105000 },
               new SACourses { SACoursesId = 54, Field = "Disaster and Water Management", Course = "Disaster Management", Undergrad = false, Postgrad = true, Cost = 105000 },
               new SACourses { SACoursesId = 55, Field = "Tourism, Museum and Heritage Studies", Course = "Paleontology", Undergrad = true, Postgrad = true, Cost = 132000 },
               new SACourses { SACoursesId = 56, Field = "Tourism, Museum and Heritage Studies", Course = "Food Engineering", Undergrad = true, Postgrad = true, Cost = 132000 },
               new SACourses { SACoursesId = 57, Field = "Tourism, Museum and Heritage Studies", Course = "Food Processing and Technology", Undergrad = true, Postgrad = true, Cost = 132000 },
               new SACourses { SACoursesId = 58, Field = "Tourism, Museum and Heritage Studies", Course = "Zoology", Undergrad = true, Postgrad = true, Cost = 132000 },
               new SACourses { SACoursesId = 59, Field = "Tourism, Museum and Heritage Studies", Course = "Ethnology", Undergrad = true, Postgrad = true, Cost = 132000 },
               new SACourses { SACoursesId = 60, Field = "Acturial Sciences", Course = "Acturial Sciences, Insurance and Financial Mathematics/Science", Undergrad = true, Postgrad = true, Cost = 175000 },
               new SACourses { SACoursesId = 61, Field = "Investment Sciences and Management", Course = "Business Adminstration", Undergrad = false, Postgrad = true, Cost = 155000 },
               new SACourses { SACoursesId = 62, Field = "Investment Sciences and Management", Course = "BSc Investment Sciences", Undergrad = false, Postgrad = true, Cost = 155000 },
               new SACourses { SACoursesId = 63, Field = "Investment Sciences and Management", Course = "BSc Quantitative Risk Management (QRM)", Undergrad = true, Postgrad = true, Cost = 155000 },
               new SACourses { SACoursesId = 64, Field = "Investment Sciences and Management", Course = "Supply Chain Management and Logistics", Undergrad = true, Postgrad = true, Cost = 155000 },
               new SACourses { SACoursesId = 65, Field = "Forestry, Agriculture, Animal and Environmental Sciences", Course = "Conservation, Ecology, Arid and Range Management", Undergrad = true, Postgrad = false, Cost = 155000 },
               new SACourses { SACoursesId = 66, Field = "Forestry, Agriculture, Animal and Environmental Sciences", Course = "Veterinary Medicine", Undergrad = true, Postgrad = true, Cost = 155000 },
               new SACourses { SACoursesId = 67, Field = "Forestry, Agriculture, Animal and Environmental Sciences", Course = "Agriculture Engineering", Undergrad = false, Postgrad = true, Cost = 155000 },
               new SACourses { SACoursesId = 68, Field = "Forestry, Agriculture, Animal and Environmental Sciences", Course = "Seed Technology", Undergrad = true, Postgrad = true, Cost = 155000 },
               new SACourses { SACoursesId = 69, Field = "Forestry, Agriculture, Animal and Environmental Sciences", Course = "Fertilizer Production", Undergrad = false, Postgrad = true, Cost = 155000 },
               new SACourses { SACoursesId = 70, Field = "Forestry, Agriculture, Animal and Environmental Sciences", Course = "Horticulture/Greenhouse", Undergrad = false, Postgrad = true, Cost = 155000 },
               new SACourses { SACoursesId = 71, Field = "Health Sciences", Course = "Nuclear Medicine Specialist", Undergrad = true, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 72, Field = "Health Sciences", Course = "Analytical Chemistry", Undergrad = true, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 73, Field = "Health Sciences", Course = "Biomedical Engineering", Undergrad = true, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 74, Field = "Health Sciences", Course = "Clinical Technology", Undergrad = true, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 75, Field = "Health Sciences", Course = "Pathophysiology", Undergrad = true, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 76, Field = "Health Sciences", Course = "Auidiology and Speech-language pathology", Undergrad = true, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 77, Field = "Health Sciences", Course = "Orthopedics", Undergrad = true, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 78, Field = "Health Sciences", Course = "Radiation Oncology", Undergrad = true, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 79, Field = "Health Sciences", Course = "Neurosurgeon", Undergrad = false, Postgrad = true, Cost = 200000 },
               new SACourses { SACoursesId = 80, Field = "Health Sciences", Course = "Neurology", Undergrad = false, Postgrad = true, Cost = 200000 }
                );

            modelBuilder.Entity<SAUniCourse>().HasData(
                new SAUniCourse { SAUniversityId = 1, SACoursesId = 8 },
                new SAUniCourse { SAUniversityId = 1, SACoursesId = 78 },
                new SAUniCourse { SAUniversityId = 1, SACoursesId = 34 },
                new SAUniCourse { SAUniversityId = 1, SACoursesId = 36 },
                new SAUniCourse { SAUniversityId = 1, SACoursesId = 14 },
                new SAUniCourse { SAUniversityId = 1, SACoursesId = 17 },
                new SAUniCourse { SAUniversityId = 1, SACoursesId = 50 },
                new SAUniCourse { SAUniversityId = 1, SACoursesId = 54 },
                new SAUniCourse { SAUniversityId = 1, SACoursesId = 60 },
                new SAUniCourse { SAUniversityId = 1, SACoursesId = 61 },
                new SAUniCourse { SAUniversityId = 1, SACoursesId = 18 },
                new SAUniCourse { SAUniversityId = 1, SACoursesId = 20 },
                new SAUniCourse { SAUniversityId = 1, SACoursesId = 26 },
                new SAUniCourse { SAUniversityId = 1, SACoursesId = 27 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 8 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 11 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 10 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 78 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 34 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 37 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 44 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 45 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 46 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 47 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 48 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 1 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 14 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 15 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 17 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 66 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 65 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 55 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 57 },
                new SAUniCourse { SAUniversityId = 2, SACoursesId = 56 },
                new SAUniCourse { SAUniversityId = 3, SACoursesId = 1 },
                new SAUniCourse { SAUniversityId = 3, SACoursesId = 2 },
                new SAUniCourse { SAUniversityId = 3, SACoursesId = 7 },
                new SAUniCourse { SAUniversityId = 3, SACoursesId = 44 },
                new SAUniCourse { SAUniversityId = 3, SACoursesId = 47 },
                new SAUniCourse { SAUniversityId = 3, SACoursesId = 49 },
                new SAUniCourse { SAUniversityId = 3, SACoursesId = 14 },
                new SAUniCourse { SAUniversityId = 3, SACoursesId = 15 },
                new SAUniCourse { SAUniversityId = 3, SACoursesId = 16 },
                new SAUniCourse { SAUniversityId = 3, SACoursesId = 17 },
                new SAUniCourse { SAUniversityId = 3, SACoursesId = 50 },
                new SAUniCourse { SAUniversityId = 3, SACoursesId = 51 },
                new SAUniCourse { SAUniversityId = 3, SACoursesId = 52 },
                new SAUniCourse { SAUniversityId = 3, SACoursesId = 65 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 45 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 46 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 47 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 48 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 49 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 15 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 16 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 13 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 11 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 10 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 71 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 58 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 59 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 23 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 24 },
                new SAUniCourse { SAUniversityId = 4, SACoursesId = 25 },
                new SAUniCourse { SAUniversityId = 5, SACoursesId = 23 },
                new SAUniCourse { SAUniversityId = 5, SACoursesId = 24 },
                new SAUniCourse { SAUniversityId = 5, SACoursesId = 41 },
                new SAUniCourse { SAUniversityId = 5, SACoursesId = 42 },
                new SAUniCourse { SAUniversityId = 5, SACoursesId = 44 },
                new SAUniCourse { SAUniversityId = 5, SACoursesId = 45 },
                new SAUniCourse { SAUniversityId = 5, SACoursesId = 14 },
                new SAUniCourse { SAUniversityId = 5, SACoursesId = 15 },
                new SAUniCourse { SAUniversityId = 5, SACoursesId = 16 },
                new SAUniCourse { SAUniversityId = 5, SACoursesId = 17 },
                new SAUniCourse { SAUniversityId = 5, SACoursesId = 52 },
                new SAUniCourse { SAUniversityId = 6, SACoursesId = 44 },
                new SAUniCourse { SAUniversityId = 6, SACoursesId = 45 },
                new SAUniCourse { SAUniversityId = 6, SACoursesId = 46 },
                new SAUniCourse { SAUniversityId = 6, SACoursesId = 47 },
                new SAUniCourse { SAUniversityId = 6, SACoursesId = 48 },
                new SAUniCourse { SAUniversityId = 6, SACoursesId = 49 },
                new SAUniCourse { SAUniversityId = 6, SACoursesId = 17 },
                new SAUniCourse { SAUniversityId = 6, SACoursesId = 77 },
                new SAUniCourse { SAUniversityId = 6, SACoursesId = 40 },
                new SAUniCourse { SAUniversityId = 6, SACoursesId = 41 },
                new SAUniCourse { SAUniversityId = 7, SACoursesId = 34 },
                new SAUniCourse { SAUniversityId = 7, SACoursesId = 37 },
                new SAUniCourse { SAUniversityId = 7, SACoursesId = 20 },
                new SAUniCourse { SAUniversityId = 7, SACoursesId = 55 },
                new SAUniCourse { SAUniversityId = 7, SACoursesId = 56 },
                new SAUniCourse { SAUniversityId = 7, SACoursesId = 57 },
                new SAUniCourse { SAUniversityId = 7, SACoursesId = 58 },
                new SAUniCourse { SAUniversityId = 7, SACoursesId = 65 },
                new SAUniCourse { SAUniversityId = 7, SACoursesId = 7 },
                new SAUniCourse { SAUniversityId = 8, SACoursesId = 1 },
                new SAUniCourse { SAUniversityId = 8, SACoursesId = 7 },
                new SAUniCourse { SAUniversityId = 8, SACoursesId = 11 },
                new SAUniCourse { SAUniversityId = 8, SACoursesId = 15 },
                new SAUniCourse { SAUniversityId = 8, SACoursesId = 43 },
                new SAUniCourse { SAUniversityId = 8, SACoursesId = 45 },
                new SAUniCourse { SAUniversityId = 8, SACoursesId = 46 },
                new SAUniCourse { SAUniversityId = 8, SACoursesId = 47 },
                new SAUniCourse { SAUniversityId = 8, SACoursesId = 48 },
                new SAUniCourse { SAUniversityId = 8, SACoursesId = 49 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 1 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 16 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 44 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 45 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 41 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 42 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 36 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 22 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 25 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 77 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 78 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 79 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 80 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 12 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 65 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 60 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 62 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 63 },
                new SAUniCourse { SAUniversityId = 9, SACoursesId = 64 },
                new SAUniCourse { SAUniversityId = 10, SACoursesId = 50 },
                new SAUniCourse { SAUniversityId = 10, SACoursesId = 53 },
                new SAUniCourse { SAUniversityId = 10, SACoursesId = 65 },
                new SAUniCourse { SAUniversityId = 10, SACoursesId = 8 },
                new SAUniCourse { SAUniversityId = 10, SACoursesId = 42 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 34 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 35 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 36 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 37 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 38 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 39 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 43 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 45 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 14 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 15 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 16 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 17 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 7 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 8 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 10 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 12 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 76 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 77 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 78 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 73 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 79 },
                new SAUniCourse { SAUniversityId = 11, SACoursesId = 80 },
                new SAUniCourse { SAUniversityId = 12, SACoursesId = 27 },
                new SAUniCourse { SAUniversityId = 12, SACoursesId = 11 },
                new SAUniCourse { SAUniversityId = 12, SACoursesId = 17 },
                new SAUniCourse { SAUniversityId = 12, SACoursesId = 45 }
                );


            base.OnModelCreating(modelBuilder);
        }
    }
}
