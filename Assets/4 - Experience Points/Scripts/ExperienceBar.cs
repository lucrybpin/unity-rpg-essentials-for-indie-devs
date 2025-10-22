using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceBar : MonoBehaviour
{
    [SerializeField] Image _fillImage;
    [SerializeField] TMP_Text _textExperience;
    [SerializeField] TMP_Text _textLevel;
    [SerializeField] float _targetPercentage;

    public void SetExperience(int level, int currentExp, int maxExp)
    {
        _targetPercentage = (float) currentExp / maxExp;
        _textExperience.text = $"{currentExp.ToString()} / {maxExp.ToString()}";
        _textLevel.text = $"LEVEL {level}";
    }

    void Update()
    {
        _fillImage.fillAmount = Mathf.Lerp(_fillImage.fillAmount, _targetPercentage, 5.2f * Time.deltaTime);
    }
}
