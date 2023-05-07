using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoBall : MonoBehaviour
{
    public Direk[] Direkler;
    public float Speed;
    public int TurnTime;
    private float elapsedTime;

    private void Start()
    {
        StartCoroutine(RotateCor());
        StartCoroutine(IncreaseSpeed());
    }
    private void Update()
    {
    }

    public IEnumerator RotateCor()
    {
        yield return new WaitForSeconds(1);
        while (true)
        {
            Rotate();
            yield return null;
        }
    }
    public void Rotate()
    {
        transform.Rotate(Vector3.forward * Speed * Time.deltaTime, Space.Self);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            Destroy(collision.gameObject);

            foreach (Direk d in Direkler)
            {
                if (d.type == Type.BLUE)
                {
                    d.type = Type.WHITE;
                    d.SetColor();
                }

                else
                {
                    d.type = Type.BLUE;
                    d.SetColor();
                }
            }
        }
    }

    public IEnumerator IncreaseSpeed()
    {
        yield return new WaitForSeconds(1);
        yield return new WaitForSeconds((float)TurnTime /3);
        Speed += 10;
        yield return new WaitForSeconds((float)TurnTime / 3);
        Speed += 20;

        Time.timeScale = 0;
    }
}
