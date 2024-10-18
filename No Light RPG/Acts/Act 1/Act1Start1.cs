using System;
using System.Collections.Generic;
using No_Light_RPG.Act_1;

public abstract class Act1Start1
{
    private static bool houseExplored = false;

    public static void OutsideHouse(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          OUTSIDE HOUSE - PART 1   ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("The air is fresh, and you can hear the sounds of nature around you.");
        Console.WriteLine();
        Console.WriteLine("1. Explore around the house");
        Console.WriteLine("2. Look around (North, South, West, East)");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                if (!houseExplored)
                {
                    ExploreAroundHouse(player);
                }
                else
                {
                    Console.WriteLine("You've already explored around the house.");
                    Thread.Sleep(2000);
                    OutsideHouse(player);
                }
                break;
            case "2":
                Act1Start2.LookAround(player); 
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                OutsideHouse(player);
                break;
        }
    }

    private static void ExploreAroundHouse(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("     EXPLORING AROUND THE HOUSE    ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You explore around the house and find some useful items.");
        player.Inventory.AddItem(new Item("Old Coin", "Material", 0));
        player.Inventory.AddItem(new Item("Health Potion", "Potion", 20));
        houseExplored = true;
        Thread.Sleep(2000);
        OutsideHouse(player);
    }
}
