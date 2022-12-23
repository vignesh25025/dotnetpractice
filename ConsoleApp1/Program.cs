using ConsoleApp1;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddScoped<StudentDbContext>();
builder.Services.AddTransient<IStudentService,StudentService>();

var app = builder.Build();
app.MapControllers();
app.Run();