﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDelte : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(this.gameObject.name);
        if(collision.gameObject.tag=="floor")
        Destroy(this.gameObject);
    }
}
