using System;

[Serializable]
public class InventorySlot
{
    public Item Item;
    public int Quantity;

    public bool IsEmpty()
    {
        if (Item == null)
            return true;

        if (Quantity == 0)
            return true;

        return false;
    }

    public bool IsFull()
    {
        if (Item == null)
            return false;

        if (Quantity == Item.Definition.MaxStack)
            return true;

        return false;
    }
}
