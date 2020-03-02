using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
   public class Sweepstakes
    {
        //member variables
        private Dictionary<int, Contestant> contestants;
        private string name;
        
        public string Name
        {
            get
            {
                return name;
            }
        }
        //constructor
        public Sweepstakes(string name)
        {
            this.name = name;
        }

        //member methods
        
        public void RegisterContestant()
        {
           Contestant contestant = new Contestant();
           contestant.firstName = UserInterface.GetUserInputFor(contestant.firstName);
           contestant.lastName = UserInterface.GetUserInputFor(contestant.lastName);
           contestant.emailAddress = UserInterface.GetUserInputFor(contestant.emailAddress);
           string registration = UserInterface.GetUserInputFor(contestant.registrationNumber.ToString());
           contestant.registrationNumber = int.Parse(registration);
           contestants.Add(contestant.registrationNumber, contestant);
        }
        public Contestant PickWinner()
        {
            List<int> registrationNumbers = new List<int>(contestants.Keys);
            Random random = new Random();
            int winningRegistrationNumber = registrationNumbers[random.Next(registrationNumbers.Count)];
            return contestants[winningRegistrationNumber];
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.Write(contestant.firstName);
            Console.Write(contestant.lastName);
            Console.Write(contestant.emailAddress);
            Console.Write(contestant.registrationNumber);
        }

    }
}
