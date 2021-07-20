﻿using StudentLoan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Models
{
    public class OccupationRepository:RepositoryBase<Occupation>, IOccupationRepository
    {
        public OccupationRepository(AppDbContext appDbContext)
            :base(appDbContext)
        {

        }
    }
}
