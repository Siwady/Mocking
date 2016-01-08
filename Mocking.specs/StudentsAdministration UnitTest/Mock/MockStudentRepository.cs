using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockingExercises.StudentsAdministration;

namespace Mocking.specs.StudentsAdministration_UnitTest.Mock
{
    class MockStudentRepository:IStudentRepository
    {
        public List<Student> Students { get; set; }

        public MockStudentRepository()
        {
            Students=new List<Student>();
        }

        public Student GetStudent(string name)
        {
            return Students.ElementAt(0);
        }

        public List<Student> GetAllStudents()
        {
            return Students;
        }

        public bool AddStudent(Student student)
        {
            if (Students.Any(x => x.Name == student.Name))
                return false;
            Students.Add(student);
            return true;
        }
    }
}
