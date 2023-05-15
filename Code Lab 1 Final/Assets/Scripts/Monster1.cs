using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster1 : EnemyBase
{

    public string name1;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Monster1(int health, int damage, int speed, string name) : base(health, damage, speed)
    {
        this.name1 = name;
    }
    
}
