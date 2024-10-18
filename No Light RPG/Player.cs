using System;
using System.Collections.Generic;
using System.Threading;

public class Player
{
    public string Name { get; set; }
    public string Class { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public int BaseAttackPower { get; set; }
    public int BaseDefense { get; set; }
    public Inventory Inventory { get; set; }
    public List<Spell> Spells { get; set; }
    public int Gold { get; set; }

    public int AttackPower
    {
        get
        {
            return BaseAttackPower + (Inventory.EquippedWeapon != null ? Inventory.EquippedWeapon.Effect : 0);
        }
    }

    public int Defense
    {
        get
        {
            return BaseDefense + (Inventory.EquippedArmor != null ? Inventory.EquippedArmor.Effect : 0);
        }
    }

    public Player(string name)
    {
        Name = name;
        Inventory = new Inventory();
        Spells = new List<Spell>();
        Gold = 100; // Initial gold amount
    }

    public void ChooseClass()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("         CHOOSE YOUR CLASS         ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");
        Console.WriteLine("3. Archer");
        Console.WriteLine();

        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                Class = "Warrior";
                Health = 100;
                Mana = 30;
                BaseAttackPower = 10;
                BaseDefense = 5;
                Inventory.AddItem(new Item("Basic Sword", "Weapon", 5));
                Inventory.AddItem(new Item("Leather Armor", "Armor", 2));
                Inventory.EquipItem("Basic Sword");
                Inventory.EquipItem("Leather Armor");
                break;
            case "2":
                Class = "Mage";
                Health = 70;
                Mana = 100;
                BaseAttackPower = 5;
                BaseDefense = 3;
                Spells.Add(new Spell("Fireball", 20, 10));
                Inventory.AddItem(new Item("Magic Staff", "Weapon", 3));
                Inventory.AddItem(new Item("Robe", "Armor", 1));
                Inventory.EquipItem("Magic Staff");
                Inventory.EquipItem("Robe");
                break;
            case "3":
                Class = "Archer";
                Health = 80;
                Mana = 50;
                BaseAttackPower = 8;
                BaseDefense = 4;
                Inventory.AddItem(new Item("Bow", "Weapon", 4));
                Inventory.AddItem(new Item("Leather Armor", "Armor", 2));
                Inventory.EquipItem("Bow");
                Inventory.EquipItem("Leather Armor");
                break;
            default:
                Console.WriteLine("Invalid choice, defaulting to Warrior.");
                Class = "Warrior";
                Health = 100;
                Mana = 30;
                BaseAttackPower = 10;
                BaseDefense = 5;
                Inventory.AddItem(new Item("Basic Sword", "Weapon", 5));
                Inventory.AddItem(new Item("Leather Armor", "Armor", 2));
                Inventory.EquipItem("Basic Sword");
                Inventory.EquipItem("Leather Armor");
                break;
        }
        
        Console.WriteLine();
        Thread.Sleep(1000);
        
        Inventory.AddItem(new Item("Health Potion", "Potion", 20));
        Inventory.AddItem(new Item("Mana Potion", "Mana Potion", 20));
        
        Console.WriteLine();
        Console.WriteLine($"You have chosen: {Class}");
        Thread.Sleep(1000);
        
        Console.WriteLine();
        Console.WriteLine("You have been equipped with a starter weapon, armor, and some potions.");
        Thread.Sleep(10000);
        
        Console.WriteLine();
        Act1Start.Begin(this);
    }

    public void ShowStats()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("           PLAYER STATS            ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Class: {Class}");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Mana: {Mana}");
        Console.WriteLine($"Attack: {AttackPower}");
        Console.WriteLine($"Defense: {Defense}");
        Console.WriteLine($"Gold: {Gold}");
        Console.WriteLine();
    }
}
