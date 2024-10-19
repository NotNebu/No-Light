using No_Light_RPG;

public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public int BaseAttackPower { get; set; }
    public int BaseDefense { get; set; }
    public bool IsAlive => Health > 0;
    
    public Gear EquippedWeapon { get; set; }
    public Gear EquippedArmor { get; set; }
    
    public double CritChance { get; set; } = 0.15; 
    public double CritMultiplier { get; set; } = 1.5; 

    public Enemy(string name, int health, int mana, int baseAttackPower, int baseDefense)
    {
        Name = name;
        Health = health;
        Mana = mana;
        BaseAttackPower = baseAttackPower;
        BaseDefense = baseDefense;
    }

    public void EquipWeapon(Gear weapon)
    {
        if (weapon != null)
        {
            EquippedWeapon = weapon;
            Console.WriteLine($"{Name} equipped {weapon.Name} as a weapon.");
        }
    }
    
    public void EquipArmor(Gear armor)
    {
        if (armor != null)
        {
            EquippedArmor = armor;
            Console.WriteLine($"{Name} equipped {armor.Name} as armor.");
        }
    }
    
    public int AttackPower
    {
        get
        {
            return BaseAttackPower + (EquippedWeapon != null ? EquippedWeapon.AttackPower : 0);
        }
    }
    
    public int Defense
    {
        get
        {
            return BaseDefense + (EquippedArmor != null ? EquippedArmor.Defense : 0);
        }
    }
}
    