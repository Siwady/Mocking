using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MockingExercises.StudentsAdministration
{
    public interface IArea
    {
        string Name { set; get; }
        Teacher AreaTeacher { set; get; }
        void SetTeacher(Teacher teacher);
        Teacher GetTeacher();
        void ChangeAreaName(string name);
    }
}
