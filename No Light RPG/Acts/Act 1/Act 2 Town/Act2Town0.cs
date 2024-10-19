using System;

public static class Act2Town0
{
    public static void Begin(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           WELCOME TO TOWN         ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You arrive at the bustling town, a place of rest and opportunity.");
        Console.WriteLine("The market is filled with merchants selling all kinds of goods.");
        Console.WriteLine("You can hear the chatter of townsfolk, the clinking of coins, and the scent of food in the air.");
        Console.WriteLine();
        Console.WriteLine("1. Visit the market to buy items");
        Console.WriteLine("2. Sell items at the market");
        Console.WriteLine("3. Talk to the innkeeper");
        Console.WriteLine("4. Prepare for your next journey");
        Console.WriteLine();
        Console.Write("Choose an action: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
            case "1":
                VisitMarket(player);
                break;
            case "2":
                SellItems(player);
                break;
            case "3":
                TalkToInnkeeper(player);
                break;
            case "4":
                PrepareForJourney(player);
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                Begin(player);
                break;
        }
    }

    private static void VisitMarket(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           VISIT THE MARKET        ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("Merchants offer various items that might help on your journey.");
        Console.WriteLine("1. Health Potion - 20 coins");
        Console.WriteLine("2. Mana Potion - 20 coins");
        Console.WriteLine("3. Sword - 100 coins");
        Console.WriteLine("4. Leave the market");
        Console.Write("Choose an item to buy or leave: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                BuyItem(player, "Health Potion", 20);
                break;
            case "2":
                BuyItem(player, "Mana Potion", 20);
                break;
            case "3":
                BuyItem(player, "Sword", 100);
                break;
            case "4":
                Begin(player); 
                break;
            default:
                Console.WriteLine("Invalid choice, please try again.");
                Thread.Sleep(1000);
                VisitMarket(player);
                break;
        }
    }

    private static void BuyItem(Player player, string itemName, int price)
    {
        if (player.Gold >= price)
        {
            player.Inventory.AddItem(new Item(itemName, "Misc", 0));
            player.Gold -= price;
            Console.WriteLine($"You bought a {itemName} for {price} coins.");
        }
        else
        {
            Console.WriteLine("You don't have enough coins to buy that item.");
        }
        Thread.Sleep(2000);
        VisitMarket(player);
    }

    private static void SellItems(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           SELL YOUR ITEMS         ");
        Console.WriteLine("===================================");
        Console.WriteLine("Your Inventory:");
        player.Inventory.ShowInventory();
        Console.WriteLine("Enter the name of the item you want to sell (or type 'cancel' to go back): ");
        string itemName = Console.ReadLine();

        if (itemName.ToLower() == "cancel")
        {
            Begin(player);
        }
        else
        {
            Item itemToSell = player.Inventory.GetItemByName(itemName);
            if (itemToSell != null)
            {
                player.Inventory.RemoveItem(itemToSell);
                int sellValue = itemToSell.SellValue;
                player.Gold += sellValue;
                Console.WriteLine($"You sold {itemName} for {sellValue} coins.");
            }
            else
            {
                Console.WriteLine($"You don't have a {itemName} to sell.");
            }
        }
        Thread.Sleep(2000);
        Begin(player);
    }

    private static void TalkToInnkeeper(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("        TALKING TO THE INNKEEPER   ");
        Console.WriteLine("===================================");
        Console.WriteLine("The innkeeper greets you warmly and offers a room if you need rest.");
        Console.WriteLine("You can stay here and recover your health if you wish.");
        Thread.Sleep(2000);
        Begin(player); 
    }

    private static void PrepareForJourney(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("       PREPARING FOR THE JOURNEY   ");
        Console.WriteLine("===================================");
        Console.WriteLine("You check your inventory and make sure you are ready for the next part of your adventure.");
        Thread.Sleep(2000);
    }
}
