using System;
using No_Light_RPG.Acts.Act_1;

public abstract class Act1Start2
{
    public static void LookAround(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           LOOK AROUND - PART 2    ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("Which direction do you want to look?");
        Console.WriteLine("1. North");
        Console.WriteLine("2. South");
        Console.WriteLine("3. West");
        Console.WriteLine("4. East");
        Console.Write("Choose a direction: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                DirectionHandler.GoNorth(player);
                break;
            case "2":
                DirectionHandler.GoSouth(player);
                break;
            case "3":
                DirectionHandler.GoWest(player);
                break;
            case "4":
                DirectionHandler.GoEast(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                LookAround(player);
                break;
        }
    }
}