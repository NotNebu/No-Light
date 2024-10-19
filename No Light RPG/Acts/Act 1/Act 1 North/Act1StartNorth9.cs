namespace No_Light_RPG.Acts.Act_1.Act_1_North;

public class Act1StartNorth9
{
    public static void Begin(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          NORTH - PART 9           ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("As you journey deeper, you encounter a mysterious figure blocking the path.");
        Console.WriteLine("The figure asks a riddle, testing your wit and resolve.");
        Console.WriteLine();
        Console.WriteLine("Answer the riddle: 'I speak without a mouth and hear without ears. I have nobody, but I come alive with wind. What am I?'");
        Console.Write("Your answer: ");
        string answer = Console.ReadLine().Trim().ToLower();

        if (answer == "echo")
        {
            Console.WriteLine("The figure nods approvingly and steps aside, allowing you to pass.");
            Thread.Sleep(2000);
            Act1StartNorth10.Begin(player);
        }
        else
        {
            Console.WriteLine("The figure shakes its head, and you feel a chilling sensation pass through you.");
            Console.WriteLine("You must try again.");
            Thread.Sleep(2000);
            Begin(player);
        }
    }
}