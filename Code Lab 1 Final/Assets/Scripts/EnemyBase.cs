using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyBase 
{

    public int damage;
    public int health;
    public int speed;
    public int xMin, xMax;
    public int yMin, yMax;
    public GameObject enemyPrefab;
    public GameObject enemyGO;

    public EnemyBase()
    {
        damage = 0;
        health = 0;
        speed = 0;
    }

    //base constructor
    public EnemyBase(int damage, int health, int speed)
    {
        this.damage = damage;
        this.health = health;
        this.speed = speed;
    }
    /*public virtual void SpawnEnemy()
    {
        Vector2 randomPosition = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        enemyGO = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
        EnemyBase enemy = enemyGO.GetComponent<EnemyBase>();
        Monster1 monster = enemyGO.GetComponent<Monster1>();
        if (monster != null)
        {
            enemy = monster;
        }
        //if enemy is not null then do enemy movement
        if (enemy != null)
        {
            enemy.EnemyMovement();
        }
    }*/
    
    /*public virtual void EnemyMovement()
    {
        Transform enemyTransform = enemyGO.GetComponent<Transform>();
        enemyTransform.position = new Vector2(enemyTransform.position.x, enemyTransform.position.y- (speed * Time.deltaTime));
        Debug.Log("enemyPrefab" + enemyPrefab.transform.position);
        Debug.Log("newVector2" + new Vector2());
    }*/

    public virtual void OnCollisionEnter2D(Collision2D col)
    {
       Debug.Log("Collided");
    }

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
}
