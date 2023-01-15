using BlazorCrudSqlite.Models;

namespace BlazorCrudSqlite.Services;

public interface IStudentService
{
    Task<List<StudentModel>> GetAllStudent();
    Task<StudentModel> GetStudentByID(int StudentID);
    Task<int> AddStudent(StudentModel studentModel);
    Task<int> UpdateStudent(StudentModel studentModel);
    Task<int> DeleteStudent(StudentModel studentModel);
}
