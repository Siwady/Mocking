using Machine.Specifications;
using MockingExercises.StudentsAdministration;

namespace Mocking.specs.StudentsAdministration_UnitTest.Fake
{
    class WhenAddingAStudentThatAlreadyExist
    {
        private static IStudentRepository _studentsRepository;
        private static bool _result;

        public Establish Context = () => _studentsRepository=new FakeStudentRepository();

        public Because Of = () =>_result=_studentsRepository.AddStudent(_studentsRepository.GetStudent("Edward"));

        public It ShouldReturnFalse = () => _result.ShouldEqual(false);
    }
}
