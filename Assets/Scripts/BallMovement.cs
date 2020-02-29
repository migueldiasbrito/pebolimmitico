using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    GameObject ball;
    bool physics;
    void Start()
    {
        ball = this.gameObject;
        ball.GetComponent<Rigidbody>().useGravity = false;
        physics = false;
    }

    void Update()
    {
        if (physics == true)
        {
            ball.GetComponent<Rigidbody>().useGravity = true;

            if (Input.GetKey("w"))
            {
                ball.GetComponent<Rigidbody>().AddForce(new Vector3(3f, 0f, 0f));
            }

            if (Input.GetKey("s"))
            {
                ball.GetComponent<Rigidbody>().AddForce(new Vector3(-3f, 0f, 0f));
            }

            if (Input.GetKey("a"))
            {
                ball.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, 3f));
            }

            if (Input.GetKey("d"))
            {
                ball.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, -3f));
            }

            if (Input.GetKeyDown("space"))
            {
                ball.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, -500f));
            }
        }
    }

    private void OnMouseDown()
    {
        // Destroy(gameObject);
        ball.GetComponent<Rigidbody>().AddForce(new Vector3(450f, -200f, 50f));
        physics = true;
    }
}
