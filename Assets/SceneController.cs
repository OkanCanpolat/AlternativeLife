using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController sceneController;
    public float x;
    public float y;
    public float z;
    public Transform Karakter;
    void Start()
    {
        sceneController = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MiniGame1()
    {
        SceneManager.LoadScene("MiniGame1");
    }
    public void MiniGame2()
    {
        PlayerPrefs.SetFloat("x",Karakter.position.x);
        PlayerPrefs.SetFloat("y",Karakter.position.y);
        PlayerPrefs.SetFloat("z",Karakter.position.z);
        SceneManager.LoadScene("MiniGame2");
    }
    public void OyunEkrani()
    {
        SceneManager.LoadScene("Scene1");
    }
}
