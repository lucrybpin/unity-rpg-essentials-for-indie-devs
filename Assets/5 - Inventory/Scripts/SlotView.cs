using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlotView : MonoBehaviour
{
    [SerializeField] Image _image;
    [SerializeField] TMP_Text _text;
    [SerializeField] Image _border;

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
}
