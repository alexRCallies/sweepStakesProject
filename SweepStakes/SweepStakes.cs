using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    
    class SweepStakes
    {
       public Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
       
       private string name;
       public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public SweepStakes(string name)
        {
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {

        }
        public Contestant PickWinner()
        {
            return 
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
