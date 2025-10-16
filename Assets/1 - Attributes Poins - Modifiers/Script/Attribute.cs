using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Attribute
{
    [field: SerializeField] public int BaseValue { get; private set; }
    [field: SerializeField] public int FinalValue { get; private set; }

    [SerializeField] List<AttributeModifier> _modifiers = new List<AttributeModifier>();

    public Attribute(int baseValue)
    {
        BaseValue = baseValue;
        FinalValue = RecalcultateFinalValue(BaseValue, _modifiers);
    }

    public void AddModifier(AttributeModifier modifier)
    {
        if (_modifiers.Contains(modifier))
            return;

        _modifiers.Add(modifier);
        FinalValue = RecalcultateFinalValue(BaseValue, _modifiers);
    }

    public void RemoveModifier(AttributeModifier modifier)
    {
        if (!_modifiers.Contains(modifier))
            return;

        _modifiers.Remove(modifier);
        FinalValue = RecalcultateFinalValue(BaseValue, _modifiers);
    }

    int RecalcultateFinalValue(int baseValue, List<AttributeModifier> modifiers)
    {
        float calculatedValue = baseValue;

        // Flat
        foreach (AttributeModifier modifier in modifiers)
            if (modifier.Type == ModifierType.Flat)
                calculatedValue += modifier.Amount;

        // Percentage
        float finalPercentage = 1f;

        foreach (AttributeModifier modifier in modifiers)
            if (modifier.Type == ModifierType.Percentage)
                finalPercentage += (modifier.Amount / 100);

        calculatedValue = calculatedValue * finalPercentage;

        return (int)calculatedValue;
    }
}
