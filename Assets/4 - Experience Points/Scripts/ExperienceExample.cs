using UnityEngine;

public class ExperienceExample : MonoBehaviour
{
    [SerializeField] ExperienceTable _experienceTable;
    [SerializeField] ExperienceSystem _experienceSystem;

    void Awake()
    {
        _experienceSystem = new ExperienceSystem(_experienceTable);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _experienceSystem.AddExp(2);
        }
    }
}
