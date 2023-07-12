using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebApplication3.Models;
using WebApplication3.Services;

var builder = WebApplication.CreateBuilder(args);


//Add Services to the container
    builder.Services.Configure<StudentStoreDatabaseSetting>(builder.Configuration.GetSection(nameof(StudentStoreDatabaseSetting)));
    builder.Services.AddSingleton<IStudentStoreDatabaseSetting>(sp => sp.GetRequiredService<IOptions<StudentStoreDatabaseSetting>>().Value);
    builder.Services.AddSingleton<IMongoClient>(s=>new MongoClient(builder.Configuration.GetValue<string>("StudentStoreDataBaseSetting:ConnectionString")));
    builder.Services.AddScoped<IStudentServices,StudentServices>();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
