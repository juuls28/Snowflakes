using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerPool : MonoBehaviour
{
    public int zMin = 0;
    public int zMax = 10;
    public int xMin = 0;
    public int xMax = 10;
    public int height = 4;
    public int flakesPerFrame = 1;


    public GameObject snowflake;
    public GameObject raindrop;
    public int poolSize = 1000;
    private List<GameObject> fallingObjects;

    


    // Start is called before the first frame update
    void Start()
    {
        fallingObjects = new List<GameObject>();
        for(int i = 0; i < poolSize; i++)
        {
            GameObject obj;

            //Fill Pool half with snow and rain
            if (i % 2 == 0)
            {
                obj = (GameObject)Instantiate(snowflake);
            }
            else
            {
                obj = (GameObject)Instantiate(raindrop);
            }
            
            obj.SetActive(false);
            fallingObjects.Add(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        StartSnow();

    }

    void StartSnow()
    {
        int counter = 0;


        System.Random r = new System.Random();

        for (int i = 0; i < fallingObjects.Count; i++)
        {
            if (!fallingObjects[i].activeInHierarchy)
            {
                fallingObjects[i].transform.position = new Vector3(xMin + (float)r.NextDouble() * (xMax - xMin), height, zMin + (float)r.NextDouble() * (zMax - zMin));
                fallingObjects[i].SetActive(true);
                counter++;
                if(counter == flakesPerFrame)
                {
                    break;
                }
            }
        }
    }
}
