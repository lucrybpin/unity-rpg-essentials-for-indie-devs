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

    public Quest FinishQuest(string questID)
    {
        QuestDefinition questDefinition = _repository.GetQuestDefinitionFromID(questID);
        Quest questFound = FindQuest(questID);

        if (questFound == null)
            return null;

        bool allTasksFinished = true;
        foreach (QuestTask task in questFound.Tasks)
            if (!task.IsCompleted)
                allTasksFinished = false;

        if (allTasksFinished == true)
            questFound.IsCompleted = true;

        return questFound;
    }

    public Quest FinishTask(string taskID)
    {
        Quest questFound = null;
        foreach (Quest quest in _quests)
        {
            foreach (QuestTask task in quest.Tasks)
            {
                if (task.Definition.TaskID == taskID)
                {
                    task.IsCompleted = true;
                    questFound = quest;
                }
            }
        }

        return questFound;
    }

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