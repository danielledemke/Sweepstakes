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
        private Contestant winner;
        
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
           
           contestant.firstName = UserInterface.GetUserInputFor("First Name");
           contestant.lastName = UserInterface.GetUserInputFor("Last Name");
           contestant.emailAddress = UserInterface.GetUserInputFor("Email Address");
           string registration = UserInterface.GetUserInputFor("Registration Number");
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
        public void Notify()
        {
            SetWinnerBool();
            List<Contestant> allContestants = new List<Contestant>(contestants.Values);
            foreach (Contestant contestant in allContestants)
            {
                if(contestant.IsWinner == true)
                {
                    Console.WriteLine("Congratulations! You have won the {0} Sweepstakes!", name);
                }
                else
                {
                    Console.WriteLine("Congratulations to {0} {1} on winning the {2} Sweepstakes! Thank you for playing and visit our website for more Sweepstakes!", winner.firstName, winner.lastName, name);
                }
            }
        }
        public void SetWinnerBool()
        {
            winner = PickWinner();
            winner.IsWinner = true;
        }
    }
}
