using System;
using UnityEngine;

[Serializable]
public class Ability
{
    [field: SerializeField] public int Level { get; private set; }
    [field: SerializeField] public AbilityDefinition Definition { get; private set; }
    [field: SerializeField] public bool IsInCooldown { get; private set; }

    public Ability(AbilityDefinition definition)
    {
        Definition = definition;
        Level = 1;
    }

    public void LevelUp()
    {
        if (Level < Definition.Levels.Count)
            Level++;
    }

    public void Reset()
    {
        Level = 1;
    }

    public (int, int) GetDamage()
    {
        return (Definition.Levels[Level - 1].BaseMinDamage, Definition.Levels[Level - 1].BaseMaxDamage);
    }

    public float GetCriticalChance()
    {
        return Definition.Levels[Level - 1].BaseCriticalChance;
    }

    public float GetCooldown()
    {
        return Definition.Levels[Level - 1].BaseCooldownTime;
    }

    public async Awaitable StartCooldown()
    {
        IsInCooldown = true;
        await Awaitable.WaitForSecondsAsync(GetCooldown(), Application.exitCancellationToken);
        IsInCooldown = false;
    }
}
