using ConsoleApp1;

IStudentService studentService = new StudentService();
Student student = studentService.AddStudent(new StudentFormData { 
   Name = "Sample",
   Department = 5,
   DOB = DateTime.Now
});
Console.WriteLine(studentService.GetStudentList().Count);