using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //public GameObject Monster1;
    //public GameObject Monster2;

    //create and instantiate two lists, one filled with monsters
    //other list for clones that get instantiated from enemy prefab
    public List<GameObject> MonsterList = new List<GameObject>();
    public List<GameObject> CloneList = new List<GameObject>();

    private int currentLevel = 0;
    
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
    

    // Start is called before the first frame update
    void Start()
    {


        //for loop that goes through the monster list
        for (int i = 0; i < MonsterList.Count; i++)
        {

            //go to the first thing in the list
            //stores it in currentObj
            GameObject currentObj = MonsterList[i];
            
            //grabs spawn function off of script, spawns the current obj
            //adds the clone list to it, so it spawns the clone list
            CloneList.Add(currentObj.GetComponent<EnemyBase>().SpawnEnemy()); 
            

        }


    }

    // Update is called once per frame
    void Update()
    {

        /*foreach (GameObject monster in CloneList)
        {
            GameObject cloneObj = CloneList[];
            monster.GetComponent<EnemyBase>().EnemyMovement();
        }*/

        //i want to loop through the clone list and add enemy movement to them but it isnt working
        /*if (MonsterList != null)
        {
            for (int i = 0; i < CloneList.Count; i++)
            {
                GameObject cloneOBJ = CloneList[i];
                cloneOBJ.GetComponent<EnemyBase>().EnemyMovement();
            }
        }*/
        
    }
    
}