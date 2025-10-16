using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Attribute
{
    [field: SerializeField] public int BaseValue { get; private set; }

    [SerializeField] List<AttributeModifier> _modifiers = new List<AttributeModifier>();

    public Attribute(int baseValue)
    {
        BaseValue = baseValue;
    }

    public void AddModifier(AttributeModifier modifier)
    {
        if (_modifiers.Contains(modifier))
            return;

        _modifiers.Add(modifier);
    }

    public void RemoveModifier(AttributeModifier modifier)
    {
        if (!_modifiers.Contains(modifier))
            return;

        _modifiers.Remove(modifier);
    }

    // Calculate With Modifiers
}
