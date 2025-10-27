using UnityEngine;

public class QuestExample : MonoBehaviour
{
    [SerializeField] QuestRepository _repository;
    [SerializeField] QuestController _questController;
    [SerializeField] QuestView _view;

    void Awake()
    {
        _questController = new QuestController(_repository);
        AddQuest("0000");
    }

    public void AddQuest(string questID)
    {
        Quest quest = _questController.AddQuest(questID);
        _view.Render(quest);
    }

    public void FinishTask(string taskID)
    {
        Quest quest = _questController.FinishTask(taskID);
        _view.Render(quest);
    }

    public void FinishQuest(string questID)
    {
        Quest quest = _questController.FinishQuest(questID);
        _view.Render(quest);
    }
}
