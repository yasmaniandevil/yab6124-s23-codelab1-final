using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inter : MonoBehaviour
{
    
    //private List<GameObject> MonstersList; //list to hold the enemy game objects
    
    //create an instance of Monster1 Class and assign it to a variable called monsters
    private Monster1 mon0 = new Monster1(7, 9, 7, "hi");
    private Monster2 mon1 = new Monster2(9, 10, 15, "bye bye");
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
