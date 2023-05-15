using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    public TextMesh healthText;

    
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
    public GameObject SpawnEnemy()//spawn enemy function
    {
        //make a new vector 2 with random range and store in randPos variable
        Vector2 randomPosition = new Vector2(Random.Range(-8, 8), Random.Range(-3, 3));
        //instantiate enemy prefab at randomPos and store in enemyGO var
        GameObject enemyGO = Instantiate(enemyPrefab, randomPosition, 
            quaternion.identity);

        //return enemyGO
        return enemyGO;
    }
    
    public void EnemyMovement()
    {
        //get transform comp off of enemy prefab store in var
        Transform enemyTransform = enemyPrefab.GetComponent<Transform>();
        //new position based off of speed and time
        enemyTransform.position = new Vector2(enemyTransform.position.x, enemyTransform.position.y- (speed * Time.deltaTime));
        //Debug.Log("enemyPrefab" + enemyPrefab.transform.position);
        //Debug.Log("newVector2" + new Vector2());

        /*transform.position = new Vector2(
            transform.position.x, transform.position.y + (speed * Time.deltaTime));*/
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        //destroy enemy
       //Debug.Log("Collided");
       Destroy(enemyPrefab);
    }
    
    

    // Start is called before the first frame update
    void Start()
    {
        healthText.text = "Health" + health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
