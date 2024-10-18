public class Act1OutsideHouse
{
    private static bool houseExplored = false; // Flag to track if the house has been explored

    public static void Start(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("        OUTSIDE THE HOUSE          ");
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
                    Thread.Sleep(2000); // Delay for 2 seconds
                    Start(player);
                }
                break;
            case "2":
                LookAround(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000); // Delay for 1 second
                Start(player);
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
        Console.WriteLine();
        player.Inventory.AddItem(new Item("Old Coin", "Material", 0));
        player.Inventory.AddItem(new Item("Health Potion", "Potion", 20));
        Console.WriteLine();
        Console.WriteLine("After exploring the house you end up at the entrance again.");
        Console.WriteLine();
        houseExplored = true; // Mark the house as explored
        Thread.Sleep(2000); // Delay for 2 seconds
        Start(player);
    }

    private static void LookAround(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           LOOK AROUND             ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("Which direction do you want to look?");
        Console.WriteLine();
        Console.WriteLine("1. North");
        Console.WriteLine("2. South");
        Console.WriteLine("3. West");
        Console.WriteLine("4. East");
        Console.WriteLine("5. Go back");
        Console.WriteLine();
        Console.Write("Choose a direction: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                LookNorth(player);
                break;
            case "2":
                LookSouth(player);
                break;
            case "3":
                LookWest(player);
                break;
            case "4":
                LookEast(player);
                break;
            case "5":
                Start(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000); // Delay for 1 second
                LookAround(player);
                break;
        }
    }

    private static void LookNorth(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           LOOK NORTH              ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You look to the North and see smoke on the horizon, a possible camp.");
        Console.WriteLine();
        Console.WriteLine("1. Move North");
        Console.WriteLine("2. Look around (South, West, East)");
        Console.WriteLine("3. Go back");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("You decide to move North.");
                Act1Directions.GoNorth(player);
                break;
            case "2":
                LookAround(player);
                break;
            case "3":
                Start(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000); // Delay for 1 second
                LookNorth(player);
                break;
        }
    }

    private static void LookWest(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           LOOK WEST               ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You look to the West and see a dense forest.");
        Console.WriteLine();
        Console.WriteLine("1. Move West");
        Console.WriteLine("2. Look around (North, South, East)");
        Console.WriteLine("3. Go back");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("You decide to move West.");
                Act1Directions.GoWest(player);
                break;
            case "2":
                LookAround(player);
                break;
            case "3":
                Start(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000); // Delay for 1 second
                LookWest(player);
                break;
        }
    }

    private static void LookEast(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           LOOK EAST               ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You look to the East and see a clear path leading into the woods.");
        Console.WriteLine();
        Console.WriteLine("1. Move East");
        Console.WriteLine("2. Look around (North, South, West)");
        Console.WriteLine("3. Go back");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("You decide to move East.");
                Act1Directions.GoEast(player);
                break;
            case "2":
                LookAround(player);
                break;
            case "3":
                Start(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000); // Delay for 1 second
                LookEast(player);
                break;
        }
    }

    private static void LookSouth(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           LOOK SOUTH              ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You look to the South and see the house you just exited.");
        Console.WriteLine();
        Console.WriteLine("1. Move to the other side of the house");
        Console.WriteLine("2. Look around (North, West, East)");
        Console.WriteLine("3. Go back into the house");
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
                LookAround(player);
                break;
            case "3":
                Console.WriteLine("You go back into the house.");
                Thread.Sleep(2000); 
                Act1Start.Begin(player); 
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000); 
                LookSouth(player);
                break;
        }
    }
}
