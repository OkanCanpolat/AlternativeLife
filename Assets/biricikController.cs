using UnityEngine;

public class biricikController : MonoBehaviour
{
    public string str;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            SceneController.sceneController.MiniGame3(str);
        }
    }
}
