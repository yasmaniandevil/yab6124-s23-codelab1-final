using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster1 : EnemyBase
{

    public string mes;
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

    public Monster1(int health, int damage, int speed, string mes) : base(health, damage, speed)
    {
        this.mes = mes;
    }
}
