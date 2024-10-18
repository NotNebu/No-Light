public class Item
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Effect { get; set; }
    public int SellValue { get; set; } 

    public Item(string name, string type, int effect, int sellValue = 0)
    {
        Name = name;
        Type = type;
        Effect = effect;
        SellValue = sellValue;
    }
}