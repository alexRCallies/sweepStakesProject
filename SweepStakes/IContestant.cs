﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public interface IContestant
    {
      
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        int RegistrationCode { get; set; }

       
        void Notify(IContestant contestant);
        
    }
}
