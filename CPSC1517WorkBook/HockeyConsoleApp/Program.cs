using Hockey.Data;

Console.WriteLine("Welcome to the HockeyPlayer Test App");

// default
//HockeyPlayer player1 = new HockeyPlayer();
//player1.FirstName = "Wayne";
//player1.LastName = "Gretzky";


//HockeyPlayer player2 = new HockeyPlayer()
//{
//    FirstName = "Mario",
//    LastName = "Lemieux",
//};


// greedy
HockeyPlayer player3 = new HockeyPlayer("Bobby", "Orr", "Parry Sound, ON", new DateOnly(1948, 3, 20), 77, 200, Position.Defense, Shot.Right);

// output things about the players

//Console.WriteLine($"The player's name is {player1.FirstName} {player1.LastName}");
//Console.WriteLine($"The player's name is {player2.FirstName} {player2.LastName}");
Console.WriteLine(player3.ToString());
Console.WriteLine($"The player's name is {player3.FirstName} {player3.LastName}");

