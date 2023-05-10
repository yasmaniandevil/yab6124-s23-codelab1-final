using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControlls : MonoBehaviour
{
    public float forceAmount;
    private Rigidbody2D rb;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //get rigidbody component off of of player
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the key is W
        //add force to rigid body
        //goes up
        //multiple by force amount
        if (Input.GetKey(KeyCode.W))
        {
            //rb.AddForce(Vector2.up * forceAmount);
            //Stop();

            transform.position = new Vector2(forceAmount * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * forceAmount);
            //Stop();
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * forceAmount);
            //Stop();
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * forceAmount);
            //Stop();
        }
    }

    void Stop()
    {
        rb.velocity = Vector2.zero;
        rb.inertia = 0f;
    }
}
