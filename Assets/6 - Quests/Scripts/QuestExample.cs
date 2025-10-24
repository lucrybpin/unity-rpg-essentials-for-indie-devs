using UnityEngine;

public class QuestExample : MonoBehaviour
{
    [SerializeField] QuestRepository _repository;
    [SerializeField] QuestController _questController;

    void Awake()
    {
        _questController = new QuestController(_repository);
        AddQuest("0000");
    }

    public void AddQuest(string questID)
    {
        Quest quest = _questController.AddQuest(questID);
    }
}
