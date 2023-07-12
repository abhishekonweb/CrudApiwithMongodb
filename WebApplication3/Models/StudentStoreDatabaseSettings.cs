namespace WebApplication3.Models
{
    public class StudentStoreDatabaseSetting : IStudentStoreDatabaseSetting
    {
        public string StudentCourseCollectionName { get; set; }=string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }   
}
