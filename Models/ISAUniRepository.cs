using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Models
{
    public interface ISAUniRepository : IRepositoryBase<SAUniversity>
    {
        //IEnumerable<SAUniversity> GetAllUnis();
        //SAUniversity GetUniById(int sauniversityID);
        //void AddUniversity(SAUniversity varsity);
        //void DeleteUniversity(SAUniversity varsity);
        //void UpdateUniversity(SAUniversity varsity);
        public IEnumerable<SAUniCourse> GetVarsityCourseList(int id, string search);
       

    }
}
