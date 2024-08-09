using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mob : MonoBehaviour
{
    public int hp;
    public int maxhp;
    public int shield;

    public float power;

    public Vector2Int curPos;

    public void Damage(int value)
    {

    }
}
