namespace No_Light_RPG.Acts.Act_1.Act_1_North;

public class Act1StartNorth1
{
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
        Console.WriteLine("3. Return to the main path");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                InspectChest(player);
                break;
            case "2":
                LookAroundCampsite(player);
                break;
            case "3":
                Act1Start2.LookAround(player); 
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
        Console.WriteLine("You carefully open the chest, and inside you find some useful items.");
        Console.WriteLine("You pick up a handful of coins and a mysterious amulet.");
        
        player.Inventory.AddItem(new Item("Coins", "Currency", 50));
        player.Inventory.AddItem(new Item("Mysterious Amulet", "Accessory", 0));
        
        Console.WriteLine();
        Console.WriteLine("Items added to your inventory.");
        Console.WriteLine("You close the chest and stand up.");
        Thread.Sleep(2000);
        Console.WriteLine("1. Look around the campsite");
        Console.WriteLine("2. Return to the main path");
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                LookAroundCampsite(player);
                break;
            case "2":
                Act1Start2.LookAround(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                InspectChest(player);
                break;
        }
    }

    private static void LookAroundCampsite(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          AROUND THE CAMPSITE      ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You take a closer look around the campsite. The fire pit is cold and unused.");
        Console.WriteLine("Nearby, you find a worn-out backpack. Most of it is empty, except for a small key.");
        
        player.Inventory.AddItem(new Item("Small Key", "Key", 0));

        
        Console.WriteLine();
        Console.WriteLine("The small key might be useful later. You place it in your inventory.");
        Thread.Sleep(2000);
        Console.WriteLine("1. Inspect the chest again");
        Console.WriteLine("2. Return to the main path");
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                InspectChest(player);
                break;
            case "2":
                Act1Start2.LookAround(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                LookAroundCampsite(player);
                break;
        }
    }
}