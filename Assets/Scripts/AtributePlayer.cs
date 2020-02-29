using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Player p1;
    public Player p2;

    private AudioSource ads;
    public GameObject godPiece;
    void Start()
    {

        switch (StaticForPlayer.idP1)
        {
            case 1:
                p1 = genAfrodite();
            break;

        }

        switch (StaticForPlayer.idP2)
        {
            case 1:
                p1 = genAfrodite();
                break;

        }



        godPiece.GetComponent<SpriteRenderer>().sprite = p1.spriteMain;
        ads = this.GetComponent<AudioSource>();

    }

    public Player genAfrodite()
    {
        Player Afrodite = new Player(Resources.Load< Sprite >("Afrodite/afrodite"), //main
                                     Resources.Load<Sprite>("Afrodite/afrodite"), //lacio 1
                                     Resources.Load<Sprite>("Afrodite/afrodite"), //lacio2
                                     4, //força
                                     0.5f,//precisao
                                     Resources.Load<AudioClip>("Afrodite/musica_afrodite"),//Bola matreco
                                     Resources.Load<AudioClip>("Afrodite/golo_afrodite"), //Golo
                                     Resources.Load<AudioClip>("Afrodite/musica_afrodite") //Tehem
                                     ) ;

        return Afrodite;
    }
}
