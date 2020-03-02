using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            MarketingFirm marketingFirmOne = simulation.CreateMarketingFirmWithManager();
            Sweepstakes winCruise = marketingFirmOne.CreateSweepstake();
            Sweepstakes winNewHouse = marketingFirmOne.CreateSweepstake();
            marketingFirmOne.Manager.InsertSweepstakes(winCruise);
            marketingFirmOne.Manager.InsertSweepstakes(winNewHouse);
            winCruise.RegisterContestant();
            winNewHouse.RegisterContestant();
            winCruise.RegisterContestant();
            winNewHouse.RegisterContestant();
            Contestant winner = winCruise.PickWinner();
            Contestant otherWinner = winNewHouse.PickWinner();
            Console.WriteLine(winner.registrationNumber);
            Console.WriteLine(otherWinner.registrationNumber);


            Console.ReadLine();
        }
    }
}
