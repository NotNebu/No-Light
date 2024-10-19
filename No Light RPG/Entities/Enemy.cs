public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public int AttackPower { get; set; }
    public int Defense { get; set; }
    public bool IsAlive => Health > 0;

    public Enemy(string name, int health, int mana, int attackPower, int defense)
    {
        Name = name;
        Health = health;
        Mana = mana;
        AttackPower = attackPower;
        Defense = defense;
    }

    public void ShowStats()
    {
        Console.WriteLine($"Enemy: {Name}, Health: {Health}, Mana: {Mana}, Attack: {AttackPower}, Defense: {Defense}");
    }
}