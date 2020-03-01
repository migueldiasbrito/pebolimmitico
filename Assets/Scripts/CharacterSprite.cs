using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharacterSprite : MonoBehaviour
{
    public Sprite sprite;
    void Start()
    {
    }

    void Update()
    {
        this.gameObject.GetComponent<Image>().sprite = sprite;
    }
}
