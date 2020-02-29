using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    GameObject ball;
    void Start()
    {
        ball = this.gameObject;
    }

    void Update()
    {
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
    }
}
