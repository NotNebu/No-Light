using System;
using No_Light_RPG.Acts.Act_1.Act_1_North;

public class Act1StartNorth4
{
    public static void Begin(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          NORTH - PART 4           ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("As you progress further, the path opens up to a small clearing.");
        Console.WriteLine("You hear the faint sound of water, suggesting a stream nearby.");
        Console.WriteLine();
        Console.WriteLine("1. Investigate the sound of water");
        Console.WriteLine("2. Continue through the clearing");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                InvestigateWater(player);
                break;
            case "2":
                Act1StartNorth5.Begin(player); 
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                Begin(player);
                break;
        }
    }

    private static void InvestigateWater(Player player)
    {
        Console.Clear();
        Console.WriteLine("You follow the sound and find a stream flowing through a rocky ravine.");
        Console.WriteLine("Beside the stream, there are some wild herbs that could be useful.");
        player.Inventory.AddItem(new Item("Wild Herbs", "Material", 0));
        Console.WriteLine("You gather the herbs and return to the main path.");
        Thread.Sleep(2000);
        Act1StartNorth5.Begin(player);
    }
}