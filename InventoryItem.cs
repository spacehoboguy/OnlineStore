using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace OnlineStore;

public class InventoryItem
{
    public string ItemName;
    public int ItemPrice;
    public int ItemAmount;

    public InventoryItem(string itemName, int itemPrice, int itemAmount)
    {
        ItemName = itemName;
        ItemPrice = itemPrice;
        ItemAmount = itemAmount;
    }
}