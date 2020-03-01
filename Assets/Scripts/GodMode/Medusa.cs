using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medusa : GodMode
{
    public MecoController oponentDefenders;
    public MecoController oponentKeeper;

    public List<SpriteRenderer> renderers;

    public override bool StartGodMode()
    {
        oponentDefenders.GetComponent<Rigidbody>().velocity = Vector3.zero;
        oponentDefenders.enabled = false;
        oponentKeeper.GetComponent<Rigidbody>().velocity = Vector3.zero;
        oponentKeeper.enabled = false;

        for(int i = 0; i < renderers.Count; i++)
        {
            renderers[i].color = Color.grey;
        }

        return true;
    }

    public override void UpdateGodMode()
    {

    }

    public override void EndGodMode()
    {
        oponentDefenders.enabled = true;
        oponentKeeper.enabled = true;

        for (int i = 0; i < renderers.Count; i++)
        {
            renderers[i].color = Color.white;
        }
    }
}
