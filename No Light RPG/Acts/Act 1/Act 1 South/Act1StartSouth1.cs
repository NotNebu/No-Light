namespace No_Light_RPG.Acts.Act_1.Act_1_South;

public class Act1StartSouth1
{
    public static void Begin(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          SOUTH - PART 1           ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You head South, walking back towards the familiar grounds.");
        Console.WriteLine("After a while, you find yourself near the house you just exited.");
        Console.WriteLine();
        Console.WriteLine("1. Go around the house");
        Console.WriteLine("2. Look around further");
        Console.WriteLine("3. Return to the main path");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                ExploreAroundHouse(player);
                break;
            case "2":
                LookAroundAgain(player);
                break;
            case "3":
                Act1Start2.LookAround(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                Begin(player);
                break;
        }
    }

    private static void ExploreAroundHouse(Player player)
    {
        Console.Clear();
        Console.WriteLine("You decide to go around the house, carefully inspecting the surroundings.");
    }

    private static void LookAroundAgain(Player player)
    {
        Console.Clear();
        Console.WriteLine("You take a moment to look around the area.");
    }
}