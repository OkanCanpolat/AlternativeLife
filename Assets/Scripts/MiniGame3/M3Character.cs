using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M3Character : MonoBehaviour
{

    Rigidbody2D rb;
    public float Speed;
    public GameObject projectile;
    public int HP;
    public GameObject GameoverCanvas;
    public GameObject[] Lifes;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(x * Speed, y * Speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Obstacle"))
        {
            Direk d = collision.GetComponent<Direk>();
            if(d.type == Type.WHITE)
            {
                HP--;
                ControlHP();
            }
        }
    }

    public void ControlHP()
    {
        ControlLifes();

        if (HP <= 0)
        {
            GameoverCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ControlLifes()
    {
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
