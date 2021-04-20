using DotNetCoreCleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreCleanArch.Domain.Interfaces
{
   public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
