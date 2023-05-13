using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Enemy
{
    private Transform monsterTransform;
    public string type;
    public override void Move()
    {
        Debug.Log("Move from Enemy Class");
        //enemyTransform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*protected override void Update()
    {
        
    }*/


    /*public override void Attack()
    {
        base.Attack();
        Debug.Log("Monster attack");
    }*/
}
