using ConsoleApp1;

IStudentService studentService = new StudentService();
var studentList = studentService.GetStudentList();
Console.WriteLine(studentList.Count);