public class Spell
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public int ManaCost { get; set; }

    public Spell(string name, int damage, int manaCost)
    {
        Name = name;
        Damage = damage;
        ManaCost = manaCost;
    }
}