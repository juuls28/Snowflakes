using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool
{
    public GameObject prefab;

    public int poolSize;
    
    private Stack<GameObject> pool;

    //Constructor
    public Pool(int poolSize, GameObject prefab)
    {
        this.poolSize = poolSize;
        this.prefab = prefab;
        this.init();
    }

    // init is called in constructor
    void init()
    {
        pool = new Stack<GameObject>();
        // Instantiate the pooled objects and disable them.
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = GameObject.Instantiate(prefab) as GameObject;
            obj.SetActive(false);
            pool.Push(obj);
        }
    }

    // Returns an object from the pool. Returns null if there are no more
    // objects free in the pool.
    public GameObject Get()
    {
        //What to do if pool empty?
        if (pool.Count == 0) {
            Debug.Log("Pool is empty");
            return null;
        }
        
        
        return pool.Pop();
    }

    //Adds a finished Object back to Pool
    public void Add(GameObject returner)
    {
        pool.Push(returner);
        
    }

    public int GetPoolSize()
    {
        return this.pool.Count;
    }


}
