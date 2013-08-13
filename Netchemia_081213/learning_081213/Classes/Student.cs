using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netchemia_081213.Classes
{
    public abstract class Student : ICafeCustomer
    {
        public string Name;
        public string PhoneNumber;
        public Address Address;

        public virtual int GetCafeCredits(int studentId)
        {
            // fake data here in place of real DB code
            return 10;
        }

        public virtual bool RegisterClass(int teachingClassId, int studentId)
        {
            return false;
        }
        public Transcript GetTranscript(int studentId)
        {
            return new Transcript(studentId);
        }
    }
}