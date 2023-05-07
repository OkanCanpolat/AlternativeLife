using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class GlobalLight : MonoBehaviour
{
    public Light2D lightt;

    private void Awake()
    {
        lightt = GetComponent<Light2D>();
    }
    private void Start()
    {
        if(PlayerPrefs.GetInt("Ýlk") == 1)
        {
            StartCoroutine(Kapat());
        }

        PlayerPrefs.SetInt("Ýlk", 2);
    }

    public IEnumerator Kapat()
    {
        yield return new WaitForSeconds(4);
        lightt.intensity = 0.18f;
        yield return new WaitForSeconds(7);
        lightt.intensity = 0.9f;
    }
}
