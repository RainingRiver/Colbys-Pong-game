using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketController : MonoBehaviour
{

    public float speed;

    public KeyCode up;

    public KeyCode down;

    public bool isPlayer = true;

    public float offset = 0.2f;

    private Rigidbody rb;

    private Transform ball;

    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();

        ball = GameObject.FindGameObjectWithTag("Ball").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isPlayer)
        {
            MoveByPlayer();
        }
        else
        {
            MoveByComputer();
        }
    }
    
    //this lets you move the players racket
    private void MoveByPlayer()
    {
        bool pressedUp = Input.GetKey(this.up);
        bool pressedDown = Input.GetKey(this.down);

        if (pressedUp)
        {
            rb.velocity = Vector3.forward * speed;
        }

        if (pressedDown)
        {
            rb.velocity = Vector3.back * speed;
        }

        if (!pressedUp && !pressedDown)
        {
            rb.velocity = Vector3.zero;
        }
    }


    /// <summary>
    /// this let a AI move a racket
    /// </summary>
    private void MoveByComputer()
    {
        if (ball.position.z>transform.position.z + offset) 
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if (ball.position.z < transform.position.z - offset) 
        { 
            rb.velocity = Vector3.back * speed;
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}
