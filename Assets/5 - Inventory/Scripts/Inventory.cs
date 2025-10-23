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

    // Remove Item

    // Swap

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


}