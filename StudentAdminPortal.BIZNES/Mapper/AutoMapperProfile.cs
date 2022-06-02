using AutoMapper;
using StudentAdminPortal.BIZNES.VM;
using StudentAdminPortal.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminPortal.BIZNES.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudenVM>().ReverseMap();
        }
    }
}
