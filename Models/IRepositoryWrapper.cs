using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Models
{
    public interface IRepositoryWrapper
    {
        ISAUniRepository University { get; }
        ISAUniCourseRepository UniversityCourse { get; }
        ISACourseRepository Course { get; }
        IApplicationRepository Application { get; }
        IGenderRepository Gender { get; }
        IOccupationRepository Occupation { get; }
        IMaritalStatusRepository MaritalStatus { get; }
    }
}
