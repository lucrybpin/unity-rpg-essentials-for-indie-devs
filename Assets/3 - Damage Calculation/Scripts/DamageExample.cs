using UnityEngine;

public class DamageExample : MonoBehaviour
{
    [SerializeField] int _attributePoints;
    [SerializeField] Ability[] _abilities;
    [SerializeField] AbilityButton[] _abilityButtons;

    void Awake()
    {
        _abilityButtons[0].onClick += ExecuteAbility;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ExecuteAbility(0);
        }
    }

    void ExecuteAbility(int index)
    {
        Ability ability = _abilities[index];

        if (ability.IsInCooldown)
            return;

        (int minDamage, int maxDamage) = ability.GetDamage();
        int baseDamage = Random.Range(minDamage, maxDamage + 1);
        bool isCritical = Random.Range(0, 1f) < ability.GetCriticalChance() ? true : false;

        int finalDamage = CombatUtils.CalculateDamage(baseDamage, _attributePoints, isCritical);

        // View
        _ = _abilityButtons[index].EnterCooldown(ability.GetCooldown());

        Debug.Log($">>>> Executing Ability {0} - Damage {finalDamage}");

        _ = ability.StartCooldown();
    }
}
