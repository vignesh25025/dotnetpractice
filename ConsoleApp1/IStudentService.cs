namespace ConsoleApp1
{
    public interface IStudentService
    {
        List<StudentListItem> GetStudentList();
        Student AddStudent(StudentFormData student); 
    }
}
