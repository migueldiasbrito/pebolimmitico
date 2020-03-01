using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zeus : GodMode
{
    public float ZeusShotPower;
    public MecoController mcKeeper;
    public MecoController mcDefenders;

    public override bool StartGodMode()
    {
        if (mcKeeper.GetBall() != null)
        {
            mcKeeper.GetBall().GetComponent<Rigidbody>().AddForce(-mcKeeper.transform.right * ZeusShotPower, ForceMode.Impulse);
            mcKeeper.GetBall().AddComponent<ZeusBall>();
            // consume all mana
            m_Mana = 0;
            adS.PlayOneShot(adC);
            mcKeeper.GetBall().GetComponent<BallMovement>().PlayMeco();
        }
        if (mcDefenders.GetBall() != null)
        {
            mcDefenders.GetBall().GetComponent<Rigidbody>().AddForce(-mcDefenders.transform.right * ZeusShotPower, ForceMode.Impulse);
            mcDefenders.GetBall().AddComponent<ZeusBall>();
            // consume all mana
            m_Mana = 0;
            adS.PlayOneShot(adC);
            mcKeeper.GetBall().GetComponent<BallMovement>().PlayMeco();
        }
        // especial instantaneo, nunca activa
        return false;
    }
}
