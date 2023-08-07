using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManagerScript : MonoBehaviour
{
    public GameObject panelPrefab;
    public List<GameObject> grid = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        
        int count = 0; //Current panel in array

        for(int i = 0; i <  3; i++)
        {
            for (int j = 0; j < 6; j++)
            {
               grid.Add(Instantiate(panelPrefab, new Vector3((j+1) * (1.0f/32.0f) * 40.0f, -(i+1) * (1.0f/32.0f) * 24.0f, 0), Quaternion.identity)); //Adds a new panel and places it in pixels/units
               grid[count].GetComponent<PanelScript>().SetX(j + 1); //Sets X of Panel in Grid
               grid[count].GetComponent<PanelScript>().SetY(i + 1); //Sets Y of Panel in Grid

               if(j >= 3)
               {
                   grid[count].GetComponent<PanelScript>().SetPlayerOwned(false); //These panels are enemy panels
               }

               else
               {
                   grid[count].GetComponent<PanelScript>().SetPlayerOwned(true); //These panels are player panels
               }

                grid[count].transform.parent = this.transform; //Makes the GrindManager the parent of the new panel

                count++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
