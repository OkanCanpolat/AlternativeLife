using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biricikController : MonoBehaviour
{
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            SceneController.sceneController.MiniGame1();
        }
        
    }
}
