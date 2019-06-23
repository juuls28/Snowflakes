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
    public int poolSize = 1000;
    private List<GameObject> flakes;

    // Start is called before the first frame update
    void Start()
    {
        flakes = new List<GameObject>();
        for(int i = 0; i < poolSize; i++)
        {
            GameObject obj = (GameObject)Instantiate(snowflake);
            obj.SetActive(false);
            flakes.Add(obj);
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

        for (int i = 0; i < flakes.Count; i++)
        {
            if (!flakes[i].activeInHierarchy)
            {
                flakes[i].transform.position = new Vector3(xMin + (float)r.NextDouble() * (xMax - xMin), height, zMin + (float)r.NextDouble() * (zMax - zMin));
                flakes[i].SetActive(true);
                counter++;
                if(counter == flakesPerFrame)
                {
                    break;
                }
            }
        }
    }
}
