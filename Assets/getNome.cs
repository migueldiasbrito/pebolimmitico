using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getNome : MonoBehaviour
{
    public AtributePlayer p;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        this.GetComponent<Text>().text = p.p1.nome;
    }

}
