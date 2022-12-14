using ConsoleApp1;

StudentDbContext dbContext = new StudentDbContext();
Console.WriteLine(dbContext.Student.ToList().Count);