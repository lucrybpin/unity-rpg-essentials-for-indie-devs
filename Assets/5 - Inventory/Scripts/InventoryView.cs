using System.Collections.Generic;
using UnityEngine;

public class InventoryView : MonoBehaviour
{
    [SerializeField] List<SlotView> SlotsView;

    void Awake()
    {
        //
    }

    public void Render(Inventory inventory)
    {
        for (int i = 0; i < inventory.Slots.Count; i++)
        {
            SlotsView[i].Render(inventory.Slots[i]);
        }
    }
}
