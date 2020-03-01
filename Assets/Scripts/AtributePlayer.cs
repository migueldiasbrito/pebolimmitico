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

    public MecoController mecop1, mecop1Def;
    public MecoController mecop2, mecop2Def;
    public GameObject Ball;
    public GameObject Arrow, Arrow2;
    public Transform k1, d11, d12, k2, d21, d22;

    void Start()
    {

        switch (StaticForPlayer.idP1)
        {
            case 0:
                p1 = genZeus();
                (p1.godMode as Zeus).mcDefenders = mecop1Def;
                (p1.godMode as Zeus).mcKeeper = mecop1;
                break;
            case 1:
                p1 = genAres();
                (p1.godMode as Ares).Keeper = k1;
                (p1.godMode as Ares).D1 = d11;
                (p1.godMode as Ares).D2 = d12;
                (p1.godMode as Ares).Arrow = Arrow;
                break;
            case 2:
                p1 = genAfrodite();
                (p1.godMode as Afrodite).myDefenders = mecop1Def;
                (p1.godMode as Afrodite).oponentDefenders = mecop2Def;
                break;
            case 3:
                p1 = genDionisio();
                (p1.godMode as Baco).myDefenders = mecop1Def;
                (p1.godMode as Baco).myKeeper = mecop1;
                break;
            case 4:
                p1 = genMedusa();
                (p1.godMode as Medusa).oponentKeeper = mecop2;
                (p1.godMode as Medusa).oponentDefenders = mecop2Def;
                (p1.godMode as Medusa).renderers = new List<SpriteRenderer>();
                (p1.godMode as Medusa).renderers.Add(godPieceP2.GetComponent<SpriteRenderer>());
                (p1.godMode as Medusa).renderers.Add(lacaioPiece2P1.GetComponent<SpriteRenderer>());
                (p1.godMode as Medusa).renderers.Add(lacaioPiece2P2.GetComponent<SpriteRenderer>());
                break;
            case 5:
                p1 = genCirce();
                (p1.godMode as Circe).renderers = new List<SpriteRenderer>();
                (p1.godMode as Circe).renderers.Add(godPieceP2.GetComponent<SpriteRenderer>());
                (p1.godMode as Circe).renderers.Add(lacaioPiece2P1.GetComponent<SpriteRenderer>());
                (p1.godMode as Circe).renderers.Add(lacaioPiece2P2.GetComponent<SpriteRenderer>());
                break;

        }

        switch (StaticForPlayer.idP2)
        {
            case 0:
                p2 = genZeus();
                (p2.godMode as Zeus).mcDefenders = mecop2Def;
                (p2.godMode as Zeus).mcKeeper = mecop2;
                break;
            case 1:
                p2 = genAres();
                (p2.godMode as Ares).Keeper = k2;
                (p2.godMode as Ares).D1 = d21;
                (p2.godMode as Ares).D2 = d22;
                (p2.godMode as Ares).Arrow = Arrow2;
                break;
            case 2:
                p2 = genAfrodite();
                (p2.godMode as Afrodite).myDefenders = mecop2Def;
                (p2.godMode as Afrodite).oponentDefenders = mecop1Def;
                break;
            case 3:
                p2 = genDionisio();
                (p2.godMode as Baco).myDefenders = mecop2Def;
                (p2.godMode as Baco).myKeeper = mecop2;
                break;
            case 4:
                p2 = genMedusa();
                (p2.godMode as Medusa).oponentKeeper = mecop1;
                (p2.godMode as Medusa).oponentDefenders = mecop1Def;
                (p2.godMode as Medusa).renderers = new List<SpriteRenderer>();
                (p2.godMode as Medusa).renderers.Add(godPieceP1.GetComponent<SpriteRenderer>());
                (p2.godMode as Medusa).renderers.Add(lacaioPiece1P1.GetComponent<SpriteRenderer>());
                (p2.godMode as Medusa).renderers.Add(lacaioPiece1P2.GetComponent<SpriteRenderer>());
                break;
            case 5:
                p2 = genCirce();
                (p2.godMode as Circe).renderers = new List<SpriteRenderer>();
                (p2.godMode as Circe).renderers.Add(godPieceP1.GetComponent<SpriteRenderer>());
                (p2.godMode as Circe).renderers.Add(lacaioPiece1P1.GetComponent<SpriteRenderer>());
                (p2.godMode as Circe).renderers.Add(lacaioPiece1P2.GetComponent<SpriteRenderer>());
                break;

        }

        if (StaticForPlayer.idP1 == 1)
        {
            (p1.godMode as Ares).otherGm = p2.godMode;
        }

        if (StaticForPlayer.idP2 == 1)
        {
            (p2.godMode as Ares).otherGm = p1.godMode;
        }

        if (StaticForPlayer.idP1 == 5)
        {
            (p1.godMode as Circe).otherGm = p2.godMode;
        }

        if (StaticForPlayer.idP2 == 5)
        {
            (p2.godMode as Circe).otherGm = p1.godMode;
        }

        p1.godMode.activateKey = "joystick 1 button 6";
        p2.godMode.activateKey = "joystick 2 button 6";


        godPieceP1.GetComponent<SpriteRenderer>().sprite = p1.spriteMain;
        godPieceP2.GetComponent<SpriteRenderer>().sprite = p2.spriteMain;


        lacaioPiece1P1.GetComponent<SpriteRenderer>().sprite = p1.spriteMain;
        lacaioPiece1P2.GetComponent<SpriteRenderer>().sprite = p1.spriteMain;

        lacaioPiece2P1.GetComponent<SpriteRenderer>().sprite = p2.spriteMain;
        lacaioPiece2P2.GetComponent<SpriteRenderer>().sprite = p2.spriteMain;
        ads = this.GetComponent<AudioSource>();

    }



    public Player genZeus()
    {
        Zeus gm = gameObject.AddComponent<Zeus>();

        gm.manaRateReload = 10;
        gm.manaRateUse = 100;
        gm.activated = false;
        gm.m_Mana = 0;
        gm.ZeusShotPower = 50;
  

        Player Zeus = new Player(Resources.Load<Sprite>("zeus/zeus"), //main
                                     Resources.Load<Sprite>("zeus/zeus"), //lacio 1
                                     Resources.Load<Sprite>("zeus/zeus"), //lacio2
                                     4, //força
                                     0.5f,//precisao
                                     Resources.Load<AudioClip>("zeus/golo_zeus"), //Golo
                                     Resources.Load<AudioClip>("zeus/musica_zeus"), //Tehem
                                     gm,
                                     "Zeus",
                                      Resources.Load<Sprite>("zeus/zeus-circulo")
                                     );


        return Zeus;
    }

    public Player genAres()
    {
        Ares gm = gameObject.AddComponent<Ares>();

        gm.manaRateReload = 10;
        gm.manaRateUse = 10;
        gm.interval = 1;
        gm.horizontalSpeed1 = 650;
        gm.horizontalSpeed2 = 350;
        gm.verticalSpeed1 = 175;
        gm.verticalSpeed2 = 75;

        Player Ares = new Player(Resources.Load<Sprite>("ares/ares"), //main
                                     Resources.Load<Sprite>("ares/ares"), //lacio 1
                                     Resources.Load<Sprite>("ares/ares"), //lacio2
                                     4, //força
                                     0.5f,//precisao
                                     Resources.Load<AudioClip>("ares/golo_ares"), //Golo
                                     Resources.Load<AudioClip>("ares/musica_ares"), //Tehem
                                     gm,
                                     "Ares",
                                     Resources.Load<Sprite>("ares/ares-circulo")
                                     );


        return Ares;
    }

    public Player genAfrodite()
    {
        GodMode gm = gameObject.AddComponent<Afrodite>();
        
        gm.manaRateReload = 10;
        gm.manaRateUse = 10;

        Player Afrodite = new Player(Resources.Load< Sprite >("Afrodite/afrodite"), //main
                                     Resources.Load<Sprite>("Afrodite/afrodite"), //lacio 1
                                     Resources.Load<Sprite>("Afrodite/afrodite"), //lacio2
                                     4, //força
                                     0.5f,//precisao
                                     Resources.Load<AudioClip>("Afrodite/golo_afrodite"), //Golo
                                     Resources.Load<AudioClip>("Afrodite/musica_afrodite"), //Tehem
                                     gm,
                                     "Afrodite",
                                     Resources.Load<Sprite>("Afrodite/afrodite-circulo")
                                     ) ;

        return Afrodite;
    }


    public Player genMedusa()
    {
        GodMode gm = gameObject.AddComponent<Medusa>();

        gm.manaRateReload = 10;
        gm.manaRateUse = 10;

        Player Medusa = new Player(Resources.Load<Sprite>("medusa/medusa"), //main
                                     Resources.Load<Sprite>("medusa/medusa"), //lacio 1
                                     Resources.Load<Sprite>("medusa/medusa"), //lacio2
                                     4, //força
                                     0.5f,//precisao
                                     Resources.Load<AudioClip>("medusa/golo_medusa"), //Golo
                                     Resources.Load<AudioClip>("medusa/musica_medusa"), //Tehem
                                     gm,
                                     "Medusa",
                                     Resources.Load<Sprite>("medusa/medusa-circulo")
                                     );

        return Medusa;
    }


    public Player genDionisio()
    {
        Baco gm = gameObject.AddComponent<Baco>();

        gm.manaRateReload = 10;
        gm.manaRateUse = 10;
        gm.ball = Ball;

        Player Dionisio = new Player(Resources.Load<Sprite>("dionisio/dionisio"), //main
                                     Resources.Load<Sprite>("dionisio/dionisio"), //lacio 1
                                     Resources.Load<Sprite>("dionisio/dionisio"), //lacio2
                                     4, //força
                                     0.5f,//precisao
                                     Resources.Load<AudioClip>("dionisio/golo_dionisio"), //Golo
                                     Resources.Load<AudioClip>("dionisio/musica_dionisio"), //Tehem
                                     gm,
                                     "Dionisio",
                                      Resources.Load<Sprite>("dionisio/dionisio-circulo")
                                     );

        return Dionisio;
    }

    public Player genCirce()
    {
        GodMode gm = gameObject.AddComponent<Circe>();

        gm.manaRateReload = 10;
        gm.manaRateUse = 5;

        Player Circe = new Player(Resources.Load<Sprite>("circe/circe"), //main
                                     Resources.Load<Sprite>("circe/circe"), //lacio 1
                                     Resources.Load<Sprite>("circe/circe"), //lacio2
                                     4, //força
                                     0.5f,//precisao
                                     Resources.Load<AudioClip>("circe/golo_circe"), //Golo
                                     Resources.Load<AudioClip>("circe/musica_circe"), //Tehem
                                     gm,
                                     "Circe",
                                     Resources.Load<Sprite>("circe/circe-circulo")
                                     );

        return Circe;
    }
}
