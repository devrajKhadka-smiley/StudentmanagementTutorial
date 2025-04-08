//using Microsoft.AspNetCore.Mvc;
//using StudentManagementSystem.Models;

//namespace StudentManagementSystem.Controllers
//{
//    [ApiController]
//    [Route("api/[Controller]")]
//    public class StudentsController : ControllerBase
//    {
//        List<Student> studentList = new List<Student>()
//        {
//            new Student(){
//                Id = "NP123456",
//                Name = "Ram Bahadur",
//                Address = "Kathmandu",
//                Email = "DevRaj@mail.com",
//                Course = "Bachelor in Garibi"
//            }
//        };

//        [HttpGet("getall")]
//        //[ProducesResponseType(StatusCodes.Status404NotFound)]
//        public List<Student> GetAll()
//        {
//            return studentList;
//        }

//        [HttpGet("{studentId}")]
//        public IActionResult GetStudentById([FromRoute(Name = "studentId")] string id)
//        {
//            Student? student = studentList.FirstOrDefault(x => x.Id == id);

//            //if (student is null)
//            //{
//            //    return NotFound("Khai Veteyena Hau");
//            //}

//            //return Ok(student);

//            return student == null ? NotFound("Khai Veteyena Hau") : Ok(student);
//        }

//        [HttpPost("all")]
//        public Student AddStudent([FromBody] Student student)
//        {
//            //var studentInfo = new Student()
//            //{
//            //    Id = student.Id,
//            //    Name = student.Name,
//            //    Address = student.Address,
//            //    Email = student.Email,
//            //    Course = student.Course,
//            //};

//            studentList.Add(student);
//            return student;
//        }
//    }
//}
