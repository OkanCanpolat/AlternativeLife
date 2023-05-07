using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sayac : MonoBehaviour
{
    public static sayac _sayac;
    public int sayacArtir;
    void Start()
    {
        _sayac = this;
    }

    public void Arttir()
    {
        sayacArtir++;
    }

    
}
