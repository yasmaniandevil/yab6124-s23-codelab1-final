using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    public TextMesh scoreText;

    public float score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "score" + score;
        Debug.Log(score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (GameObject.FindWithTag("Monster"))
        {
            score++;
            

        }
    }
}
