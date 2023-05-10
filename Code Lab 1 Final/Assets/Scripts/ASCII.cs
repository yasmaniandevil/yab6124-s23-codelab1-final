using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;

public class ASCII : MonoBehaviour
{

    public GameObject wall;
    public GameObject player;

    private const string FILE_NAME = "LevelNum.txt";
    private const string FILE_DIR = "/Levels/";
    private string FILE_PATH;
    
    private GameObject currentPlayer;
    private GameObject level;
    
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
        
        string[] fileLines = File.ReadAllLines(newPath);

        for (int yPos = 0; yPos < fileLines.Length; yPos++)
        {
            string lineText = fileLines[yPos];

            char[] lineChars = lineText.ToCharArray();

            for (int xPos = 0; xPos < lineChars.Length; xPos++)
            {
                char c = lineChars[xPos];

                GameObject newObj;

                switch (c)
                {
                    case 'w':
                        newObj = Instantiate<GameObject>(wall);
                        break;
                    case 'p':
                        newObj = Instantiate<GameObject>(player);
                        currentPlayer = newObj;
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
    // Update is called once per frame
    void Update()
    {
        
    }
}
