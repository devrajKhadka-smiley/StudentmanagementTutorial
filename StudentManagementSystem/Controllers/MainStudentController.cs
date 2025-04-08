using StudentManagementSystem.Database;
using StudentManagementSystem.Database.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore;

namespace StudentManagementSystem.Controllers
{

    [Route("/api/[controller]")]
    [ApiController]
    public class MainStudentController : ControllerBase
    {
        private readonly StudentDbContext dbContext;
        public MainStudentController(StudentDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost("add")]
        public IActionResult AddStudent(Student student)
        {
            dbContext.Students.Add(student);
            dbContext.SaveChanges();
            return Ok(student);
        }

        [HttpGet("getall")]
        public IActionResult GetAllStudent()
        {
            List<Student> studentList = dbContext.Students.ToList();
            return Ok(studentList);
        }

        [HttpGet("getbyid/{id}")]
        public IActionResult GetstudentById(int id)
        {
            Student? student = dbContext.Students.FirstOrDefault(st => st.Id == id);
            return student != null ? Ok(student) : NotFound("Khai tw veteyena");
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateStudent(Student std, int id)
        {
            //dbContext.Students.Update(std);
            //dbContext.SaveChanges(); || it will update the entire column to null, the value we didn't receive(e.g if we only update the email adrees expect the email it will update everything to null)

            //Fetch First approach || it's drawback is it hit the database 2 time 1 to fetch and another to update
            Student? student = dbContext.Students.FirstOrDefault(st => st.Id == id);
            if (student is not null)
            {
                student.Name = student.Name;
                student.Address = student.Address;
                student.RollNumber = student.RollNumber;

                dbContext.SaveChanges();
                return Ok(student);
            }
            return NotFound("Khai id nai veteyena");
        }

        //[HttpDelete("delete /{id}")]
        //public IActionResult DeleteStudent(int id) {
        //    Student? student = dbContext.Students.FirstOrDefault(st => st.Id == id);
        //    if (student is not null)
        //    {
        //        dbContext.Students.Remove(student);
        //        dbContext.SaveChanges();
        //        return Ok(student);
        //    }
        //    return NotFound("Khai id nai veteyena");
        //}

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteStudent(int id)
        {

            int rowsAffected = dbContext.Students.Where(st => st.Id == id).ExecuteDelete();
            return Ok(
                new
                {
                    RowsAffected = rowsAffected,
                    Message = rowsAffected > 0 ? "Student Deleted" : "Student Not Found"
                }
                );
        }

    }
}
