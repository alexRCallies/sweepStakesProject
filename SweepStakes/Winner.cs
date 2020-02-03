using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Winner : IContestant
    {
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }
        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }
        private string email;
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        private int registrationCode;
        public int RegistrationCode
        {
            get
            {
                return registrationCode;
            }
            set
            {
                registrationCode = value;
            }
        }
        
        public void Notify(IContestant contestant)
        {
            Console.WriteLine(firstName + " you are the winner");
        }
    }
}
