using System;
using UnityEngine;

[Serializable]
public class QuestTask
{
    public QuestTaskDefinition Definition;
    public bool IsCompleted;

    public QuestTask(QuestTaskDefinition definition)
    {
        Definition = definition;
    }
}
