using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeusBall : MonoBehaviour
{
    public GameObject fuckedUpObject;
    public float timeDestroyed = 10f;

    private float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fuckedUpObject != null)
        {
            time += Time.deltaTime;

            if(time >= timeDestroyed)
            {
                fuckedUpObject.SetActive(true);
                Destroy(this);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (fuckedUpObject == null)
        {
            if (collision.gameObject.tag == "Wall")
            {
                Debug.Log("ZeusBall hit wall");
                Destroy(this);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (fuckedUpObject == null)
        {
            if (other.gameObject.tag == "Meco")
            {
                Debug.Log("ZeusBall hit Meco" + other.name);
                fuckedUpObject = other.gameObject.GetComponent<MecoController>().GetCorrespondingMeco(other);
                fuckedUpObject.SetActive(false);
                time = 0;
            }

            if (other.gameObject.tag == "BalizaP1" || other.gameObject.tag == "BalizaP2")
            {
                Debug.Log("ZeusBall hit baliza");
                Destroy(this);
            }
        }
    }
}
