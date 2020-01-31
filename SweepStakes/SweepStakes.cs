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
        Contestant alex = new Contestant("Alex", "Callies", "alexcallies@yahoo.com", 3517911);
        Contestant karvin = new Contestant("Karvin", "White", "karvinwhite@gmail.com", 8888888);
        Contestant tiffany = new Contestant("Tiffany", "Knight", "tiffNight@aol.com", 1234567);
        Contestant hataya = new Contestant("Hataya", "Johnson", "sparklezrule#outlook.com", 3336622);
        public int count = 1;
        Contestant winner;
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
            contestants.Add(count, contestant);
            PrintContestantInfo(contestant);
            count++;
        }
        public Contestant PickWinner()
        {
            Random random = new Random();
            int i = random.Next(1, count+1 );
            winner = contestants[i];
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.registrationCode+ " "+ contestant.firstName + " " + contestant.lastName + " " + contestant.email + " is registered.");

        }
    }
}
