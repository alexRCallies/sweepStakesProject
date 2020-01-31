using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
        string firstName;
        string lastName;
        string email;
        int registrationCode;
        public Contestant(string firstName, string lastName, string email, int registrationCode )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.registrationCode = registrationCode;
        }
    }
}
