namespace No_Light_RPG.Acts.Act_1.Act_1_North;

public class Act1StartNorth8
{
    public static void Begin(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          NORTH - PART 8           ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You come across an abandoned camp, remnants of a fire still smoldering.");
        Console.WriteLine("You search around and find a small stash of supplies left behind.");
        Console.WriteLine();
        Console.WriteLine("1. Take the supplies");
        Console.WriteLine("2. Leave them and move on");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                player.Inventory.AddItem(new Item("Health Potion", "Potion", 20));
                Console.WriteLine("You take the health potion and continue your journey.");
                break;
            case "2":
                Console.WriteLine("You decide not to take anything and move on.");
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                Begin(player);
                return;
        }

        Thread.Sleep(2000);
        Act1StartNorth9.Begin(player);
    }
}