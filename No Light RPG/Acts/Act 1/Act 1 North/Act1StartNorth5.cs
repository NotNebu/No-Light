namespace No_Light_RPG.Acts.Act_1.Act_1_North;

public class Act1StartNorth5
{
    public static void Begin(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          NORTH - PART 5           ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("The path leads you to the entrance of a dark, ominous cave.");
        Console.WriteLine("A faint glow emanates from deep within, and you can hear faint whispers echoing.");
        Console.WriteLine();
        Console.WriteLine("1. Enter the cave");
        Console.WriteLine("2. Continue along the path, avoiding the cave");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                EnterCave(player);
                break;
            case "2":
                Act1StartNorth6.Begin(player); 
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                Begin(player);
                break;
        }
    }

    private static void EnterCave(Player player)
    {
        Console.Clear();
        Console.WriteLine("You cautiously enter the cave, the air growing colder with every step.");
        Console.WriteLine("Deep inside, you find an ancient altar with a glowing crystal on top.");
        player.Inventory.AddItem(new Item("Glowing Crystal", "Misc", 0));
        Console.WriteLine("You take the crystal and quickly exit the cave, continuing your journey.");
        Thread.Sleep(2000);
        Act1StartNorth6.Begin(player); 
    }
}