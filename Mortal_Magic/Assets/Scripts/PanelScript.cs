using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    public GameObject containedGameObject;
    public Sprite currentSprite;

    public int x;
    public int y;




    // Start is called before the first frame update
    void Start()
    {
        containedGameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - this.GetComponent<SpriteRenderer>().bounds.size.y / 3 + containedGameObject.GetComponent<SpriteRenderer>().bounds.size.y / 2, this.gameObject.transform.position.z);
        x = 1;
        y = 1;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetX(int givenX)
    {
        x = givenX;
    }

    public void SetY(int givenY) { y = givenY; }

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
        return;
    }


}
