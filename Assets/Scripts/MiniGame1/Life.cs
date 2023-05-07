using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public static Life Instance;
    public GameObject[] Lifes;
    public int Amount;
    public GameObject GameOverCanvas;

    private void Awake()
    {
        Instance = this;
    }
    public void CheckLife()
    {
        foreach (GameObject go in Lifes)
        {
            if (go.activeSelf == true)
            {
                go.SetActive(false);

                if (Amount <= 0)
                {
                    Time.timeScale = 0;
                    GameOverCanvas.SetActive(true);
                }
                return;
            }
        }
        
    }
}
