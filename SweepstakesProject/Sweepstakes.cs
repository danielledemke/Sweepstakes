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
            contestants = new Dictionary<int, Contestant>();
        }

        //member methods
        
        public void RegisterContestant()
        {
           Contestant contestant = new Contestant();
            string firstName = "First Name";
           contestant.firstName = UserInterface.GetUserInputFor(firstName);
            string lastName = "Last Name";
            contestant.lastName = UserInterface.GetUserInputFor(lastName);
            string email = "Email Address";
            contestant.emailAddress = UserInterface.GetUserInputFor(email);
            string regNumber = "Registration Number";
           string registration = UserInterface.GetUserInputFor(regNumber);
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
