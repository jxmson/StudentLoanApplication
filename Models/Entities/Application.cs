using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Models.Entities
{
    public class Application
    {
       
        public int  ApplicationId { get; set; }

        [Required(ErrorMessage ="Enter First Name")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter Surname")]
        [DisplayName("Surname")]
        public string Surname { get; set; }

        [DisplayName("Other Name")]
        public string OtherName { get; set; }

        [Required(ErrorMessage = "Select a gender")]
        [DisplayName("Gender")]
        public string GenderName { get; set; }
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Enter Date of Birth")]
        [DisplayName("Date Of Birth")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Enter ID number/Passport Number")]
        [DisplayName("Identification Number/Passport Number")]
        public string IDNumber { get; set; }

        [Required(ErrorMessage = "Select an occupation")]
        [DisplayName("Occupation")]
        public string OccupationName { get; set; }
        public Occupation Occupation { get; set; }

        [Required(ErrorMessage = "Select marital status")]
        [DisplayName("Marital Status")]
        public string  MaritalStatusName{ get; set; }
        public MaritalStatus MaritalStatus { get; set; } 

        [Required(ErrorMessage = "Enter Email")]
        [UIHint("email")]
        public string Email{ get; set; }

        [Required(ErrorMessage = "Enter Cell Phone Number")]
        [DisplayName("Cell Phone Number")]
        public string Cell { get; set; }

        [DisplayName("Work Phone Number")]
        public string Work { get; set; }

        [DisplayName("Home Phone Number")]
        public string Home { get; set; }

        [Required(ErrorMessage = "Enter address line")]
        [DisplayName("Address Line 1")]
        public string Address1 { get; set; }
        
        [DisplayName("Address Line 2")]
        public string Address2 { get; set; }
       
        [DisplayName("Address Line 3")]
        public string Address3 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Suburb { get; set; }

        [Required(ErrorMessage = "Enter Zip Code")]
        [DisplayName("Zip Code")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Enter Country of Residence")]
        [DisplayName("Country Of Residence")]
        public string Country { get; set; }

        [Required]
        [DisplayName("Institution")]
        public string Name { get; set; }
        public SAUniversity Institution { get; set; }
        [Required]
        [DisplayName("Programme")]
        public string Course { get; set; }
        public SACourses Programme { get; set; }

        [DisplayName("Student Number")]
        public string StudentNumber { get; set; }

        [Required]
        [DisplayName("Date Of Admission")]
        public DateTime DateofAdmission { get; set; }

        [Required]
        [DisplayName("Date Of Completion")]
        public DateTime DateOfCompletion { get; set; }

        [DisplayName("Institution")]
        public string Name2 { get; set; }

        [DisplayName("Programme")]
        public string Course2 { get; set; }

     
        [DisplayName("Student Number")]
        public string StudentNumber2 { get; set; }

       
        [DisplayName("Date Of Admission")]
        public DateTime DateofAdmission2 { get; set; }

       
        [DisplayName("Date Of Completion")]
        public DateTime DateOfCompletion2 { get; set; }

        [DisplayName("Institution")]
        public string Name3 { get; set; }

        [DisplayName("Programme")]
        public string Course3 { get; set; }

        
        [DisplayName("Student Number")]
        public string StudentNumber3 { get; set; }

        
        [DisplayName("Date Of Admission")]
        public DateTime DateofAdmission3 { get; set; }

       
        [DisplayName("Date Of Completion")]
        public DateTime DateOfCompletion3 { get; set; }

        [Required]
        [DisplayName("High School")]
        public string HighSchool { get; set; }

        [Required]
        [DisplayName("Date Of School Completion")]
        public DateTime DateOfSchoolCompletion { get; set; }

        [Required]
        [DisplayName("Last Qualification Obtained")]
        public string QualificationObtained { get; set; }

        [Required]
        public string Bank { get; set; }

        [Required]
        [DisplayName("Branch Code")]
        public string Branch { get; set; }

        [Required]
        [DisplayName("Name On Account")]
        public string NameOnAccount { get; set; }

        [Required]
        [DisplayName("Account Number")]
        public string AccountNumber { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string GuarantorName { get; set; }

        [Required]
        [DisplayName("Surname")]
        public string GuarantorSurname { get; set; }

        [Required]
        [DisplayName("Identification Number/Passport Number")]
        public string GuarantorID { get; set; }

        [Required]
        [DisplayName("Cell Phone Number")]
        public string GuarantorCell { get; set; }

        
        [DisplayName("Home Phone Number")]
        public string GuarantorHome { get; set; }

        
        [DisplayName("Work Phone Number")]
        public string GuarantorWork { get; set; }

        [Required]
        [DisplayName("Address Line 1")]
        public string GuarantorAddress1 { get; set; }

        [DisplayName("Address Line 2")]
        public string GuarantorAddress2 { get; set; }

        
        [DisplayName("Address Line 3")]
        public string GuarantorAddress3 { get; set; }

        [Required]
        [DisplayName("City")]
        public string GuarantorCity { get; set; }

        [Required]
        [DisplayName("Suburb")]
        public string GuarantorSuburb { get; set; }

        [Required]
        [DisplayName("Zip Code")]
        public string GuarantorZip { get; set; }

        [Required]
        [DisplayName("Country of Residence")]
        public string GuarantorCountry { get; set; }
        

    }
}
