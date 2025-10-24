using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Quest
{
    public QuestDefinition Definition;
    public List<QuestTask> Tasks;
    public bool IsCompleted;

    public Quest(QuestDefinition definition, bool isCompleted)
    {
        Definition = definition;
        IsCompleted = isCompleted;

        Tasks = new List<QuestTask>();

        for (int i = 0; i < Definition.Tasks.Count; i++)
            Tasks.Add(new QuestTask(Definition.Tasks[i]));
    }
}