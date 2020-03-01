using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject chars;
    public GameObject chars2;
    private GameObject[] characters;
    private GameObject[] characters2;
    public GameObject player1;
    public GameObject player2;
    //
    public Sprite[] spriterinos;
    public Sprite[] spriterinos2;
    Sprite spriten;
    Sprite spriten2;

    public Dictionary<Sprite, int> CharID;

    void Start()
    {
        CharID = new Dictionary<Sprite, int>();

        int i2 = 0;

        foreach(Sprite s in spriterinos)
        {
            CharID.Add(s, i2);
            i2++;
        }


        characters = new GameObject[chars.transform.childCount];
        characters2 = new GameObject[chars2.transform.childCount];

        for (int i = 0; i < chars.transform.childCount; i++)
        {
            characters[i] = chars.transform.GetChild(i).gameObject;
            characters2[i] = chars2.transform.GetChild(i).gameObject;
        }

        for(int i = 0; i < characters.Length; i++)
        {
            characters[i].GetComponentInChildren<CharacterSprite>().sprite = spriterinos[i];
            characters2[i].GetComponentInChildren<CharacterSprite>().sprite = spriterinos2[i];
        }


        for(int i = 0; i<=4; i++)
        {
            characters2[i].GetComponentInChildren<CharacterSprite>().id = i;
        }
    }

    void Update()
    {
        player1.GetComponent<Image>().sprite = characters[2].GetComponentInChildren<CharacterSprite>().sprite;
        player2.GetComponent<Image>().sprite = characters2[2].GetComponentInChildren<CharacterSprite>().sprite;
    }

    public void LeftButton1()
    {
        for(int i = 0; i < characters.Length; i++)
        {
            if (i == 0)
            {
                spriten = spriterinos[0];
            }

            if (i != characters.Length - 1)
            {
                characters[i].GetComponentInChildren<CharacterSprite>().sprite = characters[i + 1].GetComponentInChildren<CharacterSprite>().sprite;
                spriterinos[i] = spriterinos[i + 1];
            }

            else
            {
                characters[i].GetComponentInChildren<CharacterSprite>().sprite = spriterinos[5];
                spriterinos[4] = spriterinos[5];
                spriterinos[5] = spriten;
            }
        }

    }

    public void RightButton1()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            if (i == 0)
            {
                spriten = spriterinos[5];
                // characters[0].GetComponentInChildren<CharacterSprite>().sprite = spriterinos[5];
            }

            if (i != characters.Length - 1)
            {
                characters[characters.Length - i - 1].GetComponentInChildren<CharacterSprite>().sprite = characters[characters.Length - i - 2].GetComponentInChildren<CharacterSprite>().sprite;
                spriterinos[6 - i - 1] = spriterinos[6 - i - 2];
            }

            else
            {
                spriterinos[1] = spriterinos[0];
                spriterinos[0] = spriten;

                characters[0].GetComponentInChildren<CharacterSprite>().sprite = spriten;
            }
        }

        StaticForPlayer.idP1 = CharID[characters[2].GetComponentInChildren<CharacterSprite>().sprite];

    }

    public void Confirm1()
    {
        //StaticForPlayer.idP1 = characters[2].GetInstanceID;
    }

    public void LeftButton2()
    {
        for (int i = 0; i < characters2.Length; i++)
        {
            if (i == 0)
            {
                spriten2 = spriterinos2[0];
            }

            if (i != characters2.Length - 1)
            {
                characters2[i].GetComponentInChildren<CharacterSprite>().sprite = characters2[i + 1].GetComponentInChildren<CharacterSprite>().sprite;
                spriterinos2[i] = spriterinos2[i + 1];
            }

            else
            {
                characters2[i].GetComponentInChildren<CharacterSprite>().sprite = spriterinos2[5];
                spriterinos2[4] = spriterinos2[5];
                spriterinos2[5] = spriten2;
            }
        }

    }

    public void RightButton2()
    {
        for (int i = 0; i < characters2.Length; i++)
        {
            if (i == 0)
            {
                spriten2 = spriterinos2[5];
                // characters[0].GetComponentInChildren<CharacterSprite>().sprite = spriterinos[5];
            }

            if (i != characters2.Length - 1)
            {
                characters2[characters2.Length - i - 1].GetComponentInChildren<CharacterSprite>().sprite = characters2[characters2.Length - i - 2].GetComponentInChildren<CharacterSprite>().sprite;
                spriterinos2[6 - i - 1] = spriterinos2[6 - i - 2];
            }

            else
            {
                spriterinos2[1] = spriterinos2[0];
                spriterinos2[0] = spriten2;

                characters2[0].GetComponentInChildren<CharacterSprite>().sprite = spriten2;
            }

        }

        StaticForPlayer.idP2 = CharID[characters2[2].GetComponentInChildren<CharacterSprite>().sprite];
        Debug.Log("adiugadiub" + StaticForPlayer.idP2);
    }

    public void Confirm2()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }
}

