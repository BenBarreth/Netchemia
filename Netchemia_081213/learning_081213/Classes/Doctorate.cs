using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netchemia_081213.Classes
{
    public class Doctorate : Student
    {
        public override int GetCafeCredits(int studentId)
        {
            // give doctorates even more cafe credit
            return base.GetCafeCredits(studentId) + 20;
        }

        public override bool RegisterClass(int teachingClassId, int studentId)
        {
            // doctorate students can register for whatever the heck they want
            return (studentId >= 3 && teachingClassId <= 6); // don't have time to wire up to databaseFaker
        }
    }
}