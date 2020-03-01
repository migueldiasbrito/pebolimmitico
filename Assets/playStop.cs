using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playStop : MonoBehaviour
{

    Animator a;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
  
    public void onOff()
    {
        if (a.isActiveAndEnabled)
        {
            a.enabled = false;
        }
        else
        {
            a.enabled = true;
        }
    }
}
