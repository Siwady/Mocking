using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MockingExercises.StudentsAdministration;

namespace Mocking.specs.StudentsAdministration_UnitTest.Dummy
{
    class DummyArea:IArea
    {
        public string Name { get; set; }
        public Teacher AreaTeacher { get; set; }
        public void SetTeacher(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public Teacher GetTeacher()
        {
            throw new NotImplementedException();
        }

        public void ChangeAreaName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
