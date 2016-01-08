using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingExercises.StudentsAdministration
{
    public class ClassRoom
    {
        public ClassRoom(string name)
        {
            Name = name;
        }

        public string Name { set; get; }
        List<Student> Students { set; get; }
        public DateTime Year { get; set; }
    }
}
