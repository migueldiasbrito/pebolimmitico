using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verManaP2 : MonoBehaviour
{
    public AtributePlayer p;
    private float scale;
    // Start is called before the first frame update

    private void Update()
    {
        scale = p.p2.godMode.m_Mana / 100;
        this.GetComponent<RectTransform>().localScale = new Vector3(scale, 1, 0);
    }
}
