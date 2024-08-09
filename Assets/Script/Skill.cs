using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AttackType
{
    Default,
    Spawn,
    Charging,
    Throw,
}

public abstract class Skill
{
    public int damage;
    public int cost;
    public AttackType type;

    public abstract void SkillEffect();
}
