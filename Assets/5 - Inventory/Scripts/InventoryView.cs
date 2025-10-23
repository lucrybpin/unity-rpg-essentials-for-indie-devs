using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryView : MonoBehaviour
{
    [SerializeField] SlotView SelectedSlot;
    [SerializeField] List<SlotView> SlotsView;

    public event Action<int, int> OnItemSwap;

    void Awake()
    {
        for (int i = 0; i < SlotsView.Count; i++)
        {
            SlotsView[i].OnClicked += OnSlotClick;
            SlotsView[i].OnBegin += OnBegin;
            SlotsView[i].OnEnd += OnEndDrop;
        }
    }

    public void Render(Inventory inventory)
    {
        for (int i = 0; i < inventory.Slots.Count; i++)
        {
            SlotsView[i].Render(inventory.Slots[i]);
        }
    }

    void OnSlotClick(SlotView slot)
    {
        int index = SlotsView.IndexOf(slot);
        SelectedSlot?.Deselect();
        SelectedSlot = SlotsView[index];
        SelectedSlot.Select();
    }
    
    void OnBegin(SlotView slot)
    {
        int index = SlotsView.IndexOf(slot);
        SelectedSlot?.Deselect();
        SelectedSlot = SlotsView[index];
    }

    void OnEndDrop(PointerEventData eventData)
    {
        // Get Slot Under Mouse
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);

        SlotView slotUnderMouse = null;
        foreach (RaycastResult result in results)
            if (result.gameObject.TryGetComponent<SlotView>(out SlotView slot))
                slotUnderMouse = slot;

        // Trigger the Swap Event
        int index1 = SlotsView.IndexOf(SelectedSlot);
        int index2 = SlotsView.IndexOf(slotUnderMouse);

        OnItemSwap?.Invoke(index1, index2);
    }


}
