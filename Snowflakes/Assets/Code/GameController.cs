using System;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int zMin = 0;
    public int zMax = 10;
    public int xMin = 0;
    public int xMax = 10;
    public int height = 4;
    public int flakesPerFrame = 1;

    public GameObject flake;
    public GameObject drop;

    public bool drops = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xRand = 0;
        float zRand = 0;

        for (int i = 0; i < flakesPerFrame; i++)
        {
            System.Random r = new System.Random();

            Instantiate(flake, new Vector3(xMin + (float)r.NextDouble() * (xMax - xMin), 20, zMin + (float)r.NextDouble() * (zMax - zMin)), Quaternion.identity);
            if (drops == true)
            {
                Instantiate(drop, new Vector3(xMin + (float)r.NextDouble() * (xMax - xMin), 20, zMin + (float)r.NextDouble() * (zMax - zMin)), Quaternion.identity);
            }
        }
    }
}
