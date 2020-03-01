using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circe : GodMode
{
    public List<SpriteRenderer> renderers;
    public GodMode otherGm;

    private List<Sprite> sprites = new List<Sprite>();
    private Sprite lePig;

    public override bool StartGodMode()
    {
        if(lePig == null)
        {
            lePig = Resources.Load<Sprite>("pig/pig");
        }

        for(int i = 0; i < renderers.Count; i++)
        {
            sprites.Add(renderers[i].sprite);
            renderers[i].sprite = lePig;
        }

        otherGm.enabled = false;

        return true;
    }

    public override void UpdateGodMode()
    {

    }

    public override void EndGodMode()
    {
        for (int i = 0; i < renderers.Count; i++)
        {
            renderers[i].sprite = sprites[i];
        }

        otherGm.enabled = true;

        sprites.Clear();
    }
}
