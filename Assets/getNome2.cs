using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getNome2 : MonoBehaviour
{
    public AtributePlayer p;
    // Start is called before the first frame update
  
    private void Update()
    {
        this.GetComponent<Text>().text = p.p2.nome;
    }
}
