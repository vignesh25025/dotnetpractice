namespace ConsoleApp1
{
    public interface IStudentService
    {
        List<StudentListItem> GetStudentList();
        Student AddStudent(StudentFormData student); 
    }

    public interface ILibraryService
    {
        public int count { get; set; }
        int GetMaxBooks();
    }
}
