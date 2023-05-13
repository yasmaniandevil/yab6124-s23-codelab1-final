using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster2 : EnemyBase
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

    public Monster2(int health, int damage, int speed, string message2) : base(damage, health, speed)
    {
        this.message2 = message2;
    }
}
