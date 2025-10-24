using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class QuestController
{
    QuestRepository _repository;
    [SerializeField] List<Quest> _quests = new List<Quest>();

    public QuestController(QuestRepository repository)
    {
        _repository = repository;
    }

    // Add Quest
    public Quest AddQuest(string questID)
    {
        Quest questFound = FindQuest(questID);
        if (questFound == null)
        {
            QuestDefinition questDefinition = _repository.GetQuestDefinitionFromID(questID);
            Quest newQuest = new Quest(questDefinition, false);

            if (newQuest != null)
                _quests.Add(newQuest);

            return newQuest;
        }
        return null;
    }

    // Finish Quest

    // Finish a Task

    public Quest FindQuest(string questID)
    {
        QuestDefinition questDefinition = _repository.GetQuestDefinitionFromID(questID);

        Quest questFound = null;
        for (int i = 0; i < _quests.Count; i++)
            if (_quests[i].Definition == questDefinition)
                questFound = _quests[i];

        return questFound;
    }
}