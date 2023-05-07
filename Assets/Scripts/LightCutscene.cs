using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightCutscene : MonoBehaviour
{
    private Light2D lightt;
    private float random;
    private float randomOpenTime;
    public float firstTime;

    private void Awake()
    {
        lightt = GetComponent<Light2D>();
        random = Random.Range(5, 10);
        randomOpenTime = Random.Range(1.5f, 3f);

        if(PlayerPrefs.GetInt("Ýlk") == 1)
        {
            StartCoroutine(FirstLight());
        }
    }

    public void StartLights()
    {
        StartCoroutine(FirstLight());
    }
    public IEnumerator FirstLight()
    {
        yield return new WaitForSeconds(4);
        lightt.enabled = false;
        yield return new WaitForSeconds(firstTime);
        lightt.enabled = true;
        yield return new WaitForSeconds(.5f);
        lightt.enabled = false;
        yield return new WaitForSeconds(firstTime);
        lightt.enabled = true;
        yield return new WaitForSeconds(.5f);
        lightt.enabled = false;
        yield return new WaitForSeconds(firstTime);
        lightt.enabled = true;
        yield return new WaitForSeconds(.5f);
        lightt.enabled = false;
        yield return new WaitForSeconds(firstTime);
        lightt.enabled = true;
        yield return new WaitForSeconds(.5f);
        lightt.enabled = false;
        yield return new WaitForSeconds(firstTime);
        lightt.enabled = true;
        yield return new WaitForSeconds(.5f);
        lightt.enabled = false;
    }
}
