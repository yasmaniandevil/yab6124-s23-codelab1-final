using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster1 : EnemyBase2
{

    public string name1;
    // Start is called before the first frame update
    void Start()
    {
        //SpawnEnemy();
        
    }

    // Update is called once per frame
    void Update()
    {
        //EnemyMovement();
    }

    public Monster1(int health, int damage, int speed, string name) : base(health, damage, speed)
    {
        this.name1 = name;
    }

    public void SetStats(int damage, int health, int speed, string name)
    {
        this.damage = damage;
        this.health = health;
        this.speed = speed;
        this.name1 = name;
    }
}
