using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingExercises.StudentsAdministration
{
    public interface IStudentRepository
    {
        List<Student> Students { set; get; }
        Student GetStudent(string name);
        List<Student> GetAllStudents();
        bool AddStudent(Student student);
    }
}
