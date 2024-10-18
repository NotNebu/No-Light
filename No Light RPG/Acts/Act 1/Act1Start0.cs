using No_Light_RPG.Act_1;

namespace No_Light_RPG.Acts.Act_1;

public class Act1Start0
{
    public static void Begin(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          ACT 1: START - PART 0    ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You wake up in an abandoned house, half destroyed and barely holding together.");
        Console.WriteLine("Inside the house, there's a table, a broken chair, and some burlaps you slept on.");
        Console.WriteLine();
        Console.WriteLine("1. Explore the house");
        Console.WriteLine("2. Step outside");
        Console.WriteLine();

        Console.Write("Choose an action (1 or 2): ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                ExploreHouse(player);
                break;
            case "2":
                Act1Start1.OutsideHouse(player); 
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                Begin(player);
                break;
        }
    }

    private static void ExploreHouse(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          EXPLORING HOUSE          ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You explore around the house but find nothing of value.");
        Console.WriteLine();
        Console.WriteLine("1. Walk outside");
        Console.WriteLine();

        Console.Write("Choose an action (1): ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                Act1Start1.OutsideHouse(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                ExploreHouse(player);
                break;
        }
    }
}