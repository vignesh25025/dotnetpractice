using ConsoleApp1;

/*IStudentService studentService = new StudentService(new StudentDbContext());
var studentList = studentService.GetStudentList();
Console.WriteLine(studentList.Count);
*/
Console.WriteLine("Enter choice...");
int choice = int.Parse(Console.ReadLine());

LibraryManagementService libraryMgmtService = new LibraryManagementService();

if (libraryMgmtService != null)
{
    if (choice == 1)
    {
        Console.WriteLine(libraryMgmtService.GetMaxBooks(new StudentLibraryService()));
    }
    if (choice == 2)
    {
        Console.WriteLine(libraryMgmtService.GetMaxBooks(new StaffLibraryService()));
    }    
}