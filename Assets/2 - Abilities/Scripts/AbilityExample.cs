using UnityEngine;

public class AbilityExample : MonoBehaviour
{
    [SerializeField] AbilityDefinition _meteorStormDefinition;
    [SerializeField] Ability _meteorStorm;

    void Awake()
    {
        _meteorStorm = new Ability(_meteorStormDefinition);
    }

    public void LevelUpMeteorStorm()
    {
        _meteorStorm.LevelUp();
    }

    public void ResetMeteorStorm()
    {
        _meteorStorm.Reset();
    }
}