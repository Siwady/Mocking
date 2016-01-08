using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingExercises.StudentsAdministration
{
    interface IEntity
    {
        int Id { set; get; }
        string Name { get; set; }
    }
}
