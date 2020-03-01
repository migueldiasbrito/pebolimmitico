﻿using UnityEngine;

public class GodMode : MonoBehaviour
{
    public float manaRateReload;
    public float manaRateUse;
    public bool activated;
    public string activateKey = "";

    /*protected */ public float m_Mana;

    public void Update()
    {
        /*if (activateKey != "" && Input.GetKeyDown(activateKey))
        {
            Debug.Log("WOOOOOOO");
        }*/
        if (!activated)
        {
            m_Mana = Mathf.Min(100, m_Mana + Time.deltaTime * manaRateReload);

            activated = m_Mana == 100 && Input.GetKeyDown(activateKey) && StartGodMode();
        }
        
        if(activated)
        {
            UpdateGodMode();
        }
    }
    public virtual bool StartGodMode()
    {
        return false;
    }

    public virtual void UpdateGodMode()
    {

    }

    public virtual void EndGodMode()
    {

    }
}
