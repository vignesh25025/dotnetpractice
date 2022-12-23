using Microsoft.AspNetCore.Mvc;

namespace ConsoleApp1.Controllers
{
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        IStudentService studentService;
        public StudentsController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        public List<StudentListItem> GetStudentList()
        {
            return studentService.GetStudentList();
        }
    }
}
