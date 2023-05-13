using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase
{
    // Start is called before the first frame update
    public string name;
    public int damage;
    public string type;
    public GameObject sprite;
    private float moveSpeed;

    public EnemyBase()
    {
        name = "Monster";
        type = "Enemy1";
        sprite = new GameObject(name);

    }

    public EnemyBase(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
        type = "Enemy1";

    }
}

