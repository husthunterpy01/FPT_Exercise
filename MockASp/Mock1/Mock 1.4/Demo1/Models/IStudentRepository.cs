using Demo1.Entities;

namespace Demo1.Models
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> Search(string name, Gender? gender);
        Task<Student> GetStudent(int StudentId);
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudentByEmail(string Email);
        Task<Student> AddStudent(Student student);
        Task<Student> UpdateStudent(Student student);
        Task DeleteStudent(int StudentId);
    }
}
