using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Inventory
{
    [field: SerializeField] public List<InventorySlot> Slots { get; private set; }

    public Inventory(int capacity) 
    {
        Slots = new List<InventorySlot>(capacity);
        for (int i = 0; i < capacity; i++)
            Slots.Add(new InventorySlot());
    }

    public void AddItem(Item item)
    {
        InventorySlot slot = FindAvilableSlotWithItem(item);

        // Add to stack case
        if (slot != null && !slot.IsFull())
        {
            slot.Quantity++;
            return;
        }

        // No stack case
        slot = FindEmptySlot();
        if (slot == null)
            return; // Full Inventory Case

        slot.Item = item;
        slot.Quantity = 1;
        return;
    }

    public Item RemoveItem(Item item)
    {
        Item removedItem;
        InventorySlot slot = FindSlotWithItem(item);

        if (slot == null)
            return null;

        removedItem = slot.Item;

        if (slot.Quantity > 1)
            slot.Quantity--;
        else
        {
            slot.Item = null;
            slot.Quantity = 0;
        }

        return removedItem;
    }

    public bool Swap(int index1, int index2)
    {
        if (index1 < 0 || index1 >= Slots.Count || index2 < 0 || index2 >= Slots.Count)
            return false;

        if (index1 == index2)
            return true;

        (Slots[index1], Slots[index2]) = (Slots[index2], Slots[index1]);

        return true;
    }

    InventorySlot FindAvilableSlotWithItem(Item item)
    {
        foreach (InventorySlot slot in Slots)
            if (slot.Item == item && !slot.IsFull())
                return slot;

        return null;
    }

    InventorySlot FindEmptySlot()
    {
        foreach (InventorySlot slot in Slots)
            if (slot.IsEmpty())
                return slot;

        return null;
    }

    InventorySlot FindSlotWithItem(Item item)
    {
        foreach (InventorySlot slot in Slots)
            if (slot.Item == item)
                return slot;

        return null;
    }


}