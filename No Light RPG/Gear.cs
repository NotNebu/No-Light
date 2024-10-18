namespace No_Light_RPG;

public class Gear
{
    public string Name { get; set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }

    public Gear(string name, int attackPower, int defense)
    {
        Name = name;
        AttackPower = attackPower;
        Defense = defense;
    }
}
