using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Interactions : MonoBehaviour
{

    public GameObject enemyGO;
    public GameObject enemyPrefab;
    public int speed;
    public int xMin, xMax;
    public int yMin, yMax;

    private List<GameObject> MonstersList = new List<GameObject>();
    
    private EnemyBase monsters = new Monster1(7, 9, 7, "hi");
    private EnemyBase monsters1 = new Monster2(9, 10, 15, "bye bye");
    
    
    public virtual void SpawnEnemy()
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
            Debug.Log("print");
        }
    }
    
    
    public virtual void EnemyMovement()
    {
        Transform enemyTransform = enemyGO.GetComponent<Transform>();
        enemyTransform.position = new Vector2(enemyTransform.position.x, enemyTransform.position.y- (Time.deltaTime));
        Debug.Log("enemyPrefab" + enemyPrefab.transform.position);
        Debug.Log("newVector2" + new Vector2());
    }

    private void Update()
    {
        EnemyMovement();
    }

    private void Start()
    {
        monsters1 = Instantiate(new Monster1(7, 9, 8, "hi"), Vector2.zero, Quaternion.identity);


        /*for (int i = 0; i < MonstersList.Count; i++)
        {
            MonstersList.Add(GameObject.Find("Monster"));
        }*/
        
        SpawnEnemy();
    }
}

