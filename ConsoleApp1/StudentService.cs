namespace ConsoleApp1
{
    public class StudentService : IStudentService
    {
        StudentDbContext dbContext = new StudentDbContext();

        public List<Student> GetStudentList()
        {
            return dbContext.Student.ToList();
        }
        
        public Student AddStudent(StudentFormData student)
        {
            Student studentModel = new Student();
            studentModel.Name = student.Name;
            studentModel.DOB = student.DOB;
            studentModel.Department = student.Department;
            dbContext.Student.Add(studentModel);
            dbContext.SaveChanges();
            return studentModel;
        }
    }
}
