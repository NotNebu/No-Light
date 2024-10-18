using System;
using System.Collections.Generic;
using System.Linq;

public class Shop
{
    public string Name { get; set; }
    public Dictionary<string, int> ItemsForSale { get; set; }

    public Shop(string name, Dictionary<string, int> itemsForSale)
    {
        Name = name;
        ItemsForSale = new Dictionary<string, int>(itemsForSale);
    }

    public void ShowItems()
    {
        Console.WriteLine("===================================");
        Console.WriteLine($"      WELCOME TO THE {Name}       ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("Items for sale:");
        foreach (var item in ItemsForSale)
        {
            Console.WriteLine($"{item.Key}: {item.Value} gold");
        }
        Console.WriteLine();
    }

    public void BuyItem(string itemName, Player player)
    {
        if (ItemsForSale.ContainsKey(itemName))
        {
            int itemPrice = ItemsForSale[itemName];
            if (player.Gold >= itemPrice)
            {
                player.Gold -= itemPrice;
                player.Inventory.AddItem(new Item(itemName, GetItemType(itemName), GetItemEffect(itemName)));
                Console.WriteLine($"You bought a {itemName} for {itemPrice} gold.");
            }
            else
            {
                Console.WriteLine($"You don't have enough gold to buy {itemName}.");
            }
        }
        else
        {
            Console.WriteLine($"{itemName} is not available in the shop.");
        }
    }

    public void SellItem(string itemName, Player player)
    {
        if (player.Inventory.HasItem(itemName))
        {
            Item item = player.Inventory.Items.FirstOrDefault(i => i.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                int sellPrice = GetSellPrice(itemName);

                player.Gold += sellPrice;
                Console.WriteLine($"You sold {itemName} for {sellPrice} gold.");

                player.Inventory.RemoveItem(item);

                if (ItemsForSale.ContainsKey(itemName))
                {
                    ItemsForSale[itemName]++;
                }
                else
                {
                    ItemsForSale.Add(itemName, 1);
                }
            }
        }
        else
        {
            Console.WriteLine($"You don't have {itemName} in your inventory.");
        }
    }

    private int GetSellPrice(string itemName)
    {
        if (ItemsForSale.ContainsKey(itemName))
        {
            return ItemsForSale[itemName] / 2; 
        }
        return 0;
    }

    public string GetItemType(string itemName)
    {
        return itemName switch
        {
            "Sword" => "Weapon",
            "Shield" => "Armor",
            "Health Potion" => "Potion",
            "Mana Potion" => "Mana Potion",
            _ => "Misc"
        };
    }

    public int GetItemEffect(string itemName)
    {
        return itemName switch
        {
            "Sword" => 5,
            "Shield" => 3,
            "Health Potion" => 20,
            "Mana Potion" => 20,
            _ => 0
        };
    }
}
