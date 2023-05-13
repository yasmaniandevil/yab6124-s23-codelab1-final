using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyBase2 : MonoBehaviour
{

    public int damage;
    public int health;
    public GameObject enemyPrefab;
    public int speed;
    public float xMin, xMax;
    public float yMin, yMax;

    //constructor that takes damage, health and speed paramaters
    public EnemyBase2(int damage, int health, int speed)
    {
        this.damage = damage; //setting the obj damage to the passed in damage value
        this.health = health; //setting the obj health to passed in health value
        this.speed = speed;
    }

    private List<GameObject> MonstersList; //list to hold the enemy game objects
    
    //create an instance of Monster1 Class and assign it to a variable called Monsters
    private EnemyBase2 monsters = new Monster1(7, 9, 7, "hi");
    private EnemyBase2 monsters1 = new Monster2(9, 10, 15, "bye bye");
    
    
    //used to spawn the enemy
    public virtual void SpawnEnemy(GameObject enemyGO) //pass in GameObject called enemyGO
    {
      
            //random position for the enemy
            Vector2 randomPosition = new Vector2(Random.Range(
                xMin, xMax), Random.Range(yMin, yMax));
            //set the enemy position to the random position made above
            enemyGO.transform.position = randomPosition;
            //get the component from enemybase2 set it to enemy
            EnemyBase2 enemy = enemyGO.GetComponent<EnemyBase2>();
            //get component from monster1 set it to monster
            Monster1 monster = enemyGO.GetComponent<Monster1>();
            if (monster != null)
            {
                enemy = monster;
            }
            //if enemy is not null then do enemy movement
            if (enemy != null)
            {
                Debug.Log("print");
            }

        
    }
    
    //function used to move enemy
    public virtual void EnemyMovement(GameObject enemyGO)
    {
      
            //get enemyGO's Transform componenet set it to enemyTransform
            Transform enemyTransform = enemyGO.GetComponent<Transform>();
            //take the position of enemyTransform and move it 
            enemyTransform.position = new Vector2(
                enemyTransform.position.x, enemyTransform.position.y + (speed * Time.deltaTime));
            //Debug.Log("enemyPrefab" + enemyPrefab.transform.position);
            //Debug.Log("newVector2" + new Vector2());
        
        
    }

    private void Update()
    {
        foreach (GameObject monsterGO in MonstersList)
        {
            EnemyMovement(monsterGO);
        }
        
    }

    private void Start()
    {
        MonstersList = new List<GameObject>();
        
        float randomX = Random.Range(-8, 8);
        float randomY = Random.Range(-3, 3);
        Vector2 randomPos = new Vector2(randomX, randomY);
    
        GameObject monster1GO = Instantiate(enemyPrefab, randomPos, Quaternion.identity);
        Monster1 monster1 = monster1GO.GetComponent<Monster1>();
        MonstersList.Add(monster1GO);

        GameObject monster2GO = Instantiate(enemyPrefab, randomPos, Quaternion.identity);
        Monster2 monster2 = monster2GO.GetComponent<Monster2>();
        MonstersList.Add(monster2GO);

        foreach (GameObject monsterGO in MonstersList)
        {
            SpawnEnemy(monsterGO);
        }

    }
}

