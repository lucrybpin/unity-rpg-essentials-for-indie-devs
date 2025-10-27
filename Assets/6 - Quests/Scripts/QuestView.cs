using TMPro;
using UnityEngine;

public class QuestView : MonoBehaviour
{
    [SerializeField] TMP_Text _title;
    [SerializeField] TMP_Text _description;
    [SerializeField] TMP_Text _task0;
    [SerializeField] TMP_Text _task1;
    [SerializeField] TMP_Text _task2;
    [SerializeField] GameObject _isCompletedText;

    public void Render(Quest quest)
    {
        _title.text = quest.Definition.Title;
        _description.text = quest.Definition.Description;

        _task0.text = $"• {quest.Tasks[0].Definition.Title}";
        if (quest.Tasks[0].IsCompleted)
        {
            _task0.color = Color.gray;
            _task0.fontStyle = FontStyles.Strikethrough;
        }
        else
            _task0.color = Color.white;

        _task1.text = $"• {quest.Tasks[1].Definition.Title}";
        if (quest.Tasks[1].IsCompleted)
        {
            _task1.color = Color.gray;
            _task1.fontStyle = FontStyles.Strikethrough;
        }
        else
            _task1.color = Color.white;

        _task2.text = $"• {quest.Tasks[2].Definition.Title}";
        if (quest.Tasks[2].IsCompleted)
        {
            _task2.color = Color.gray;
            _task2.fontStyle = FontStyles.Strikethrough;
        }
        else
            _task2.color = Color.white;

        _isCompletedText.SetActive(false);
        if(quest.IsCompleted)
            _isCompletedText.SetActive(true);
    }
}
