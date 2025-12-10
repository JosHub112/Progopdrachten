using UnityEngine;

public class Item
{
    public string itemName;
    public ItemType itemtype;
    public ItemStats stats;
    public int sellPrice;
    public bool isEquipped;

    public Item(string name, ItemType type, ItemStats stats, int price)
    {
        itemName = name;
        itemtype = type;
        this.stats = stats;
        sellPrice = price;
        isEquipped = false;
    }

    public string Describe()
    {
        return $"{itemName} ({itemtype})\n" +
               $"Damage: {stats.damage}, Defense: {stats.defense}, Weight: {stats.weight}\n" +
               $"Sell Price: {sellPrice}";
    }
}