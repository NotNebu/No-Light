namespace No_Light_RPG.Acts.Act_1.Act_1_North;

public class Act1StartNorth6
{
    public static void Begin(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          NORTH - PART 6           ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("The path splits into two, one leading up a steep hill and the other winding down into a valley.");
        Console.WriteLine("You must choose which way to proceed.");
        Console.WriteLine();
        Console.WriteLine("1. Take the hill path");
        Console.WriteLine("2. Head down into the valley");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                HillPath(player);
                break;
            case "2":
                ValleyPath(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                Begin(player);
                break;
        }
    }

    private static void HillPath(Player player)
    {
        Console.Clear();
        Console.WriteLine("You climb the hill, struggling against the incline. At the top, you find a beautiful view of the forest below.");
        Console.WriteLine("You take a moment to rest before heading down the other side.");
        Thread.Sleep(2000);
        Act1StartNorth7.Begin(player); 
    }

    private static void ValleyPath(Player player)
    {
        Console.Clear();
        Console.WriteLine("You descend into the valley, the air cooler and filled with the scent of damp earth.");
        Console.WriteLine("The path is more challenging, but you manage to navigate through it.");
        Thread.Sleep(2000);
        Act1StartNorth7.Begin(player); 
    }
}