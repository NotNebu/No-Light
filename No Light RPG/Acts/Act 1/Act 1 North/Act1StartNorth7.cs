using No_Light_RPG.Systems;

namespace No_Light_RPG.Acts.Act_1.Act_1_North;

public class Act1StartNorth7
{
    public static void Begin(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("          NORTH - PART 7           ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("As you continue along the path, a large shadow blocks your way. It's a wild beast, guarding the trail.");
        Console.WriteLine("The beast snarls, ready to attack.");
        Console.WriteLine();
        Console.WriteLine("Press any key to engage in combat...");
        Console.ReadKey();
        
        Enemy wildBeast = new Enemy("Wild Beast", 50, 0, 10, 3);
        Gear beastClaws = new Gear("Sharp Claws", 4, 0);
        wildBeast.EquipWeapon(beastClaws);

        Combat.StartCombat(player, wildBeast);

        if (player.Health > 0)
        {
            Console.WriteLine("After defeating the beast, you clear the path and continue on.");
            Thread.Sleep(2000);
            Act1StartNorth8.Begin(player); 
        }
        else
        {
            Console.WriteLine("You have been defeated. The journey ends here...");
        }
    }
}