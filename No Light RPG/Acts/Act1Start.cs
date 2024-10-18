using System;

public class Act1Start
{
    public static void Begin(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          ACT 1: START             ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You wake up in an abandoned house, half destroyed and barely holding together.");
        Console.WriteLine("Inside the house, there's a table, a broken chair, and some burlaps you slept on.");
        Console.WriteLine();
        Console.WriteLine("1. Explore around");
        Console.WriteLine("2. Walk outside");
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
                GoOutside(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000); // Delay for 1 second
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
                GoOutside(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000); // Delay for 1 second
                ExploreHouse(player);
                break;
        }
    }

    private static void GoOutside(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          OUTSIDE HOUSE            ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You step outside the house.");
        Console.WriteLine();
        Act1OutsideHouse.Start(player);
    }
}
