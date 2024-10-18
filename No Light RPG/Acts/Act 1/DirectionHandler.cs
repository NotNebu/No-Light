namespace No_Light_RPG.Acts.Act_1;

public static class DirectionHandler
{
    public static void HandleDirection(string direction, Player player, Action<Player> customAction = null)
    {
        switch (direction)
        {
            case "North":
                if (customAction != null)
                {
                    customAction(player);
                }
                else
                {
                    GoNorth(player);
                }
                break;
            case "South":
                if (customAction != null)
                {
                    customAction(player);
                }
                else
                {
                    GoSouth(player);
                }
                break;
            case "West":
                if (customAction != null)
                {
                    customAction(player);
                }
                else
                {
                    GoWest(player);
                }
                break;
            case "East":
                if (customAction != null)
                {
                    customAction(player);
                }
                else
                {
                    GoEast(player);
                }
                break;
            default:
                Console.WriteLine("Invalid direction.");
                break;
        }
    }
    
    public static void GoNorth(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("               NORTH               ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You head North and see the landscape stretching out before you.");
    }
    
    public static void GoSouth(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("               SOUTH               ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You head South, returning towards familiar ground.");
    }
    
    public static void GoWest(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("               WEST                ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You venture West, towards the setting sun.");
    }
    
    public static void GoEast(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("               EAST                ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You walk East, following a winding trail.");
    }
    
    public static void InvalidDirection()
    {
        Console.WriteLine("You cannot go in that direction.");
    }
}