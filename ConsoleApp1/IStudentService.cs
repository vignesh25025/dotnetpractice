namespace ConsoleApp1
{
    public interface IStudentService
    {
        List<Student> GetStudentList();
        Student AddStudent(StudentFormData student); 
    }
}
