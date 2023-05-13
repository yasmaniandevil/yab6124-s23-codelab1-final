using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster2 :  EnemyBase2
{

    public string message2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Monster2(int health, int damage, int speed, string message2) : base(health, damage, speed)
    {
        this.message2 = message2;
    }
    
    public void SetStats(int damage, int health, int speed, string message2)
    {
        this.damage = damage;
        this.health = health;
        this.speed = speed;
        this.message2 = message2;
    }
}
