namespace OnlineStore;

public class ClothingItem : InventoryItem , ISellable
{
    public string Brand { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }


    public ClothingItem(string itemName, int itemPrice, int itemAmount, string brand, string size, string color) : base(itemName, itemPrice, itemAmount)
    {
        Brand = brand;
        Size = size;
        Color = color;
    }
    public void CalculateSalesPrice()
    {
        int price = ItemPrice * ItemAmount;
        Console.WriteLine($"Your total for {ItemAmount}x{ItemName} is ${price}");
    }
}