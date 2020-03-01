using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Afrodite : GodMode
{
    public MecoController oponentDefenders;
    public MecoController myDefenders;

    public List<Vector3> originalPosition;

    public override bool StartGodMode()
    {
        for(int i = 0; i < oponentDefenders.mecos.Length; i++)
        {
            oponentDefenders.mecos[i].transform.parent = myDefenders.gameObject.transform;
            oponentDefenders.mecos[i].transform.localScale = new Vector3(
                 -oponentDefenders.mecos[i].transform.localScale.x,
                 oponentDefenders.mecos[i].transform.localScale.y,
                 oponentDefenders.mecos[i].transform.localScale.z
                 );

            originalPosition.Add(oponentDefenders.mecos[i].transform.position);
            oponentDefenders.mecos[i].transform.position = myDefenders.mecos[i].transform.position + Vector3.right;
        }

        for (int i = 0; i < myDefenders.colliders.Length; i++)
        {
            ((SphereCollider)myDefenders.colliders[i]).radius *= 1.5f;
        }

        for (int i = 0; i < oponentDefenders.colliders.Length; i++)
        {
            ((SphereCollider)oponentDefenders.colliders[i]).enabled = false;
        }

        return true;
    }

    public override void UpdateGodMode()
    {

    }

    public override void EndGodMode()
    {
        for (int i = 0; i < oponentDefenders.mecos.Length; i++)
        {
            oponentDefenders.mecos[i].transform.parent = oponentDefenders.gameObject.transform;
            oponentDefenders.mecos[i].transform.localScale = new Vector3(
                 -oponentDefenders.mecos[i].transform.localScale.x,
                 oponentDefenders.mecos[i].transform.localScale.y,
                 oponentDefenders.mecos[i].transform.localScale.z
                 );
            oponentDefenders.mecos[i].transform.position = originalPosition[i];
        }

        originalPosition.Clear();

        for (int i = 0; i < myDefenders.colliders.Length; i++)
        {
            ((SphereCollider)myDefenders.colliders[i]).radius /= 1.5f;
        }

        for (int i = 0; i < oponentDefenders.colliders.Length; i++)
        {
            ((SphereCollider)oponentDefenders.colliders[i]).enabled = true;
        }
    }
}
