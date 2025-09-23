using Microsoft.EntityFrameworkCore;
using StudentManagment.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<StudentManagment.Data.ApplicationDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();


   app.UseSwagger();
    app.UseSwaggerUI();
  


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
