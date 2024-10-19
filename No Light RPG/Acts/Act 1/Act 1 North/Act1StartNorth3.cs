namespace No_Light_RPG.Acts.Act_1.Act_1_North;

public class Act1StartNorth3
{
    public static void Begin(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          NORTH - PART 3           ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You continue along the northern path, the forest growing denser around you.");
        Console.WriteLine("As you walk, you notice strange markings carved into the trees, almost like a trail.");
        Console.WriteLine();
        Console.WriteLine("1. Follow the markings");
        Console.WriteLine("2. Ignore the markings and continue on the main path");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                FollowMarkings(player);
                break;
            case "2":
                Act1StartNorth4.Begin(player); 
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                Begin(player);
                break;
        }
    }

    private static void FollowMarkings(Player player)
    {
        Console.Clear();
        Console.WriteLine("You follow the markings deeper into the forest, leading you to a hidden glade.");
        Console.WriteLine("In the center, you find an old shrine with a glowing orb. It pulses gently as you approach.");
        player.Inventory.AddItem(new Item("Glowing Orb", "Misc", 0));
        Console.WriteLine("You take the Glowing Orb and return to the main path.");
        Thread.Sleep(2000);
        Act1StartNorth4.Begin(player);
    }
}