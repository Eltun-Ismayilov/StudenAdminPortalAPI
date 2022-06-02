using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.BIZNES.Interface;
using StudentAdminPortal.MODEL;

namespace StudentAdminPortal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo studentRepo;
        private readonly IMapper mapper;

        public StudentController(IStudentRepo studentRepo,IMapper mapper)
        {
            this.studentRepo = studentRepo;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        { 
            var students = await studentRepo.Get();

            return Ok(mapper.Map<List<Student>>(students));
            
        }
    }
}
