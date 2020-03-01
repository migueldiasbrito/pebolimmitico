using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ares : GodMode
{
    public GameObject Arrow;
    public Transform Keeper;
    public Transform D1;
    public Transform D2;
    public float interval = 5f;
    public float horizontalSpeed1 = 5;
    public float horizontalSpeed2 = 5;
    public float verticalSpeed1 = 5;
    public float verticalSpeed2 = 5;

    public float timeSinceLastThrow;
    public GodMode otherGm;

    public override bool StartGodMode()
    {
        timeSinceLastThrow = interval;
        return true;
    }

    public override void UpdateGodMode()
    {
        timeSinceLastThrow += Time.deltaTime;

        if(timeSinceLastThrow >= interval)
        {
            GameObject arrow1 = Instantiate(Arrow);
            GameObject arrow2 = Instantiate(Arrow);
            GameObject arrow3 = Instantiate(Arrow);

            arrow1.transform.position = Keeper.transform.position + 4 * Vector3.up;
            arrow2.transform.position = D1.transform.position + 4 * Vector3.up;
            arrow3.transform.position = D2.transform.position + 4 * Vector3.up;

            arrow1.GetComponent<Rigidbody>().AddForce(- horizontalSpeed1 * (Keeper.transform.right) + verticalSpeed1 * (Keeper.transform.up));
            arrow2.GetComponent<Rigidbody>().AddForce(- horizontalSpeed2 * (D1.transform.right) + verticalSpeed2 * (D1.transform.up));
            arrow3.GetComponent<Rigidbody>().AddForce(- horizontalSpeed2 * (D2.transform.right) + verticalSpeed2 * (D2.transform.up));

            arrow1.GetComponent<AresArrow>().myGM = this;
            arrow1.GetComponent<AresArrow>().otherGM = otherGm;



            timeSinceLastThrow = 0;
        }
    }

    public override void EndGodMode()
    {

    }
}
