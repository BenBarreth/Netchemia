using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netchemia_081213.Classes
{
    /// <summary>
    /// TBD class for future addition of university personnel
    /// </summary>
    public class UniversityPersonnel : ICafeCustomer
    {
        public virtual int GetCafeCredits(int studentId)
        {
            // fake data here in place of real DB code
            // base university personnel get 20 creds by default
            return 20;
        }
    }
}