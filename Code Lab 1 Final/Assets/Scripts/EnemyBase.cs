using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyBase: MonoBehaviour  
{

    public int damage;
    public int health;
    public int speed;
    public int xMin, xMax;
    public int yMin, yMax;
    public GameObject enemyPrefab;
    public GameObject enemyGO;

    private bool hasSpawned;
    //private GameObject enemyGO;

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
    public GameObject SpawnEnemy()
    {
        Vector2 randomPosition = new Vector2(Random.Range(-8, 8), Random.Range(-3, 3));
        GameObject enemyGO = Instantiate(enemyPrefab, randomPosition, 
            quaternion.identity);

        return enemyGO;
        /*EnemyBase enemy = enemyGO.GetComponent<EnemyBase>();
        Monster1 monster1 = enemyGO.GetComponent<Monster1>();
        Monster2 monster2 = enemyGO.GetComponent<Monster2>();
        if (monster1 || monster2 != null)
        {
            enemy = monster1;
            enemy = monster2;
        }*/
    }
    
    public void EnemyMovement()
    {
        //Transform enemyTransform = enemyPrefab.GetComponent<Transform>();
        //enemyTransform.position = new Vector2(enemyTransform.position.x, enemyTransform.position.y- (speed * Time.deltaTime));
        //Debug.Log("enemyPrefab" + enemyPrefab.transform.position);
        //Debug.Log("newVector2" + new Vector2());

        transform.position = new Vector2(
            transform.position.x, transform.position.y + (speed * Time.deltaTime));
    }

    public virtual void OnCollisionEnter2D(Collision2D col)
    {
       Debug.Log("Collided");
       Destroy(enemyPrefab);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
