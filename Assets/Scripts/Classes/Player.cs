using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public Sprite spriteMain;
    public Sprite spriteLacaio1, spriteLacaio2;
    public AudioClip bolaNoMatreco, bolaGolo;

    public float force, acuracy;

    public Player(Sprite spriteMain, Sprite spriteLacaio1, Sprite spriteLacaio2, float force, float acuracy)
    {
        this.spriteMain = spriteMain;
        this.spriteLacaio1 = spriteLacaio1;
        this.spriteLacaio2 = spriteLacaio2;
        this.force = force;
        this.acuracy = acuracy;
    }
}
