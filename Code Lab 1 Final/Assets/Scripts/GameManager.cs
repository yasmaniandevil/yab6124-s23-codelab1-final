using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject Monster1;
    public GameObject Monster2;

    public List<GameObject> MonsterList = new List<GameObject>();
    public List<GameObject> CloneList = new List<GameObject>();
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

    
    //private int AmountEnemy = 10;

    // Start is called before the first frame update
    void Start()
    {
        //MonsterList.Add((Monster1));
        //MonsterList.Add((Monster2));

        //Invoke("spawnOb", 5f);

        for (int i = 0; i < MonsterList.Count; i++)
        {

            //go to the first thing in the list
            GameObject currentObj = MonsterList[i];
            
            CloneList.Add(currentObj.GetComponent<EnemyBase>().SpawnEnemy());

        }


    }

    // Update is called once per frame
    void Update()
    {
        /*for (int i = 0; i < MonsterList.Count; i++)
        {

            GameObject currentObj = MonsterList[i];

            Monster1.GetComponent<EnemyBase>().EnemyMovement();
        }*/

        foreach (GameObject monster in CloneList)
        {
            monster.GetComponent<EnemyBase>().EnemyMovement();
        }
    }
}