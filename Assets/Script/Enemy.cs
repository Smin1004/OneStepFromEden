using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Mob
{
    public float moveDelay;
    protected float curMoveDelay;

    protected Vector2Int plusPos;

    public abstract void Move();
}
