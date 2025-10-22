using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item Definition")]
public class ItemDefinition : ScriptableObject
{
    public string ID;
    public string Name;
    public Sprite Icon;
    public int MaxStack;
}
