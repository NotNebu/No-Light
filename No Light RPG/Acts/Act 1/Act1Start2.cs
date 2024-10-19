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
                DescribeNorth(player);
                break;
            case "2":
                DescribeSouth(player);
                break;
            case "3":
                DescribeWest(player);
                break;
            case "4":
                DescribeEast(player);
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

    private static void DescribeNorth(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           LOOK NORTH              ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You look to the north and see a trail leading deeper into the forest.");
        Console.WriteLine("There is a faint trail of smoke rising from what could be a camp.");
        Console.WriteLine();
        Console.WriteLine("1. Head North");
        Console.WriteLine("2. Go back");
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Act1StartNorth1.Begin(player);
                break;
            case "2":
                LookAround(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                DescribeNorth(player);
                break;
        }
    }

    private static void DescribeSouth(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           LOOK SOUTH              ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You look to the south and see the path you just came from, leading back to the house.");
        Console.WriteLine("The house stands silent, its windows dark and foreboding.");
        Console.WriteLine();
        Console.WriteLine("1. Head South");
        Console.WriteLine("2. Go back");
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine();
                Console.WriteLine("This path is not yet implemented.");
                Thread.Sleep(2000);
                LookAround(player); // Not Yet Implemented Path
                break;
            case "2":
                LookAround(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                DescribeSouth(player);
                break;
        }
    }

    private static void DescribeWest(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           LOOK WEST               ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You look to the west and see a dense thicket of trees.");
        Console.WriteLine("The forest seems darker in that direction, with undergrowth making the way difficult.");
        Console.WriteLine();
        Console.WriteLine("1. Head West");
        Console.WriteLine("2. Go back");
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine();
                Console.WriteLine("This path is not yet implemented.");
                Thread.Sleep(2000);
                LookAround(player); // Not Yet Implemented Path
                break;
            case "2":
                LookAround(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                DescribeWest(player);
                break;
        }
    }

    private static void DescribeEast(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           LOOK EAST               ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You look to the east and see a clear path that seems to lead out of the forest.");
        Console.WriteLine("The path is bathed in sunlight, making it feel less ominous than the other directions.");
        Console.WriteLine();
        Console.WriteLine("1. Head East");
        Console.WriteLine("2. Go back");
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine();
                Console.WriteLine("This path is not yet implemented.");
                Thread.Sleep(2000);
                LookAround(player); // Not Yet Implemented Path
                break;
            case "2":
                LookAround(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                DescribeEast(player);
                break;
        }
    }
}
