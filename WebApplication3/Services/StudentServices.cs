using MongoDB.Driver;
using WebApplication3.Models;

namespace WebApplication3.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IMongoCollection<Student> _student;

        public StudentServices(IStudentStoreDatabaseSetting settings,IMongoClient mongoclient) 
            {
            var database =  mongoclient.GetDatabase(settings.DatabaseName);
               _student =  database.GetCollection<Student>(settings.StudentCourseCollectionName);

            }
        public Student Create(Student student)
        {
             _student.InsertOne(student);
            return student;
        }

        public void Delete(string id)
        {
            _student.DeleteOne(student => student.Id == id);
        }

        public  Student GetStudent(string id)
        {
           return   _student.Find(student => student.Id == id).FirstOrDefault();
        }

        public List<Student> GetStudents()
        {
            return _student.Find(student => true).ToList();
        }

        public void Update(string id, Student student)
        {
            _student.ReplaceOne(student => student.Id == id, student);
        }
    }
}
