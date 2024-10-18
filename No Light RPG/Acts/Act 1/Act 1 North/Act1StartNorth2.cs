namespace No_Light_RPG.Acts.Act_1.Act_1_North;

public class Act1StartNorth2
{
    public static void Begin(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          NORTH - PART 2           ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You decide to venture deeper into the woods, leaving the campsite behind.");
        Console.WriteLine("The trees become denser, and the path less clear. You hear faint rustling nearby.");
        Console.WriteLine("As you move forward, you stumble upon an old, rusty gate partially hidden by foliage.");
        Console.WriteLine("The gate is locked, but it has a keyhole that looks like it might fit the small key you found.");
        Console.WriteLine();
        Console.WriteLine("1. Try using the small key to unlock the gate");
        Console.WriteLine("2. Look around the area");
        Console.WriteLine("3. Go back to the campsite");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                UseKeyOnGate(player);
                break;
            case "2":
                LookAroundArea(player);
                break;
            case "3":
                Act1StartNorth1.Begin(player); 
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                Begin(player);
                break;
        }
    }

    private static void UseKeyOnGate(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          UNLOCKING THE GATE       ");
        Console.WriteLine("===================================");
        
        if (player.Inventory.HasItem("Small Key"))
        {
            Console.WriteLine("You insert the small key into the lock, and with a bit of effort, it turns.");
            Console.WriteLine("The gate creaks open, revealing a hidden path leading deeper into the forest.");
            Console.WriteLine("You cautiously step through the gate, wondering what lies ahead.");
            
            player.Inventory.RemoveItemByName("Small Key");
            Console.WriteLine();
            Console.WriteLine("The key has been used and is now removed from your inventory.");
            Thread.Sleep(2000);
            Act1StartNorth3.Begin(player); 
        }
        else
        {
            Console.WriteLine("You reach for the key, but realize you don't have it.");
            Console.WriteLine("Perhaps you should search the area more thoroughly.");
            Thread.Sleep(2000);
            Begin(player);
        }
    }


    private static void LookAroundArea(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          AROUND THE GATE          ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You carefully inspect the area around the gate.");
        Console.WriteLine("There are some peculiar symbols carved into the gateposts, and the ground is littered with old leaves.");
        Console.WriteLine("You find nothing of immediate value, but the symbols seem ancient, almost mystical.");
        Console.WriteLine("It's clear that this gate has been here for a long time.");
        Console.WriteLine();
        Console.WriteLine("1. Try to unlock the gate with the key");
        Console.WriteLine("2. Return to the previous path");
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                UseKeyOnGate(player);
                break;
            case "2":
                Act1StartNorth1.Begin(player); 
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                LookAroundArea(player);
                break;
        }
    }
}