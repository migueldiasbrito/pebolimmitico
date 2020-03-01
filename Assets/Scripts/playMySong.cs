using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMySong : MonoBehaviour
{

    int oldStatp1;
    int oldStatp2;

    int statp1;
    int statp2;

    public AudioSource ads;
    private void Start()
    {
        ads.PlayOneShot(ReturnToPlay(2));
    }
    // Update is called once per frame
    void Update()
    {
        if(statp1 != oldStatp1 || statp2 != oldStatp2)
        {
            if(statp1 != oldStatp1)
            {
                oldStatp1 = statp1;
                ads.Stop();
                ads.PlayOneShot(ReturnToPlay(oldStatp1));
            }
            if (statp2 != oldStatp2)
            {
                oldStatp2 = statp2;
                ads.Stop();
                ads.PlayOneShot(ReturnToPlay(oldStatp2));
            }

        }
        statp1 = StaticForPlayer.idP1;
        statp2 = StaticForPlayer.idP2;
    }



    private AudioClip ReturnToPlay(int DeusInt)
    {
      
        switch (DeusInt)
        {
            case 0:
                return Resources.Load<AudioClip>("zeus/musica_zeus");
             
            case 1:
                return Resources.Load<AudioClip>("ares/musica_ares");

            case 2:
                return Resources.Load<AudioClip>("Afrodite/musica_afrodite");

            case 3:
                return Resources.Load<AudioClip>("dionisio/musica_dionisio");

            case 4:
                return Resources.Load<AudioClip>("medusa/musica_medusa");

            case 5:
                return Resources.Load<AudioClip>("circe/musica_circe");


            default: return Resources.Load<AudioClip>("Afrodite/musica_afrodite");


        }





    }
}
