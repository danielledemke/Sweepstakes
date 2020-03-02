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

        //constructor
        public MarketingFirm(ISweepstakesManager manager) //dependency injection
        {
            this.manager = manager;
        }

        //member methods
        public Sweepstakes CreateSweepstake()
        {
            string sweepstakesName = "";
            string userEntry = UserInterface.GetUserInputFor(sweepstakesName);
            Sweepstakes sweepstakes = new Sweepstakes(userEntry);
            return sweepstakes;
                
        }

    }
}
