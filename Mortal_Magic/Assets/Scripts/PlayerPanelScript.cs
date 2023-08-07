using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPanelScript : MonoBehaviour
{
    public Sprite[] yLevelSprites = new Sprite[3];
    public SpriteRenderer mySpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>(); //Get the SpriteRenderer
    }

    // Update is called once per frame
    void Update()
    {
        //mySpriteRenderer.sprite = yLevelSprites[2];
    }
}
