using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bicirikBulusmasi : MonoBehaviour
{
    public bool isDragging=false;
    public GameObject hava1, hava2,bicirik;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isDragging)
            hava();
        if (isDragging)
            Invoke("bekle", 2f);

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            isDragging=true;
            col.gameObject.transform.position = Vector2.zero;
        }
    }

    public void bekle()
    {
            bicirik.transform.Translate(0,-5*Time.deltaTime,0);
    }

    public void hava()
    {
        hava1.SetActive(false);
        hava2.SetActive(true);
    }
}
