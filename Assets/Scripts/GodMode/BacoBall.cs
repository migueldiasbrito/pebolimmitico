using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacoBall : MonoBehaviour
{
    public MecoController myDefenders;
    public MecoController myKeeper;
    public float speed = 3;
    public float rotation = 1;

    private Rigidbody mrigidbody;
    public bool drunk = true;
    private float myTime;

    // Start is called before the first frame update
    void Start()
    {
        mrigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myTime += Time.deltaTime;
        if (drunk) mrigidbody.velocity = speed * new Vector3(Mathf.Cos(2 * myTime * rotation), mrigidbody.velocity.y, Mathf.Sin(myTime * rotation));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("BacoBall hit wall");
            drunk = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.tag == "Meco")
        {
            Debug.Log("BacoBall hit Meco" + other.name);

            drunk = other.GetComponent<MecoController>() != myKeeper && other.GetComponent<MecoController>() != myDefenders;
        }

        if (other.gameObject.tag == "BalizaP1" || other.gameObject.tag == "BalizaP2")
        {
            Debug.Log("BacoBall hit baliza");
            Destroy(this);
        }
    }
}
