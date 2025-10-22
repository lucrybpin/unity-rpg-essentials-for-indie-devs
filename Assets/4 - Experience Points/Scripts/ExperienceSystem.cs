using UnityEngine;

public class ExperienceSystem
{
    [SerializeField] ExperienceTable _experienceTable;
    [SerializeField] int _currentLevel;
    [SerializeField] int _currentExp;

    public ExperienceSystem(ExperienceTable experienceTable)
    {
        _experienceTable = experienceTable;
        _currentLevel = 1;
        _currentExp = 0;
    }

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
