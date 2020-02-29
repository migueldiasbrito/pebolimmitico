using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateMatreco : MonoBehaviour
{
    Rigidbody r;
    public int torque;

    void Start()
    {
        r = this.gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.J))
        {
            float turn = Input.GetAxis("Horizontal");
            r.AddTorque(transform.forward * torque);
        }
        if (Input.GetKey(KeyCode.K))
        {
            float turn = Input.GetAxis("Horizontal");
            r.AddTorque(-transform.forward * torque);
        }

    }
}
