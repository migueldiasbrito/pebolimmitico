using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateMatreco : MonoBehaviour
{

    public int speed; 
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            this.GetComponent<Rigidbody>().AddTorque(0,0,-speed, ForceMode.VelocityChange);
        }
    }
}
