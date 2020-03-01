using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public Sprite readySprite;

    public GameObject chars;
    public GameObject chars2;

    public GameObject[] characters;
    public GameObject[] characters2;

    public GameObject player1;
    public GameObject player2;

    public SelectScreen card;

    public Image titleCard;
    public Image titleCard2;

    public GameObject slotPow;
    public GameObject slotAcc;

    public GameObject slotPow2;
    public GameObject slotAcc2;

    public GameObject prefabPow;
    public GameObject prefabAcc;
    //
    public Sprite[] spriterinos;
    public Sprite[] spriterinos2;

    Sprite spriten;
    Sprite spriten2;

    public Dictionary<Sprite, int> CharID;
    public Dictionary<Sprite, int> CharID2;

    bool Ready1;
    bool Ready2;
    bool GameReady;


    void Start()
    {
        bool Ready1 = false;
        bool Ready2 = false;
        bool StartGame = false;

        StaticForPlayer.idP1 = 2;
        StaticForPlayer.idP2 = 2;

        CharID = new Dictionary<Sprite, int>();
        CharID2 = new Dictionary<Sprite, int>();

        int i2 = 0;
        int i3 = 0;

        foreach (Sprite s in spriterinos)
        {
            CharID.Add(s, i2);
            i2++;
        }

        foreach (Sprite s in spriterinos2)
        {
            CharID2.Add(s, i3);
            i3++;
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

        SetCharacters();
    }

    void Update()
    {


    }

    public void SetCharacters()
    {
        if(slotPow.transform.childCount != 0)
        {
            foreach (Transform t in slotPow.transform)
            {
                Destroy(t.gameObject);
            }
        }
        if(slotAcc.transform.childCount != 0)
        {
            foreach (Transform t in slotAcc.transform)
            {
                Destroy(t.gameObject);
            }
        }

        if (slotPow2.transform.childCount != 0)
        {
            foreach (Transform t in slotPow2.transform)
            {
                Destroy(t.gameObject);
            }
        }
        if (slotAcc2.transform.childCount != 0)
        {
            foreach (Transform t in slotAcc2.transform)
            {
                Destroy(t.gameObject);
            }
        }

        int cardID = CharID[characters[2].GetComponentInChildren<CharacterSprite>().sprite];
        titleCard.sprite = card.nameCards[cardID];
        player1.GetComponent<Image>().sprite = characters[2].GetComponentInChildren<CharacterSprite>().sprite;

        if (cardID == 0 || cardID == 1 || cardID == 5)
        {
            for (int i = 0; i < 5; i++)
            {
                GameObject prefabP =  Instantiate(prefabPow, slotPow.transform.position, Quaternion.identity);
                prefabP.transform.parent = slotPow.transform;
            }
        }

        int cardID2 = CharID2[characters2[2].GetComponentInChildren<CharacterSprite>().sprite];
        titleCard2.sprite = card.nameCards[cardID2];
        player2.GetComponent<Image>().sprite = characters2[2].GetComponentInChildren<CharacterSprite>().sprite;

        if (cardID2 == 0 || cardID2 == 1 || cardID2 == 5)
        {
            for (int i = 0; i < 5; i++)
            {
                GameObject prefabP = Instantiate(prefabPow, slotPow2.transform.position, Quaternion.identity);
                prefabP.transform.parent = slotPow2.transform;
            }
        }
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

        SetCharacters();
        StaticForPlayer.idP1 = CharID[characters[2].GetComponentInChildren<CharacterSprite>().sprite];

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

        SetCharacters();
        StaticForPlayer.idP1 = CharID[characters[2].GetComponentInChildren<CharacterSprite>().sprite];

    }

    public void Confirm1()
    {
        Ready1 = true;
        this.gameObject.GetComponent<Image>().sprite = readySprite;
        CheckGame();
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

        SetCharacters();
        StaticForPlayer.idP2 = CharID2[characters2[2].GetComponentInChildren<CharacterSprite>().sprite];

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

        SetCharacters();
        StaticForPlayer.idP2 = CharID2[characters2[2].GetComponentInChildren<CharacterSprite>().sprite];
        Debug.Log("adiugadiub" + StaticForPlayer.idP2);
    }

    public void Confirm2()
    {
        Ready2 = true;
        this.gameObject.GetComponent<Image>().sprite = readySprite;
        CheckGame();
    }

    void CheckGame()
    {
        if(Ready1 == true && Ready2 == true)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }
}

