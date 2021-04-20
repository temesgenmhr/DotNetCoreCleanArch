using DotNetCoreCleanArch.Domain.Interfaces;
using DotNetCoreCleanArch.Domain.Models;
using DotNetCoreCleanArch.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreCleanArch.Infrastructure.Data.Repository
{
   public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _universityDBContext;

        public CourseRepository(UniversityDBContext universityDBContext)
        {
            _universityDBContext = universityDBContext;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _universityDBContext.Courses;
        }
    }
}
