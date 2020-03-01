using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class veManaP1 : MonoBehaviour
{
    public AtributePlayer p;
    private float scale;
    // Start is called before the first frame update

    private void Update()
    {
        scale = p.p1.godMode.m_Mana / 100;
        this.GetComponent<RectTransform>().localScale = new Vector3(scale, 1, 0);
    }
}
