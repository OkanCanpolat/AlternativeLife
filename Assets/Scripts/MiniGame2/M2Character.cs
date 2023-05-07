using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M2Character : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MovemenetSpeed;
    private bool canJump = true;
    public int HP;
    public GameObject GameoverCanvas;
    public GameObject[] Lifes;


    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(x * 7f, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, 10f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            HP--;
            if(HP <= 0)
            {
                Time.timeScale = 0;
                GameoverCanvas.SetActive(true);
            }

            foreach(GameObject go in Lifes)
            {
                if(go.activeSelf == true)
                {
                    go.SetActive(false);
                    return;
                }
            }
        }
    }
}
