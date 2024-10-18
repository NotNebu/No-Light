using No_Light_RPG.Acts.Act_1.Act_1_East;
using No_Light_RPG.Acts.Act_1.Act_1_North;
using No_Light_RPG.Acts.Act_1.Act_1_South;
using No_Light_RPG.Acts.Act_1.Act_1_West;

namespace No_Light_RPG.Acts.Act_1;

public class Act1Start2
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
        Console.WriteLine("5. Go back");
        Console.Write("Choose a direction: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                Act1StartNorth1.Begin(player);
                break;
            case "2":
                Act1StartSouth1.Begin(player);
                break;
            case "3":
                Act1StartWest1.Begin(player);
                break;
            case "4":
                Act1StartEast1.Begin(player);
                break;
            case "5":
                Act1Start1.OutsideHouse(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                LookAround(player);
                break;
        }
    }
}