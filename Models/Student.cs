using System.ComponentModel.DataAnnotations;

namespace StudentManage.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [MaxLength(100)]
        public string? Genre { get; set; }
    }
}
