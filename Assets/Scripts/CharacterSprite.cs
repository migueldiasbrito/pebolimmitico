using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharacterSprite : MonoBehaviour
{
    public Sprite sprite;
    void Start()
    {
        sprite = this.gameObject.GetComponent<Image>().sprite;
    }

    void Update()
    {
        this.gameObject.GetComponent<Image>().sprite = sprite;
    }
}
