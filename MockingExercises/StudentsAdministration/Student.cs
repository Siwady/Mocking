using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingExercises.StudentsAdministration
{
    public class Student:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }
    }
}
