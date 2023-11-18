using ProjetNarratif;
using ProjetNarratif.Quests;
using ProjetNarratif.Quête;


 

var game = new Game();
game.Add(new BeginQuest());
game.Add(new Pnj());
game.Add(new Riddle());
game.Add(new Glossaire());
game.Add(new Cadavre());
game.Add(new Prime());
game.Add(new Primehypno());
game.Add(new SuiteRiddle());
game.Add(new Riddlecadavre());
game.Add(new Combat());
game.Add(new Dilemme());
game.Add(new Epargner());
game.Add(new Sacrifier());
game.Add(new Combat2());
game.Add(new Combat3());
game.Add(new Combat4());
game.Add(new Combat5());
game.Add(new Fin_alternatif());

while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentQuestDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);
}


Console.WriteLine("FIN");
Console.ReadLine();