using WebApplication3.Models;

namespace WebApplication3.Services
{
    public interface  IStudentServices
    {
        List<Student> GetStudents();
        Student GetStudent(string  id);
        Student Create (Student student);

        void Update (String id , Student student);

        void Delete (String id);
    }
}
