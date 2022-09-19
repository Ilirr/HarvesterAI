using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvesterAI
{
    internal class RestState : State
    {
        public override void Enter(Harvester worker)
        {
            Console.WriteLine(Harvester.Name + ": Going to rest!");

        }
        public override void Execute(Harvester worker)
        {
            Console.WriteLine(Harvester.Name + ": Resting.");
            worker.Exhaustion -= Harvester.EXH_MAX;

            if (worker.IsExhausted() == false)
            {
                worker.SetState(new HarvestState());
                // Console.WriteLine(Mathias.Name + ":");
            }

        }
        public override void Exit(Harvester worker)
        {
            Console.WriteLine(Harvester.Name + ": Going to harvest");

        }
    }
}
