using System;
using System.Collections.Generic;

public class Inventory
{
    public List<Item> Items { get; set; }
    public Item EquippedWeapon { get; set; }
    public Item EquippedArmor { get; set; }

    public Inventory()
    {
        Items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Items.Add(item);
        Console.WriteLine($"{item.Name} has been added to your inventory.");
    }

    public void RemoveItem(Item item)
    {
        if (Items.Contains(item))
        {
            Items.Remove(item);
            Console.WriteLine($"{item.Name} has been removed from your inventory.");
        }
        else
        {
            Console.WriteLine($"{item.Name} is not in your inventory.");
        }
    }

    public Item GetItemByName(string itemName)
    {
        return Items.FirstOrDefault(i => i.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
    }
    
    public void RemoveItemByName(string itemName)
    {
        Item itemToRemove = Items.FirstOrDefault(i => i.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
        if (itemToRemove != null)
        {
            RemoveItem(itemToRemove);
        }
        else
        {
            Console.WriteLine($"Item '{itemName}' not found in your inventory.");
        }
    }
    
    public void ShowInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (var item in Items)
        {
            Console.WriteLine($"- {item.Name}");
        }
        Console.WriteLine($"Equipped Weapon: {(EquippedWeapon != null ? EquippedWeapon.Name : "None")}");
        Console.WriteLine($"Equipped Armor: {(EquippedArmor != null ? EquippedArmor.Name : "None")}");
    }

    public void EquipItem(string itemName)
    {
        Item item = Items.Find(i => i.Name == itemName);
        if (item != null)
        {
            if (item.Type == "Weapon")
            {
                EquippedWeapon = item;
                Console.WriteLine($"You have equipped {item.Name} as your weapon.");
            }
            else if (item.Type == "Armor")
            {
                EquippedArmor = item;
                Console.WriteLine($"You have equipped {item.Name} as your armor.");
            }
            else
            {
                Console.WriteLine($"{item.Name} is not a weapon or armor.");
            }
        }
        else
        {
            Console.WriteLine($"You do not have {itemName} in your inventory.");
        }
    }
    
    public bool HasItem(string itemName)
    {
        return Items.Any(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
    }


    public void UseItem(string itemName, Player player)
    {
        Item item = Items.Find(i => i.Name == itemName);
        if (item != null)
        {
            if (item.Type == "Potion")
            {
                player.Health += item.Effect;
                Console.WriteLine($"You used {item.Name}. Health increased by {item.Effect}.");
                RemoveItem(item);
            }
            else if (item.Type == "Mana Potion")
            {
                player.Mana += item.Effect;
                Console.WriteLine($"You used {item.Name}. Mana increased by {item.Effect}.");
                RemoveItem(item);
            }
            else
            {
                Console.WriteLine($"{item.Name} cannot be used in this way.");
            }
        }
        else
        {
            Console.WriteLine($"You do not have {itemName} in your inventory.");
        }
    }
}
