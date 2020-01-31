using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
       public string firstName;
       public string lastName;
       public string email;
       public int registrationCode;
        public Contestant()
        {
            this.firstName = User_Interface.ContestantFirstName();
            this.lastName = User_Interface.ContestantLastName();
            this.email = User_Interface.ContestantEmail();
            this.registrationCode = User_Interface.ContestantRegistrationCode();
        }
    }
}
