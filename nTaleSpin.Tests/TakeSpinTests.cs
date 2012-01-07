using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace nTaleSpin.Tests
{
    [TestFixture]
    public class TaleSpinTests
    {
        [SetUp]
        public void SetUp()
        {
            var world = new Actor();

            var honey = new Thing();
            var berries = new Thing();
            var fish = new Thing();
            var worm = new Thing();

            var bear = new Persona();
            var bird = new Persona();

            var cave = new Location();
            var oakTree = new Location();
            var elmTree = new Location();
            var ground = new Location();
            var river = new Location();

            var joe = new Actor();
            var irving = new Actor();

            world.thinks(bear).eats(honey, berries, fish);
            world.thinks(joe)
                .isA(bear)
                .homeIs(cave);

            world.thinks(bird).eats(worm);
            world.thinks(irving)
                .isA(bird)
                .homeIs(oakTree);

            world.thinks(joe).isIn(cave);
            joe.thinks(joe).isIn(cave);
           
            world.thinks(joe).isIn(cave);
            joe.thinks(joe).isIn(cave);

            world.thinks(irving).isIn(oakTree);
            irving.thinks(irving).isIn(oakTree);

            world.thinks(honey).isIn(elmTree);
            irving.thinks(honey).isIn(elmTree);

            world.thinks(worm).isIn(ground);
            joe.thinks(worm).isIn(ground);

            irving.thinks(joe).isIn(cave);
            joe.thinks(irving).isIn(oakTree);

            world.thinks(fish).isIn(river);
            irving.thinks(fish).isIn(river);
        }

        [Test]
        public void JoeIsThirsty()
        {
            var thirsty = new ActorState();
            thirst.isSolvedBy(water);

            joe.thinks(joe).isNow(thirsty); // Maybe abstract this into an injectable state
            world.thinks(joe).isNow(thirst);

        }

    }
}
