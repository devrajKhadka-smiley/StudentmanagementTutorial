namespace StudentManagementSystem.Models
{
    public class Student
    {
        public required string Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Course { get; set; }

    }
}
