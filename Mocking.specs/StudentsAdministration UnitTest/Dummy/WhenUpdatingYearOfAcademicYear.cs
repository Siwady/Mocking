using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;
using MockingExercises.StudentsAdministration;

namespace Mocking.specs.StudentsAdministration_UnitTest.Dummy
{
    class WhenUpdatingYearOfAcademicYear
    {
        private static AcademicYear _academicYear;
        public Establish Context = () =>
        {
            ClassRoom classRoom=new ClassRoom("3A");
            IArea area=new DummyArea();
            _academicYear=new AcademicYear(classRoom, area);

        };

        public Because Of = () => _academicYear.UpdateYear(2016);

        public It ShouldhadChangedTheyear = () => _academicYear.Year.ShouldEqual(2016);
    }
}
