public class Act1Directions
{
    public static void GoNorth(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("               NORTH               ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You decide to head North towards the possible camp.");
        Console.WriteLine("As you travel North, you encounter a merchant with various items for sale.");
        Console.WriteLine();

        Dictionary<string, int> merchantItems = new Dictionary<string, int>
        {
            { "Health Potion", 20 },
            { "Mana Potion", 20 }
        };

        Shop merchantShop = new Shop("Merchant's Shop", merchantItems);
        merchantShop.ShowItems();

        bool continueShopping = true;
        while (continueShopping)
        {
            Console.WriteLine();
            Console.WriteLine("1. Buy an item");
            Console.WriteLine("2. Sell an item");
            Console.WriteLine("3. Leave the shop");
            Console.WriteLine();
            Console.Write("Choose an action: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    BuyItemFromShop(merchantShop, player);
                    break;
                case "2":
                    SellItemToShop(merchantShop, player);
                    break;
                case "3":
                    Console.WriteLine("You decide to leave the shop.");
                    continueShopping = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    private static void BuyItemFromShop(Shop shop, Player player)
    {
        Console.WriteLine("Items available for purchase:");
        shop.ShowItems();

        Console.Write("Enter the name of the item you want to buy (or type 'cancel' to go back): ");
        string itemName = Console.ReadLine();

        if (itemName.ToLower() == "cancel")
        {
            Console.WriteLine("You decide not to buy anything.");
            return;
        }

        shop.BuyItem(itemName, player);
    }

    private static void SellItemToShop(Shop shop, Player player)
    {
        Console.WriteLine("Items in your inventory:");
        player.Inventory.ShowInventory();

        Console.Write("Enter the name of the item you want to sell (or type 'cancel' to go back): ");
        string itemName = Console.ReadLine();

        if (itemName.ToLower() == "cancel")
        {
            Console.WriteLine("You decide not to sell anything.");
            return;
        }

        shop.SellItem(itemName, player);
    }

    public static void GoWest(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("               WEST                ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You decide to head West into the dense forest.");
        // Additional narrative and actions
    }

    public static void GoEast(Player player)
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("               EAST                ");
        Console.WriteLine("===================================");
        Console.WriteLine();
        Console.WriteLine("You decide to head East along the clear path.");
        // Additional narrative and actions
    }
}
