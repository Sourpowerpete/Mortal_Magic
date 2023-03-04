using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    public GameObject containedGameObject;
    public Sprite currentSprite;


    // Start is called before the first frame update
    void Start()
    {
        containedGameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
