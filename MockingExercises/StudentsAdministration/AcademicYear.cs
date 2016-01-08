using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingExercises.StudentsAdministration
{
    public class AcademicYear
    {
        ClassRoom _classRoom;
        private IArea _area;
        public int Year;
        public AcademicYear(ClassRoom classRoom, IArea area)
        {
            this._classRoom = classRoom;
            _area = area;
        }

        public void UpdateYear(int year)
        {
            Year = year;
        }
    }
}
