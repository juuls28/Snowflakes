﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDeactivate : MonoBehaviour
{

    private bool alive = false;
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
        if (collision.gameObject.tag == "floor")
        {
            Debug.Log("Hit");
            this.Deactivate();

        }

    }

    bool getAlive()
    {
        return this.alive;
    }

    void Deactivate()
    {
        this.gameObject.SetActive(false);
    }
}
