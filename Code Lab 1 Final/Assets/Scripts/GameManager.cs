using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject objectwithScript;
    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public List<GameObject> MonsterList;
    private int AmountEnemy = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        MonsterList = new List<GameObject>();
        MonsterList.Add(GameObject.Find("Enemy"));
        MonsterList.Add(GameObject.Find("Monster1"));
        for (int i = 0; i < AmountEnemy; i++)
        {

            objectwithScript.GetComponent<Monster1>().SpawnEnemy();
            objectwithScript.GetComponent<Monster1>().EnemyMovement();
            Debug.Log("AmountEnemy" + AmountEnemy);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
