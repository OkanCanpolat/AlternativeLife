using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    public void NewGamee()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("Ýlk", 1);
        SceneManager.LoadScene("Scene1");
    }
}
