using ROSHAMBO;

RockPlayer player = new RockPlayer();

Console.WriteLine(player.GenerateRoshambo());

RandomPlayer player2 = new RandomPlayer();

Console.WriteLine(player2.GenerateRoshambo());

HumanPlayer h1;

Console.WriteLine("Enter a name for your character");
string name = Console.ReadLine();
h1 = new HumanPlayer(name);

h1.GenerateRoshambo(Player.Roshambo.rock);
