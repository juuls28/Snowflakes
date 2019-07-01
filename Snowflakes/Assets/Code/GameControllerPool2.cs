using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerPool2 : MonoBehaviour
{
    public int zMin = 0;
    public int zMax = 10;
    public int xMin = 0;
    public int xMax = 10;
    public int height = 4;
    public int flakesPerFrame = 1;


    public GameObject snowflake;
    public int poolSize = 1000;
    public Pool pool;
    private Queue<GameObject> inUse;


    // Start is called before the first frame update
    void Start()
    {
        inUse = new Queue<GameObject>();
        pool = new Pool(poolSize, snowflake);
        
    }

    // Update is called once per frame
    void Update()
    {
        StartSnow();
        CheckReturn();

    }

    void StartSnow()
    {
        
        System.Random r = new System.Random();

        for (int i = 0; i < flakesPerFrame; i++)
        {
            Debug.Log(pool.GetPoolSize());
            GameObject obj = pool.Get();
            inUse.Enqueue(obj);
            obj.transform.position = new Vector3(xMin + (float)r.NextDouble() * (xMax - xMin), height, zMin + (float)r.NextDouble() * (zMax - zMin));
            obj.SetActive(true);
            
        }
    }

    void CheckReturn()
    {
        while (!inUse.Peek().activeInHierarchy)
        {
            Debug.Log("Return to pool");
            pool.Add(inUse.Dequeue());
        }
    }
}
