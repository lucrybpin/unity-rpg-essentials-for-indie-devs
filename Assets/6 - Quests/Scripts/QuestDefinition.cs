using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Quest XXXX - Quest Name", menuName = "Scriptable Objects/Quest Definition")]
public class QuestDefinition : ScriptableObject
{
    public string QuestID;
    public string Title;
    public string Description;
    public List<QuestTaskDefinition> Tasks;
}
