using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class spawnerr : MonoBehaviour
{
    public GameObject kare;
    public GameObject dikdortgen;
    public GameObject ucgen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void karee()
    {
        Instantiate(kare, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z),
            quaternion.identity);
    }
    
    public void dikdortgenn()
    {
        
    }
    
    public void ucgenn()
    {
        
    }
}
