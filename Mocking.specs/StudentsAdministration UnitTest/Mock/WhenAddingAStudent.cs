using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;
using MockingExercises.StudentsAdministration;

namespace Mocking.specs.StudentsAdministration_UnitTest.Mock
{
    class WhenAddingAStudent
    {
        private static IStudentRepository _studentRepository;
        public Establish Context = () =>_studentRepository=new MockStudentRepository();

        public Because Of = () =>
        {
            _studentRepository.AddStudent(new Student("Hello"));
            _studentRepository.AddStudent(new Student("World"));
            _studentRepository.AddStudent(new Student("Hello World"));
        };

        public It ShouldHad3Students = () => _studentRepository.Students.Count.ShouldEqual(3);
    }
}
