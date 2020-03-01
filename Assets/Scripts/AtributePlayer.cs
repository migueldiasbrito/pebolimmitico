using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Player p1;
    public Player p2;

    public AudioSource ads;
    
    public GameObject godPieceP1 , godPieceP2;
    public GameObject lacaioPiece1P1, lacaioPiece2P1, lacaioPiece1P2, lacaioPiece2P2;
    void Start()
    {

        switch (StaticForPlayer.idP1)
        {
            case 0:
                p1 = genZeus();
            break;
            case 1:
                p1 = genAres();
                break;
            case 2:
                p1 = genAfrodite();
                break;
            case 3:
                p1 = genDionisio();
                break;
            case 4:
                p1 = genMedusa();
                break;
            case 5:
                p1 = genCirce();
                break;

        }

        switch (StaticForPlayer.idP2)
        {
            case 0:
                p2 = genZeus();
                break;
            case 1:
                p2 = genAres();
                break;
            case 2:
                p2 = genAfrodite();
                break;
            case 3:
                p2 = genDionisio();
                break;
            case 4:
                p2 = genMedusa();
                break;
            case 5:
                p2 = genCirce();
                break;

        }



        godPieceP1.GetComponent<SpriteRenderer>().sprite = p1.spriteMain;
        godPieceP2.GetComponent<SpriteRenderer>().sprite = p2.spriteMain;


        lacaioPiece1P1.GetComponent<SpriteRenderer>().sprite = p1.spriteMain;
        lacaioPiece1P2.GetComponent<SpriteRenderer>().sprite = p2.spriteMain;

        lacaioPiece1P2.GetComponent<SpriteRenderer>().sprite = p1.spriteMain;
        lacaioPiece2P2.GetComponent<SpriteRenderer>().sprite = p2.spriteMain;
        ads = this.GetComponent<AudioSource>();

    }



    public Player genZeus()
    {
        Player Zeus = new Player(Resources.Load<Sprite>("Afrodite/afrodite"), //main
                                     Resources.Load<Sprite>("Afrodite/afrodite"), //lacio 1
                                     Resources.Load<Sprite>("Afrodite/afrodite"), //lacio2
                                     4, //força
                                     0.5f,//precisao
                                     Resources.Load<AudioClip>("Afrodite/golo_afrodite"), //Golo
                                     Resources.Load<AudioClip>("Afrodite/musica_afrodite") //Tehem
                                     );


        return Zeus;
    }

    public Player genAres()
    {
        Player Ares = new Player(Resources.Load<Sprite>("ares/ares"), //main
                                     Resources.Load<Sprite>("ares/ares"), //lacio 1
                                     Resources.Load<Sprite>("ares/ares"), //lacio2
                                     4, //força
                                     0.5f,//precisao
                                     Resources.Load<AudioClip>("ares/golo_ares"), //Golo
                                     Resources.Load<AudioClip>("ares/musica_ares") //Tehem
                                     );


        return Ares;
    }

    public Player genAfrodite()
    {
        Player Afrodite = new Player(Resources.Load< Sprite >("Afrodite/afrodite"), //main
                                     Resources.Load<Sprite>("Afrodite/afrodite"), //lacio 1
                                     Resources.Load<Sprite>("Afrodite/afrodite"), //lacio2
                                     4, //força
                                     0.5f,//precisao
                                     Resources.Load<AudioClip>("Afrodite/golo_afrodite"), //Golo
                                     Resources.Load<AudioClip>("Afrodite/musica_afrodite") //Tehem
                                     ) ;

        return Afrodite;
    }


    public Player genMedusa()
    {
        Player Medusa = new Player(Resources.Load<Sprite>("Afrodite/afrodite"), //main
                                     Resources.Load<Sprite>("Afrodite/afrodite"), //lacio 1
                                     Resources.Load<Sprite>("Afrodite/afrodite"), //lacio2
                                     4, //força
                                     0.5f,//precisao
                                     Resources.Load<AudioClip>("Afrodite/golo_afrodite"), //Golo
                                     Resources.Load<AudioClip>("Afrodite/musica_afrodite") //Tehem
                                     );

        return Medusa;
    }


    public Player genDionisio()
    {
        Player Dionisio = new Player(Resources.Load<Sprite>("Afrodite/afrodite"), //main
                                     Resources.Load<Sprite>("Afrodite/afrodite"), //lacio 1
                                     Resources.Load<Sprite>("Afrodite/afrodite"), //lacio2
                                     4, //força
                                     0.5f,//precisao
                                     Resources.Load<AudioClip>("Afrodite/golo_afrodite"), //Golo
                                     Resources.Load<AudioClip>("Afrodite/musica_afrodite") //Tehem
                                     );

        return Dionisio;
    }

    public Player genCirce()
    {
        Player Circe = new Player(Resources.Load<Sprite>("Afrodite/afrodite"), //main
                                     Resources.Load<Sprite>("Afrodite/afrodite"), //lacio 1
                                     Resources.Load<Sprite>("Afrodite/afrodite"), //lacio2
                                     4, //força
                                     0.5f,//precisao
                                     Resources.Load<AudioClip>("Afrodite/golo_afrodite"), //Golo
                                     Resources.Load<AudioClip>("Afrodite/musica_afrodite") //Tehem
                                     );

        return Circe;
    }
}
