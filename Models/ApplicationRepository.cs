using StudentLoan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Models
{
    public class ApplicationRepository:RepositoryBase<Application> , IApplicationRepository       
    {
        public ApplicationRepository(AppDbContext appDbContext)
            :base(appDbContext)
        {

        }
    }
}
