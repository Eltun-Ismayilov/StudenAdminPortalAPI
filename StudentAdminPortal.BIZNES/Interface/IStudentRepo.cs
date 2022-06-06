using StudentAdminPortal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminPortal.BIZNES.Interface
{
    public interface IStudentRepo
    {
        Task<List<Student>> Get();
        Task<Student> Details(Guid id);
    }
}
