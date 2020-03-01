using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AresArrow : MonoBehaviour
{
    // Start is called before the first frame update
    public GodMode myGM;
    public GodMode otherGM;

    float manaRetrived = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " " + other.tag);
        if (other.gameObject.tag == "Meco")
        {
            myGM.m_Mana += manaRetrived;
            otherGM.m_Mana -= manaRetrived;
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "BalizaP1" || other.gameObject.tag == "BalizaP2" || other.gameObject.tag == "Wall" || other.gameObject.tag == "Ground")
        {
            Debug.Log("ZeusBall hit something");
            Destroy(gameObject);
        }
    }
}
