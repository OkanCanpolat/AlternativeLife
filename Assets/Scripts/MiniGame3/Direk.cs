using UnityEngine;

public enum Type
{
    BLUE, WHITE
}
public class Direk : MonoBehaviour
{
    public Type type;
    public SpriteRenderer rend;

    private void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Changer"))
        {
            RandomType();
            SetColor();
        }
    }

    public void RandomType()
    {
            int r = Random.Range(0, 2);
            type = (Type)r;
    }

    public void SetColor()
    {
        if (type == Type.WHITE)
        {
            rend.color = Color.white;
        }

        else
        {
            rend.color = Color.blue;
        }
    }
}
