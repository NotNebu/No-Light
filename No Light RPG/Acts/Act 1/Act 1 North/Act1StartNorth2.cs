using No_Light_RPG.Systems;

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
        Console.WriteLine("You continue further North, leaving the campsite behind.");
        Console.WriteLine("The path becomes narrower, surrounded by thick trees.");
        Console.WriteLine("In the distance, you see a small, rickety bridge over a stream.");
        Console.WriteLine();
        Console.WriteLine("1. Cross the bridge");
        Console.WriteLine("2. Examine the stream");
        Console.WriteLine("3. Continue along the path without crossing");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                CrossBridge(player);
                break;
            case "2":
                ExamineStream(player);
                break;
            case "3":
                Act1StartNorth3.Begin(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                Begin(player);
                break;
        }
    }

    private static void CrossBridge(Player player)
    {
        Console.Clear();
        Console.WriteLine("You carefully cross the rickety bridge, making sure it holds your weight.");
        Console.WriteLine("As you reach the other side, a shadowy figure emerges from the underbrush.");
        Console.WriteLine("It's a bandit, and he looks ready for a fight!");
        Console.WriteLine();
        Console.WriteLine("Press any key to engage in combat...");
        Console.ReadKey();
        
        Enemy bandit = new Enemy("Bandit", 30, 10, 5, 2);
        
        Gear banditWeapon = new Gear("Rusty Dagger", 3, 0); 
        Gear banditArmor = new Gear("Leather Vest", 0, 3);   
        bandit.EquipWeapon(banditWeapon);
        bandit.EquipArmor(banditArmor);

        
        Combat.StartCombat(player, bandit);
        
        if (player.Health > 0)
        {
            Console.WriteLine("After defeating the bandit, you find some supplies left behind.");
            player.Inventory.AddItem(new Item("Bandage", "Medical", 10));
            Console.WriteLine("You collect the supplies and continue your journey.");
            Thread.Sleep(2000);
            Act1StartNorth3.Begin(player);
        }
        else
        {
            Console.WriteLine("You have been defeated. The journey ends here...");
        }
    }
    
    private static void ExamineStream(Player player)
    {
        Console.Clear();
        Console.WriteLine("You kneel by the stream, cupping the cool water in your hands. It's refreshing.");
        Console.WriteLine("As you look closer, you notice something shiny under the water.");
        player.Inventory.AddItem(new Item("Silver Coin", "Currency", 5));
        Thread.Sleep(2000);
        Act1StartNorth3.Begin(player); 
    }
}