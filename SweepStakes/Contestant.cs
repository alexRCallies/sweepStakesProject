﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
   public class Contestant : IContestant
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
                LastName = value;
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
       public Contestant()
        {
            this.firstName = User_Interface.ContestantFirstName();
            this.lastName = User_Interface.ContestantLastName();
            this.email = User_Interface.ContestantEmail();
            this.registrationCode = User_Interface.ContestantRegistrationCode();
        }
       
        public void Notify(IContestant contestant)
        {
            Console.WriteLine(firstName + " you are a loser.");
        }
    }
}
