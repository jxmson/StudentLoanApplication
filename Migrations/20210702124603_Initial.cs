using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentLoan.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SACourses",
                columns: table => new
                {
                    SACoursesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Field = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Undergrad = table.Column<bool>(type: "bit", nullable: false),
                    Postgrad = table.Column<bool>(type: "bit", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SACourses", x => x.SACoursesId);
                });

            migrationBuilder.CreateTable(
                name: "SAUniversities",
                columns: table => new
                {
                    SAUniversityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageController = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageAction = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAUniversities", x => x.SAUniversityId);
                });

            migrationBuilder.CreateTable(
                name: "SAUniCourses",
                columns: table => new
                {
                    SACoursesId = table.Column<int>(type: "int", nullable: false),
                    SAUniversityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAUniCourses", x => new { x.SACoursesId, x.SAUniversityId });
                    table.ForeignKey(
                        name: "FK_SAUniCourses_SACourses_SACoursesId",
                        column: x => x.SACoursesId,
                        principalTable: "SACourses",
                        principalColumn: "SACoursesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAUniCourses_SAUniversities_SAUniversityId",
                        column: x => x.SAUniversityId,
                        principalTable: "SAUniversities",
                        principalColumn: "SAUniversityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SACourses",
                columns: new[] { "SACoursesId", "Cost", "Course", "Field", "Postgrad", "Undergrad" },
                values: new object[,]
                {
                    { 1, 90000m, "Economics Specialization (Development, Policy, Econometrics, Health, Mining, Transport and Financial) and Statistics Specialization", "Economics and Statistics", true, false },
                    { 59, 132000m, "Ethnology", "Tourism, Museum and Heritage Studies", true, true },
                    { 58, 132000m, "Zoology", "Tourism, Museum and Heritage Studies", true, true },
                    { 57, 132000m, "Food Processing and Technology", "Tourism, Museum and Heritage Studies", true, true },
                    { 56, 132000m, "Food Engineering", "Tourism, Museum and Heritage Studies", true, true },
                    { 55, 132000m, "Paleontology", "Tourism, Museum and Heritage Studies", true, true },
                    { 54, 105000m, "Disaster Management", "Disaster and Water Management", true, false },
                    { 53, 105000m, "Water Laboratory Technology", "Disaster and Water Management", true, true },
                    { 60, 175000m, "Acturial Sciences, Insurance and Financial Mathematics/Science", "Acturial Sciences", true, true },
                    { 52, 105000m, "Water Engineering and Water Harvesting", "Disaster and Water Management", true, true },
                    { 50, 105000m, "Meteorology and Agrometeorology", "Disaster and Water Management", true, true },
                    { 49, 120000m, "Geographic Information Systems, Remote Sensing, Radar and Sonar Technology, and Cartography", "Engineering Science and Technology", true, true },
                    { 48, 120000m, "Information and Communication Technology", "Engineering Science and Technology", true, false },
                    { 47, 120000m, "Systems Engineering", "Engineering Science and Technology", true, true },
                    { 45, 120000m, "Electrical Engineering", "Engineering Science and Technology", true, true },
                    { 44, 120000m, "Chemical Engineering", "Engineering Science and Technology", true, true },
                    { 43, 120000m, "Auto-electricity Engineering", "Engineering Science and Technology", true, true },
                    { 51, 105000m, "Hydrology, Hydrogeology and Water Resources Management", "Disaster and Water Management", true, true },
                    { 61, 155000m, "Business Adminstration", "Investment Sciences and Management", true, false },
                    { 62, 155000m, "BSc Investment Sciences", "Investment Sciences and Management", true, false },
                    { 63, 155000m, "BSc Quantitative Risk Management (QRM)", "Investment Sciences and Management", true, true },
                    { 80, 200000m, "Neurology", "Health Sciences", true, false },
                    { 79, 200000m, "Neurosurgeon", "Health Sciences", true, false },
                    { 78, 200000m, "Radiation Oncology", "Health Sciences", true, true },
                    { 77, 200000m, "Orthopedics", "Health Sciences", true, true },
                    { 76, 200000m, "Auidiology and Speech-language pathology", "Health Sciences", true, true },
                    { 75, 200000m, "Pathophysiology", "Health Sciences", true, true },
                    { 74, 200000m, "Clinical Technology", "Health Sciences", true, true },
                    { 73, 200000m, "Biomedical Engineering", "Health Sciences", true, true },
                    { 72, 200000m, "Analytical Chemistry", "Health Sciences", true, true },
                    { 71, 200000m, "Nuclear Medicine Specialist", "Health Sciences", true, true },
                    { 70, 155000m, "Horticulture/Greenhouse", "Forestry, Agriculture, Animal and Environmental Sciences", true, false },
                    { 69, 155000m, "Fertilizer Production", "Forestry, Agriculture, Animal and Environmental Sciences", true, false },
                    { 68, 155000m, "Seed Technology", "Forestry, Agriculture, Animal and Environmental Sciences", true, true },
                    { 67, 155000m, "Agriculture Engineering", "Forestry, Agriculture, Animal and Environmental Sciences", true, false },
                    { 66, 155000m, "Veterinary Medicine", "Forestry, Agriculture, Animal and Environmental Sciences", true, true },
                    { 65, 155000m, "Conservation, Ecology, Arid and Range Management", "Forestry, Agriculture, Animal and Environmental Sciences", false, true },
                    { 64, 155000m, "Supply Chain Management and Logistics", "Investment Sciences and Management", true, true },
                    { 42, 120000m, "Mechanical, Nuclear and Mechatronics Engineering", "Engineering Science and Technology", true, true },
                    { 41, 120000m, "Industrial and Systems Engineering", "Engineering Science and Technology", true, true },
                    { 46, 120000m, "Computer Engineering", "Engineering Science and Technology", true, true },
                    { 39, 90000m, "Metallurgy Engineering", "Mining", true, true }
                });

            migrationBuilder.InsertData(
                table: "SACourses",
                columns: new[] { "SACoursesId", "Cost", "Course", "Field", "Postgrad", "Undergrad" },
                values: new object[,]
                {
                    { 18, 165000m, "Policing and Criminology", "Counselling Sciences, Policing and Investigative Studies", true, true },
                    { 17, 150000m, "Quantity Survey", "Building Sciences", true, true },
                    { 16, 150000m, "Hazard Safety and Risk Management", "Building Sciences", true, true },
                    { 40, 120000m, "Materials Science and Engineering", "Engineering Science and Technology", true, true },
                    { 14, 150000m, "Civil Engineering", "Building Sciences", true, true },
                    { 13, 200000m, "Medical Emergency and Paramedics", "Health Sciences", true, true },
                    { 12, 200000m, "Physiotherapy", "Health Sciences", true, true },
                    { 11, 200000m, "Radiography", "Health Sciences", true, true },
                    { 10, 200000m, "Dentistry", "Health Sciences", true, true },
                    { 9, 200000m, "Pharmacy", "Health Sciences", true, false },
                    { 8, 200000m, "Medicine (MBCHB)", "Health Sciences", true, true },
                    { 7, 200000m, "Bsc Clinincal Psychology", "Health Sciences", true, true },
                    { 6, 145000m, "Cargo management (will be covered under supply chain management", "Avionics", true, true },
                    { 5, 145000m, "MBA Aviation", "Avionics", true, true },
                    { 4, 145000m, "Airport Maintenance", "Avionics", true, true },
                    { 3, 145000m, "Aeronautical information service (communication; navigation; surveillance)", "Avionics", true, true },
                    { 2, 145000m, "Air Craft Mechanics and Aviation Studies (Aeronautical Engineering)", "Avionics", true, true },
                    { 19, 165000m, "Forensics and Ballistics", "Counselling Sciences, Policing and Investigative Studies", true, true },
                    { 20, 165000m, "Communication, Broadcasting and Journalism", "Communiction Sciences", true, true },
                    { 15, 150000m, "Construction Economics and Management", "Building Sciences", true, true },
                    { 22, 85000m, "Applied Arts, Digital Arts, Visual Arts, Artium", "Arts", true, false },
                    { 38, 90000m, "Mining Engineering and Mineral Extraction", "Mining", true, true },
                    { 37, 90000m, "Geo-physics", "Mining", true, true },
                    { 36, 90000m, "Geo-chemistry", "Mining", true, true },
                    { 21, 165000m, "Film studies and Photography", "Communication Sciences", true, true },
                    { 35, 90000m, "Geo-mechanism", "Mining", true, true },
                    { 34, 90000m, "Geology", "Mining", true, true },
                    { 32, 120000m, "Mediation and Arbitration", "Governance and Accountability", true, false },
                    { 31, 120000m, "Contract Negotiation", "Governance and Accountability", true, false },
                    { 33, 120000m, "Prosecuting of Economic Offenses", "Governance and Accountability", true, false },
                    { 29, 120000m, "Energy Planning", "Governance and Accountability", true, false },
                    { 28, 85000m, "Mathematics and Science Education", "Special and Technology Education and Linguistics", true, false },
                    { 27, 85000m, "Special Education and Technology", "Special and Technology Education and Linguistics", true, true },
                    { 26, 85000m, "Foundation and Early Childhood Development", "Special and Technology Education and Linguistics", true, true },
                    { 25, 85000m, "Fine Arts", "Arts", true, true },
                    { 24, 85000m, "Textile and Clothing Technology", "Arts", true, true },
                    { 23, 85000m, "Fashion Design and Graphic Design", "Arts", true, false },
                    { 30, 120000m, "Trail Advocacy", "Governance and Accountability", true, false }
                });

            migrationBuilder.InsertData(
                table: "SAUniversities",
                columns: new[] { "SAUniversityId", "ImageUrl", "Name", "PageAction", "PageController" },
                values: new object[,]
                {
                    { 7, "~/images/rhodes.png", "Rhodes University", "Rhodes", "SAUniversity" },
                    { 10, "~/images/ukzn.png", "University of Kwa-Zulu Natal", "UKZN", "SAUniversity" },
                    { 9, "~/images/Stellenbosch.jpeg", "Stellenbosch University", "Stellies", "SAUniversity" },
                    { 8, "~/images/nmmu.jpg", "Nelson Mandela Metropolitan University", "NMMU", "SAUniversity" }
                });

            migrationBuilder.InsertData(
                table: "SAUniversities",
                columns: new[] { "SAUniversityId", "ImageUrl", "Name", "PageAction", "PageController" },
                values: new object[,]
                {
                    { 6, "~/images/Tshwane.png", "Tshwane University of Technology", "TUT", "SAUniversity" },
                    { 11, "~/images/up.jpg", "University of Pretoria", "UP", "SAUniversity" },
                    { 4, "~/images/uj.jpg", "University of Johannesburg", "UJ", "SAUniversity" },
                    { 3, "~/images/Wits.jpg", "University of Witwatersrand", "Wits", "SAUniversity" },
                    { 2, "~/images/uct-Law-School-Logo.jpg", "University of Cape Town", "UCT", "SAUniversity" },
                    { 1, "~/images/ufs.jpg", "University of the Free State", "UFS", "SAUniversity" },
                    { 5, "~/images/cput.jpg", "Cape Peninsula University of Technology", "CPUT", "SAUniversity" },
                    { 12, "~/images/cut.jpg", "Central University of Technology", "CUT", "SAUniversity" }
                });

            migrationBuilder.InsertData(
                table: "SAUniCourses",
                columns: new[] { "SACoursesId", "SAUniversityId" },
                values: new object[,]
                {
                    { 8, 1 },
                    { 43, 8 },
                    { 45, 8 },
                    { 46, 8 },
                    { 47, 8 },
                    { 48, 8 },
                    { 49, 8 },
                    { 1, 9 },
                    { 16, 9 },
                    { 44, 9 },
                    { 45, 9 },
                    { 41, 9 },
                    { 42, 9 },
                    { 36, 9 },
                    { 22, 9 },
                    { 25, 9 },
                    { 15, 8 },
                    { 77, 9 },
                    { 11, 8 },
                    { 1, 8 },
                    { 48, 6 },
                    { 49, 6 },
                    { 17, 6 },
                    { 77, 6 },
                    { 40, 6 },
                    { 41, 6 },
                    { 34, 7 },
                    { 37, 7 },
                    { 20, 7 },
                    { 55, 7 },
                    { 56, 7 },
                    { 57, 7 },
                    { 58, 7 },
                    { 65, 7 },
                    { 7, 7 },
                    { 7, 8 },
                    { 78, 9 },
                    { 79, 9 },
                    { 80, 9 },
                    { 15, 11 },
                    { 16, 11 },
                    { 17, 11 }
                });

            migrationBuilder.InsertData(
                table: "SAUniCourses",
                columns: new[] { "SACoursesId", "SAUniversityId" },
                values: new object[,]
                {
                    { 7, 11 },
                    { 8, 11 },
                    { 10, 11 },
                    { 12, 11 },
                    { 76, 11 },
                    { 77, 11 },
                    { 78, 11 },
                    { 73, 11 },
                    { 79, 11 },
                    { 80, 11 },
                    { 27, 12 },
                    { 11, 12 },
                    { 14, 11 },
                    { 45, 11 },
                    { 43, 11 },
                    { 39, 11 },
                    { 12, 9 },
                    { 65, 9 },
                    { 60, 9 },
                    { 62, 9 },
                    { 63, 9 },
                    { 64, 9 },
                    { 50, 10 },
                    { 47, 6 },
                    { 53, 10 },
                    { 8, 10 },
                    { 42, 10 },
                    { 34, 11 },
                    { 35, 11 },
                    { 36, 11 },
                    { 37, 11 },
                    { 38, 11 },
                    { 65, 10 },
                    { 46, 6 },
                    { 45, 6 },
                    { 44, 6 },
                    { 45, 2 },
                    { 46, 2 },
                    { 47, 2 },
                    { 48, 2 },
                    { 1, 2 },
                    { 14, 2 }
                });

            migrationBuilder.InsertData(
                table: "SAUniCourses",
                columns: new[] { "SACoursesId", "SAUniversityId" },
                values: new object[,]
                {
                    { 15, 2 },
                    { 17, 2 },
                    { 66, 2 },
                    { 65, 2 },
                    { 55, 2 },
                    { 57, 2 },
                    { 56, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 44, 2 },
                    { 37, 2 },
                    { 34, 2 },
                    { 78, 2 },
                    { 78, 1 },
                    { 34, 1 },
                    { 36, 1 },
                    { 14, 1 },
                    { 17, 1 },
                    { 50, 1 },
                    { 54, 1 },
                    { 7, 3 },
                    { 60, 1 },
                    { 18, 1 },
                    { 20, 1 },
                    { 26, 1 },
                    { 27, 1 },
                    { 8, 2 },
                    { 11, 2 },
                    { 10, 2 },
                    { 61, 1 },
                    { 17, 12 },
                    { 44, 3 },
                    { 49, 3 },
                    { 59, 4 },
                    { 23, 4 },
                    { 24, 4 },
                    { 25, 4 },
                    { 23, 5 },
                    { 24, 5 },
                    { 41, 5 },
                    { 42, 5 },
                    { 44, 5 }
                });

            migrationBuilder.InsertData(
                table: "SAUniCourses",
                columns: new[] { "SACoursesId", "SAUniversityId" },
                values: new object[,]
                {
                    { 45, 5 },
                    { 14, 5 },
                    { 15, 5 },
                    { 16, 5 },
                    { 17, 5 },
                    { 52, 5 },
                    { 58, 4 },
                    { 71, 4 },
                    { 10, 4 },
                    { 11, 4 },
                    { 14, 3 },
                    { 15, 3 },
                    { 16, 3 },
                    { 17, 3 },
                    { 50, 3 },
                    { 51, 3 },
                    { 52, 3 },
                    { 47, 3 },
                    { 65, 3 },
                    { 46, 4 },
                    { 47, 4 },
                    { 48, 4 },
                    { 49, 4 },
                    { 15, 4 },
                    { 16, 4 },
                    { 13, 4 },
                    { 45, 4 },
                    { 45, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SAUniCourses_SAUniversityId",
                table: "SAUniCourses",
                column: "SAUniversityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SAUniCourses");

            migrationBuilder.DropTable(
                name: "SACourses");

            migrationBuilder.DropTable(
                name: "SAUniversities");
        }
    }
}
