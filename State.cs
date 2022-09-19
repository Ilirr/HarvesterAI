using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvesterAI
{
    abstract class State
    {
        public abstract void Enter(Harvester worker);
        //Detta ska köras som en Update, så under tiden vi är i detta state
        public abstract void Execute(Harvester worker);
        //Detta ska köras precis när vi avslutar vår state, och går till nästa.
        public abstract void Exit(Harvester worker);
    }
}
