using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    private float verticalInput;
    //private float position = 0; 

    private void Start()
    {
        startPosition = transform.position;
    }
    void Update()
    {
        //Control the movement of the paddle (change to VR Controls)
        /*if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            position = -1;
            Debug.Log("down key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            position = 1;
            Debug.Log("up key was pressed");
        }
        */
        verticalInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, verticalInput * speed);
    }   
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
