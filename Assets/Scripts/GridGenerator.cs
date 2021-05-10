using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using patterns;
public class GridGenerator : MonoBehaviour
{
    public static GridGenerator gridGenerator;
    public float xStart, yStart;
    public int rowLength, columnLength;
    public float xSpace, ySpace;
    public GameObject ObjectForGrid;
    public GameObject MenuPanel;
    private float dX,dY;
   

    private void Awake()
    {
        gridGenerator = GetComponent<GridGenerator>();
    }
    void Start()
    {
        //
        dX = 4.5f;
        dY = -9f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void Gen

    public void onStart()
    {
        xSpace = dX / (columnLength - 1);
        ySpace = dY / (rowLength - 1);
        //GameObject Object = ObjectPool.SharedInstance.GetPooledObject();
        for (int i = 0; i < columnLength; i++)
        {
            for (int j = 0; j < rowLength; j++)
            {
                GameObject Object = ObjectPool.SharedInstance.GetPooledObject();

                //Instantiate(ObjectForGrid, new Vector3(xStart + (xSpace * (i % columnLength)), yStart + (-ySpace * (i % rowLength))), Quaternion.identity);
                Object.transform.position = new Vector3(xStart + (xSpace * (i % columnLength)), yStart + (ySpace * (j % rowLength)));

                Object.SetActive(true);
            }


        }

        Debug.Log(xSpace);
        MenuPanel.SetActive(false);
    }

    public void onExit()
    {
        Application.Quit();
    }
    
}
