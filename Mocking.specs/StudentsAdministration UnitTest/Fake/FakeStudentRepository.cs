using System.Collections.Generic;
using System.Linq;
using MockingExercises.StudentsAdministration;

namespace Mocking.specs.StudentsAdministration_UnitTest.Fake
{
    class FakeStudentRepository : IStudentRepository
    {
        public FakeStudentRepository()
        {
            Students = new List<Student>
            {
                new Student("Edward") ,
                new Student("Carlos"),
                new Student("Richard"),
                new Student("Byron")
            };
        }

        public List<Student> Students { get; set; }

        public Student GetStudent(string name)
        {
            return Students.ElementAt(0);
        }

        public List<Student> GetAllStudents()
        {
            return null;
        }

        public bool AddStudent(Student student)
        {
            if (Students.Any(x=>x.Name==student.Name))
                return false;

            Students.Add(student);
            return true;
        }
    }
}
