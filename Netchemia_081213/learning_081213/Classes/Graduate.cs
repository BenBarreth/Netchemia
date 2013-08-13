using Netchemia_081213.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netchemia_081213.Classes
{
    public class Graduate : Student
    {
        public override int GetCafeCredits(int studentId)
        {
            // give grads more cafe credit
            return base.GetCafeCredits(studentId) + 10;
        }

        public override bool RegisterClass(int teachingClassId, int studentId)
        {
            // logic here that allow grads to only register for undergrad or grad courses
            return (studentId >= 2 && teachingClassId <= 5); // don't have time to wire up to databaseFaker
        }
    }
}