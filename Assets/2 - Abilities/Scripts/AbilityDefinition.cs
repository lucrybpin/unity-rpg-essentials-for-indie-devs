using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ability Definition", menuName = "Scriptable Objects/Ability Definition")]
public class AbilityDefinition : ScriptableObject
{
    public string Name;
    public Sprite Icon;
    public List<AbilityLevelInfo> Levels;
}
