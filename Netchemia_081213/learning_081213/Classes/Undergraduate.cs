using Netchemia_081213.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netchemia_081213.Classes
{
    public class Undergraduate : Student
    {
        public override bool RegisterClass(int teachingClassId, int studentId)
        {
            // logic here that allow undergrads to only register for undergrad courses
            return (studentId >= 1 && teachingClassId <= 4); // don't have time to wire up to databaseFaker
        }
    }
}