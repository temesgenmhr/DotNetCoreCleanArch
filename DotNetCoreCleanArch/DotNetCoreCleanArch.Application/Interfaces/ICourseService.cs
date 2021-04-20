using DotNetCoreCleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreCleanArch.Application.Interfaces
{
   public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
