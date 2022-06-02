using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.BIZNES.Interface;
using StudentAdminPortal.DataBase;
using StudentAdminPortal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminPortal.BIZNES.Repositories
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentAdminDbContext db;

        public StudentRepo(StudentAdminDbContext db )
        {
            this.db = db;
        }
        public async Task<List<Student>> Get()
        {
            return await db.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
