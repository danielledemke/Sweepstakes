using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
   public class MarketingFirm
    {
        //member variables
        private ISweepstakesManager manager;
        private string name;

        public ISweepstakesManager Manager
        {
            get
            {
                return manager;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        //constructor
        public MarketingFirm(ISweepstakesManager manager) //dependency injection
        {
            this.manager = manager;
            string nameOfFirm = "Name of Marketing Firm";
            name = UserInterface.GetUserInputFor(nameOfFirm);
        }

        //member methods
        public Sweepstakes CreateSweepstake()
        {
            string sweepstakesName = "Name of Sweepstakes";
            string userEntry = UserInterface.GetUserInputFor(sweepstakesName);
            Sweepstakes sweepstakes = new Sweepstakes(userEntry);
            return sweepstakes;
                
        }

    }
}
