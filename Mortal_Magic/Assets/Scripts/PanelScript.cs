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
            containedGameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - this.GetComponent<SpriteRenderer>().bounds.size.y / 3 + containedGameObject.GetComponent<SpriteRenderer>().bounds.size.y / 2, this.gameObject.transform.position.z);
        }
            //x = 1;
            //y = 1;

            spriteAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
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

    public void MoveToPanel(GameObject givenGameObject)
    {
        if (containedGameObject != null)
        {
            if (givenGameObject != null)
            {
                containedGameObject = givenGameObject;

                containedGameObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
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
