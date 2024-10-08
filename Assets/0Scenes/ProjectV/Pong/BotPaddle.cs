using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotPaddle : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    private float position;
    [SerializeField]
    private Rigidbody2D ballrb;
    public int stupidity;
    public int delay;

    private void Start()
    {
        delay = stupidity;
        startPosition = transform.position;
    }
    void Update()
    {
        //super basic bot ai
        //moving average, difference between where how much has to. Change the factors by a random amount.
        if (delay > 0)
        {
            delay--;
        }
        else
        {
            if (ballrb.velocity.y > position)
            {
                position = 1;
            }
            else if (ballrb.velocity.y < position)
            {
                position = -1;
            }
            delay = stupidity;
        }
        
        rb.velocity = new Vector2(rb.velocity.x, position * speed);
        Debug.Log(delay);
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        delay = stupidity;
    }
}
