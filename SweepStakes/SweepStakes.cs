using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    
    public class SweepStakes
    {
       public Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
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
        public SweepStakes()
        {
            this.name = User_Interface.SweepStakesName();
        }
        public void RegisterContestant()
        {
            int numOfContestants = User_Interface.HowManyContestants();
            while (numOfContestants != 0)
            {
                Contestant contestant = new Contestant();
                contestants.Add(count, contestant);
                PrintContestantInfo(contestant);
                count++;
                numOfContestants--;
            }
        }
        public Contestant PickWinner()
        {
            int i = PickRandom();
            winner = contestants[i];
            Console.WriteLine("The winner is "); PrintContestantInfo(winner);
            WhatDidTheyWin();
            return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.registrationCode+ " "+ contestant.firstName + " " + contestant.lastName + " " + contestant.email + " is registered.");

        }
        public void WhatDidTheyWin()
        {
            Console.WriteLine("They won free " + name.ToUpper()) ;
        }
        public int PickRandom()
        {
            Random random = new Random();
            int i = random.Next(1, count + 1);
            return i;
        }
    } 
}
