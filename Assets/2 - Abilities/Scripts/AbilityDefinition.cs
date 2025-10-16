using UnityEngine;

[CreateAssetMenu(fileName = "Ability Definition", menuName = "Scriptable Objects/Ability Definition")]
public class AbilityDefinition : ScriptableObject
{
    public string Name;
    public Sprite Icon;

    // List of spells details for each level
}
