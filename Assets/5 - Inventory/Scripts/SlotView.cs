using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotView : MonoBehaviour, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] Image _image;
    [SerializeField] TMP_Text _text;
    [SerializeField] Image _border;

    public event Action<SlotView> OnClicked;
    public event Action<SlotView> OnBegin;
    public event Action<SlotView> OnDuring;
    public event Action<PointerEventData> OnEnd;

    public void Render(InventorySlot slot)
    {
        if (slot.IsEmpty())
        {
            _image.enabled = false;
            _image.sprite = null;
            _text.enabled = false;
            return;
        }

        _image.enabled = true;
        _image.sprite = slot.Item.Definition.Icon;

        if (slot.Quantity > 1)
        {
            _text.enabled = true;
            _text.text = slot.Quantity.ToString();
        }
        else if (slot.Quantity <= 1)
        {
            _text.enabled = false;
        }
    }

    public void Select()
    {
        _border.enabled = true;
    }

    public void Deselect()
    {
        _border.enabled = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClicked?.Invoke(this);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        OnBegin?.Invoke(this);
    }

    public void OnDrag(PointerEventData eventData)
    {
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        OnEnd?.Invoke(eventData);
    }
}
