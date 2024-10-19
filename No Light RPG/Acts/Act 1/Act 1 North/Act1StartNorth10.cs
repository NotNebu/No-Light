using System;

public class Act1StartNorth10
{
    public static void Begin(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          NORTH - PART 10          ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("After a long journey through the dense forest, you finally see the outline of a small town.");
        Console.WriteLine("The trail opens up, revealing cobblestone streets and modest buildings.");
        Console.WriteLine("You notice a market bustling with activity, merchants selling their wares, and townsfolk going about their day.");
        Console.WriteLine("It feels like a place where you can rest, resupply, and prepare for whatever lies ahead.");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue to the town...");
        Console.ReadKey();
        Act2Town0.Begin(player);
    }
}