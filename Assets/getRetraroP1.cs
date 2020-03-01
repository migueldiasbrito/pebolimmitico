using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getRetraroP1 : MonoBehaviour
{
    public AtributePlayer at;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Image>().sprite = at.p1.moldura;
    }
}
