namespace No_Light_RPG.Systems;

public class Combat
{
    private static Random random = new Random();
    public static void StartCombat(Player player, Enemy enemy)
    {
        Console.WriteLine($"A wild {enemy.Name} appears!");

        bool inCombat = true;
        while (inCombat)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Magic");
            Console.WriteLine("3. Items");
            
            Console.Write("Choose an action: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Attack(player, enemy);
                    break;
                case "2":
                    UseMagic(player, enemy);
                    break;
                case "3":
                    UseItem(player);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            if (!enemy.IsAlive)
            {
                Console.WriteLine($"You have defeated the {enemy.Name}!");
                inCombat = false;
            }
            else
            {
                EnemyAttack(player, enemy);
                if (player.Health <= 0)
                {
                    Console.WriteLine("You have been defeated!");
                    inCombat = false;
                }
            }
        }
    }

    public static void Attack(Player player, Enemy enemy)
    {
        int damage = CalculateDamage(player.AttackPower, enemy.Defense, player.CritChance, player.CritMultiplier);
        enemy.Health -= damage;
        Console.WriteLine($"You dealt {damage} damage to the {enemy.Name}. It has {enemy.Health} health left.");
    }

    public static void EnemyAttack(Player player, Enemy enemy)
    {
        int damage = CalculateDamage(enemy.AttackPower, player.Defense, enemy.CritChance, enemy.CritMultiplier);
        player.Health -= damage;
        Console.WriteLine($"The {enemy.Name} dealt {damage} damage to you. You have {player.Health} health left.");
    }

    private static int CalculateDamage(int baseAttack, int targetDefense, double critChance, double critMultiplier)
    {
        int damage = baseAttack - targetDefense;
        damage = damage < 0 ? 0 : damage;
        
        bool isCriticalHit = random.NextDouble() < critChance;

        if (isCriticalHit)
        {
            damage = (int)(damage * critMultiplier);
            Console.WriteLine("Critical Hit!"); 
        }

        return damage;
    }

    public static void UseMagic(Player player, Enemy enemy)
    {
        if (player.Spells.Count == 0)
        {
            Console.WriteLine("You don't know any spells!");
            return;
        }

        Console.WriteLine("Choose a spell:");
        for (int i = 0; i < player.Spells.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {player.Spells[i].Name} (Damage: {player.Spells[i].Damage}, Mana Cost: {player.Spells[i].ManaCost})");
        }

        Console.Write("Choose a spell: ");
        int spellChoice;
        if (int.TryParse(Console.ReadLine(), out spellChoice) && spellChoice > 0 && spellChoice <= player.Spells.Count)
        {
            Spell spell = player.Spells[spellChoice - 1];
            if (player.Mana >= spell.ManaCost)
            {
                player.Mana -= spell.ManaCost;
                enemy.Health -= spell.Damage;
                Console.WriteLine($"You cast {spell.Name} and dealt {spell.Damage} damage to the {enemy.Name}. It has {enemy.Health} health left.");
            }
            else
            {
                Console.WriteLine("You don't have enough mana!");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice, please try again.");
        }
    }

    public static void UseItem(Player player)
    {
        if (player.Inventory.Items.Count == 0)
        {
            Console.WriteLine("You have no items in your inventory.");
            return;
        }

        Console.WriteLine("Choose an item:");
        for (int i = 0; i < player.Inventory.Items.Count; i++)
        {
            Item item = player.Inventory.Items[i];
            if (item.Type == "Potion" || item.Type == "Mana Potion")
            {
                Console.WriteLine($"{i + 1}. {item.Name} ({item.Type})");
            }
        }

        Console.Write("Choose an item: ");
        int itemChoice;
        if (int.TryParse(Console.ReadLine(), out itemChoice) && itemChoice > 0 && itemChoice <= player.Inventory.Items.Count)
        {
            Item item = player.Inventory.Items[itemChoice - 1];
            if (item.Type == "Potion" || item.Type == "Mana Potion")
            {
                player.Inventory.UseItem(item.Name, player);
            }
            else
            {
                Console.WriteLine("You can't use that item in combat.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice, please try again.");
        }
    }
}