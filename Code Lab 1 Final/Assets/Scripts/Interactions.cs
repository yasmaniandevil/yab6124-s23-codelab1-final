using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Interactions : MonoBehaviour
{
  public GameObject enemyPrefab;

  private void Start()
  {
    SpawnEnemy();
  }
  private void SpawnEnemy()
  {
    Vector2 randomPosition = new Vector2(Random.Range(-8f, 8f), Random.Range(-2f, 2f));
    GameObject enemyGO = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    Enemy enemy = enemyGO.GetComponent<Enemy>();
    Monster monster = enemyGO.GetComponent<Monster>();
    if (monster != null)
    {
      enemy = monster;
   }
    enemy.Move();
  }

  /*private void MoveEnemies()
  {
    Enemy[] enemies = FindObjectOfType<Enemy>();
    foreach (Enemy enemy in enemies)
    {
      enemy.Move();
    }
  }*/
  
  
  }

