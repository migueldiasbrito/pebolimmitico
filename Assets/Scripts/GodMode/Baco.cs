using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baco : GodMode
{
    public GameObject ball;
    public MecoController myDefenders;
    public MecoController myKeeper;

    private BacoBall bacoBall;

    public override bool StartGodMode()
    {
        bacoBall = ball.AddComponent<BacoBall>();
        bacoBall.myDefenders = myDefenders;
        bacoBall.myKeeper = myKeeper;
        return true;
    }

    public override void UpdateGodMode()
    {

    }

    public override void EndGodMode()
    {
        Destroy(bacoBall);
    }
}
