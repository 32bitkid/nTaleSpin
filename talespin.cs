[TestFixture]
public class Test {
	
	[SetUp]
	public void SetUp() {

		var world = new Actor();

		var honey = new Thing();
		var berries = new Thing();
		var fish = new Thing();
		var worm = new Thing();

		var bear = new Persona();
		var bird = new Persona();

		var cave = new Location();
		var oakTree = new Tree();
		var elmTree = new Tree();
		var ground = new Location();
		var river = new Location();

		var joe = new Thing();	
		var irving = new Thing();

		world.thinks(bear).eats(honey, berries, fish)
		world.thinks(joe)
			.isA(bear)
			.home(cave);

		world.thinks(bird).eats(worm);
		world.thinks(irving)
			.isA(bird)
			.homeIs(oakTree);

		world.thinks(joe)
			.isAt(cave);

		joe.thinks(joe)
			.isAt(cave);
		
		world.thinks(irving).isAt(tree);

		bear.eats(honey, berries, fish);

		world.thinks(joe).isIn(cave);
		joe.thinks(joe).isIn(cave);

		world.thinks(irving).isIn(oakTree);
		irving.thinks(irving).isIn(oaktree);

		world.thinks(honey).isIn(elmTree);
		irving.thinks(honey).isIn(elmTree);

		world.thinks(worm).isIn(ground);
		joe.thinks(worm).isIn(ground);

		irivng.thinks(joe).isIn(cave);
		joe.thinks(irving).isIn(oakTree);

		world.thinks(fish).isIn(river);
		irving.thinks(fish).isIn(river);
	}

	[Test]
	public void JoeIsThirsty() {
		var thirsty = new ActorState();
		thirst.isSolvedBy(water);

		joes.thinks(joe).isNow(thirsty); // Maybe abstract this into an injectable state
		world.thinks(joe).isNow(thirst);

		world.step();


	}


}