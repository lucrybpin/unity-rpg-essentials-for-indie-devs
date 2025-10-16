using System;
using UnityEngine;

[Serializable]
public class Attribute
{
    [field: SerializeField] public int BaseValue { get; private set; }

    public Attribute(int baseValue)
    {
        BaseValue = baseValue;
    }
}
