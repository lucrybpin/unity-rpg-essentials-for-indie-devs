using TMPro;
using UnityEngine;

public class AttributeModifierExample : MonoBehaviour
{
    [SerializeField] Attribute _agi;
    [SerializeField] TMP_Text _text;

    AttributeModifier _gloveModifier;

    void Start()
    {
        _agi = new Attribute(10);
        _gloveModifier = new AttributeModifier(ModifierType.Flat, 7);
        _text.text = $"{_agi.FinalValue}";
    }

    // Equip Glove
    public void EquipGloves()
    {
        _agi.AddModifier(_gloveModifier);
        _text.text = $"{_agi.FinalValue}";
    }

    // Unequip Glove
    public void UnequipGloves()
    {
        _agi.RemoveModifier(_gloveModifier);
        _text.text = $"{_agi.FinalValue}";
    }
}
