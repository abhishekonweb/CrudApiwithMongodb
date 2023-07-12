namespace WebApplication3.Models
{
    public interface IStudentStoreDatabaseSetting
    {
        string StudentCourseCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
