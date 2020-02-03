using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{

    public class SweepStakes
    {
        public Dictionary<int, IContestant> contestants = new Dictionary<int, IContestant>();
        private List<IContestant> contestantList = new List<IContestant>();
        IContestant contestWinner;
        public int count = 1;
        
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
                IContestant contestant = new Contestant();
                contestants.Add(count, contestant);
                contestantList.Add(contestant);
                PrintContestantInfo(contestant);
                count++;
                numOfContestants--;
            }
        }
        public IContestant PickWinner()
        {
            int i = PickRandom();
            contestantList.Remove(contestants[i]);
            ConvertToWinner(i);
            contestantList.Add(contestWinner);
            PrintWinnerInfo(contestWinner);
            NotifyContestants();
            WhatDidTheyWin();
            return contestants[i];
        }
        public void PrintContestantInfo(IContestant contestant)
        {
            Console.WriteLine(contestant.RegistrationCode + " " + contestant.FirstName + " " + contestant.LastName + " " + contestant.Email + " is registered.");
        }
      public void PrintWinnerInfo(IContestant contestant)
        {
            Console.WriteLine("The winner is " + contestant.RegistrationCode + " " + contestant.FirstName + " " + contestant.LastName + " " + contestant.Email);
        }
        public void WhatDidTheyWin()
        {
            Console.WriteLine("They won free " + name.ToUpper());
        }
        public int PickRandom()
        {
            Random random = new Random();
            int i = random.Next(1, count);
            return i;
        }
        public void NotifyContestants()
        {
            foreach(IContestant contestant in contestantList)
            {
                contestant.Notify(contestant);
            }
        }
       
        public void ConvertToWinner(int i)
        {
            contestWinner = new Winner();
            contestWinner.FirstName = contestants[i].FirstName;
            contestWinner.LastName = contestants[i].LastName;
            contestWinner.Email = contestants[i].Email;
            contestWinner.RegistrationCode = contestants[i].RegistrationCode;
        }
    }
}
