using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Database.Entities
{
    public class Student
    {
        //it makes the id primary key, but basically in default it identify the primary key
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public string RollNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
