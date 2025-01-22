namespace StudentListAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Group { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
