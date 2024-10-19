namespace No_Light_RPG.Acts.Act_1.Act_1_North;

public class Act1StartNorth1
{
    private static bool chestOpened = false; // Prevent multiple searches

    public static void Begin(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          NORTH - PART 1           ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You head North, following a narrow path through the woods.");
        Console.WriteLine("The sound of rustling leaves and distant birds fills the air.");
        Console.WriteLine("After a short walk, you stumble upon an abandoned campsite.");
        Console.WriteLine("There is a small chest hidden under some leaves and an old fire pit.");
        Console.WriteLine();
        Console.WriteLine("1. Inspect the chest");
        Console.WriteLine("2. Look around the campsite");
        Console.WriteLine("3. Continue further down the path");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                if (!chestOpened)
                {
                    InspectChest(player);
                }
                else
                {
                    Console.WriteLine("The chest is already empty.");
                    Thread.Sleep(2000);
                    Begin(player);
                }
                break;
            case "2":
                LookAroundCampsite(player);
                break;
            case "3":
                Act1StartNorth2.Begin(player); 
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                Begin(player);
                break;
        }
    }

    private static void InspectChest(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          INSPECTING CHEST         ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You carefully open the chest, and inside you find a handful of coins and a mysterious amulet.");
        player.Inventory.AddItem(new Item("Coins", "Currency", 50));
        player.Inventory.AddItem(new Item("Mysterious Amulet", "Accessory", 0));
        chestOpened = true;
        Console.WriteLine("Items added to your inventory.");
        Thread.Sleep(2000);
        Begin(player);
    }

    private static void LookAroundCampsite(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          AROUND THE CAMPSITE      ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("The fire pit is cold and unused. You find an old backpack nearby, but it's empty.");
        Thread.Sleep(2000);
        Begin(player);
    }
}