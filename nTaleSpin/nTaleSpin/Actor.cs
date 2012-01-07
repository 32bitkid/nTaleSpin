using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nTaleSpin
{
    public class ActorState
    {
        public ActorState isSolvedBy(Thing solve)
        {
            throw new NotImplementedException();
        }
    }

    public class Thing
    {
        
    }

    public interface IPersonaInstinct
    {
        IPersonaInstinct eats(params Thing[] things);
    }

    public interface IActorBrain
    {
        IActorBrain isA(Persona persona);
        IActorBrain homeIs(Location where);
        IActorBrain isIn(Location where);
        IActorBrain isNow(ActorState state);
    }

    public class Actor : Thing
    {
        public IActorBrain thinks(Thing subject)
        {
            throw new NotImplementedException();
        }

        public IPersonaInstinct thinks(Persona subject)
        {
            throw new NotImplementedException();
        }
    }

    public class Persona
    { 
    }

    public class Location
    {
        
    }
}
