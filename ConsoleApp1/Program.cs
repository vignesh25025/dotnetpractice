using ConsoleApp1;
using Microsoft.Extensions.DependencyInjection;

/*IStudentService studentService = new StudentService(new StudentDbContext());
var studentList = studentService.GetStudentList();
Console.WriteLine(studentList.Count);
*/
Console.WriteLine("Enter choice...");
int choice = int.Parse(Console.ReadLine());

IServiceCollection services = new ServiceCollection()
    .AddTransient<LibraryManagementService>()
    .AddScoped<StudentDbContext>()
    .AddTransient<IStudentService, StudentService>();

if(choice == 1) { 
    services.AddScoped<ILibraryService, StudentLibraryService>();
}
if (choice ==2)
{
    services.AddScoped<ILibraryService, StaffLibraryService>();
}

ServiceProvider serviceProvider = services.BuildServiceProvider();


LibraryManagementService libraryMgmtService = serviceProvider.GetService<LibraryManagementService>();
IStudentService studentService = serviceProvider.GetService<IStudentService>();

if (libraryMgmtService != null)
{
    Console.WriteLine(libraryMgmtService.GetMaxBooks());
}

studentService.GetStudentList();