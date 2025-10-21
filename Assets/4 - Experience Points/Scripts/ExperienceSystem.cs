using UnityEngine;

public class ExperienceSystem
{
    [SerializeField] int _currentLevel;
    [SerializeField] int _currentExp;

    public void AddExp(int experience)
    {
        _currentExp += experience;
        CheckLevelUp();
    }

    void CheckLevelUp()
    {
        // Checks
    }
}
