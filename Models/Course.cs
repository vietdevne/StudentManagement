namespace StudentManage.Models
{
    public class Course
    {
        public int Id { get; set; }
        public Student? Student { get; set; }
        public int? StudentId { get; set; }
        public int? UserId { get; set; }
        public Teacher? Teacher { get; set; }
        public int? TeacherId { get; set; }
        public string Name { get; set; }
    }
}
