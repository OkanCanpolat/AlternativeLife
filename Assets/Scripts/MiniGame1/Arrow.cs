using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Transform Target;
    public float Speed;
    public Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Speed = Random.Range(3, 7);
    }
    private void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Life");
        Target = go.transform;
        Follow();
    }

    
    public void Follow()
    {
        Vector3 targetPos = (Target.position - transform.position).normalized * Speed;
        rb.velocity = targetPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Life"))
        {
            Life.Instance.Amount--;
            Life.Instance.CheckLife();
            Destroy(gameObject);

        }

        else if (collision.CompareTag("Shield"))
        {
            Destroy(gameObject);
        }
    }
}
