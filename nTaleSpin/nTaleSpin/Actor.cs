using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nTaleSpin
{
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
    }

    public class Actor : Thing
    {
        public IActorBrain thinks(Thing subject)
        {
            return null;
        }

        public IPersonaInstinct thinks(Persona subject)
        {
            return null;
        }
    }

    public class Persona
    { 
    }

    public class Location
    {
        
    }
}
