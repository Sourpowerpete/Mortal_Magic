using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    public GameObject containedGameObject;

    public Animator spriteAnimator;

    public int x;
    public int y;

    public bool playerOwned;




    // Start is called before the first frame update
    void Start()
    {
        if (containedGameObject != null)
        {
            //Positions the gameObject and centers it on the panel automatically
            containedGameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - this.GetComponent<SpriteRenderer>().bounds.size.y / 3 + containedGameObject.GetComponent<SpriteRenderer>().bounds.size.y / 2, this.gameObject.transform.position.z);
        }
            //Test Values
            x = 1;
            y = 3;

            spriteAnimator = GetComponent<Animator>(); //Gets a reference to the Animator
    }

    // Update is called once per frame
    void Update()
    {
        //Test calls to see if the Animator works properly
        spriteAnimator.SetBool("PlayerOwned", playerOwned);
        spriteAnimator.SetInteger("Y", y);  
    }

    public void SetX(int givenX)
    {
        x = givenX;
    }

    public void SetY(int givenY) 
    {
        y = givenY;
    }

    public int GetX()
    {
        return x;
    }

    public int GetY()
    {
        return y;
    }

    public void SetContainedGameObject(GameObject givenGameObject)
    {
        containedGameObject = givenGameObject;
    }

    //Moves a gameObject into the current Panel
    public void MoveToPanel(GameObject givenGameObject)
    {
        if (containedGameObject == null) //If nothing is on the panel...
        {
            if (givenGameObject != null)//and the given object isn't null...
            {
                containedGameObject = givenGameObject;  //Panel now contains the gameObject

                containedGameObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z); //and positions it (doesn't look centered to me)
            }
        }
    }

    public GameObject GetContainedGameObject() { return containedGameObject; }

    public void SetPlayerOwned(bool givenPlayerOwned)
    {
        playerOwned = givenPlayerOwned;
    }
    public bool GetPlayerOwned()
    {
        return playerOwned;
    }
}
