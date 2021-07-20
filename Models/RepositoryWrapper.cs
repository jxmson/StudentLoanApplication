using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoan.Models
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private AppDbContext _appDbContext;
        private ISAUniRepository _uni;
        private ISAUniCourseRepository _unicourse;
        private ISACourseRepository _course;
        private IApplicationRepository _application;
        private IGenderRepository _gender;
        private IOccupationRepository _occ;
        private IMaritalStatusRepository _marital;

        public RepositoryWrapper(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IGenderRepository Gender
        {
            get
            {
                if (_gender == null)
                    _gender = new GenderRepository(_appDbContext);
                return _gender;
            }
        }
        public IOccupationRepository Occupation
        {
            get
            {
                if (_occ == null)
                    _occ = new OccupationRepository(_appDbContext);
                return _occ;
            }
        }
        public IMaritalStatusRepository MaritalStatus
        {
            get
            {
                if (_marital == null)
                    _marital = new MaritalStatusRepository(_appDbContext);
                return _marital;
            }
        }
        public ISAUniRepository University
        {
            get
            {
                if (_uni == null)
                    _uni = new SAUniRepository(_appDbContext);
                return _uni;
            }
        }

        public ISAUniCourseRepository UniversityCourse
        {
            get
            {
                if (_unicourse == null)
                    _unicourse = new SAUniCourseRepository(_appDbContext);
                return _unicourse;
            }
        }

        public ISACourseRepository Course
        {
            get
            {
                if (_course == null)
                    _course = new SACourseRepository(_appDbContext);
                return _course;
            }
        }
        public IApplicationRepository Application
        {
            get
            {
                if (_application == null)
                    _application = new ApplicationRepository(_appDbContext);
                return _application;
            }
        }
    }
}
