using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class StudentService : IStudentService
    {
        StudentDbContext dbContext = new StudentDbContext();

        public List<StudentListItem> GetStudentList()
        {
            var studentList = dbContext.Student.Include(x => x.DepartmentDetails).ToList();
            List<StudentListItem> response = new List<StudentListItem>();
            foreach (var student in studentList)
            {
                var studentItem = new StudentListItem();
                studentItem.Id = student.Id;
                studentItem.Name = student.Name;
                studentItem.Department = student.DepartmentDetails.Name;
                response.Add(studentItem);
            }
            return response;
        }
        
        public Student AddStudent(StudentFormData student)
        {
            Student studentModel = new Student();
            studentModel.Name = student.Name;
            studentModel.DOB = student.DOB;
            studentModel.DepartmentId = student.Department;
            dbContext.Student.Add(studentModel);
            dbContext.SaveChanges();
            return studentModel;
        }
    }
}
