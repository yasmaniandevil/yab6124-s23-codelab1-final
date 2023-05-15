using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;

public class ASCII : MonoBehaviour
{

    public GameObject wall;
    public GameObject player;
    public GameObject door;

    private GameObject currentPlayer;
    private GameObject level;
    
    private const string FILE_NAME = "LevelNum.txt";
    private const string FILE_DIR = "/Levels/";
    private string FILE_PATH;
    
    
    private int currentLevel = 0;
    public float xOffset;
    public float yOffset;
    
    public int CurrentLevel
    {
        get { return currentLevel; }
        set
        {
            currentLevel = value;
            LoadLevel();
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        FILE_PATH = Application.dataPath + FILE_DIR + FILE_NAME;
        LoadLevel();
    }


    bool LoadLevel()
    {
        
        Destroy(level);

        level = new GameObject("Level");

        string newPath = FILE_PATH.Replace("Num", currentLevel + "");
        
        //load all the lines out of the file into an array of strings
        string[] fileLines = File.ReadAllLines(newPath);

        //for loop to go through each line
        for (int yPos = 0; yPos < fileLines.Length; yPos++)
        {
            //get each line out of the array
            string lineText = fileLines[yPos];

            //turn the current line into an array of chars
            char[] lineChars = lineText.ToCharArray();
            
            //loop through each char
            for (int xPos = 0; xPos < lineChars.Length; xPos++)
            {
                //get current char
                char c = lineChars[xPos];

                //make a variable for a new Gameobject
                GameObject newObj;

                switch (c)
                {
                    case 'p': //if its a p make new player
                        newObj = Instantiate<GameObject>(player);
                        currentPlayer = newObj;
                        break;
                    case 'w': //if its a make wall
                        newObj = Instantiate<GameObject>(wall);
                        break;
                    case 'D':
                        newObj = Instantiate<GameObject>(door);
                        break;
                    default:
                        newObj = null;
                        break;
                }

                if (newObj != null)
                {
                    newObj.transform.position =
                        new Vector2(
                            xOffset + xPos, 
                            yOffset - yPos);

                    newObj.transform.parent = level.transform;
                }
            }
        }

        return false;
    }

    public void Exit()
    {
        CurrentLevel++;
        Debug.Log("Hit Door");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
