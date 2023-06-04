namespace OnlineStore;

public class ElectronicItem : InventoryItem , ISellable 
{
    public string WarrantyType { get;  set; }
    public string WarrantyLength { get; set; }


    public ElectronicItem(string itemName, int itemPrice, int itemAmount, string warrantyType, string warrantyLength) : base(itemName, itemPrice, itemAmount)
    {
        WarrantyType = warrantyType;
        WarrantyLength = warrantyLength;
    }
    public void CalculateSalesPrice()
    {
        int price = ItemPrice * ItemAmount;
        Console.WriteLine($"Your total for {ItemAmount}x{ItemName} is ${price}");
    }
}