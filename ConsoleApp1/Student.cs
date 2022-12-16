using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DOB { get; set; }
        [Column("Department")]
        public int? DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public Department DepartmentDetails { get; set; }
    }

    public class StudentFormData
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int Department { get; set; }
    }

    public class StudentListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
