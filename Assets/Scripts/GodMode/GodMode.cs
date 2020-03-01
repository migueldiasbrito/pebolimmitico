using UnityEngine;

public class GodMode : MonoBehaviour
{
    public float manaRateReload;
    public float manaRateUse;
    public bool activated;
    public string activateKey = "";
    public AudioClip adC;
    public AudioSource adS;

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

            if (activated) adS.PlayOneShot(adC);
        }
        
        if(activated)
        {
            m_Mana = Mathf.Max(0, m_Mana - Time.deltaTime * manaRateUse);
            if (m_Mana > 0)
            {
                UpdateGodMode();
            }
            else
            {
                EndGodMode();
                activated = false;
            }
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
