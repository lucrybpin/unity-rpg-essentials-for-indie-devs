using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Quest Repository", menuName = "Scriptable Objects/Quest Repository")]
public class QuestRepository : ScriptableObject
{
    public List<QuestDefinition> Quests;

    public QuestDefinition GetQuestDefinitionFromID(string questID)
    {
        for (int i = 0; i < Quests.Count; i++)
            if (Quests[i].QuestID == questID)
                return Quests[i];

        return null;
    }
}
