using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static bool isDead;
    void Start()
    {
        
    }

    void Update()
    {
        if (isDead)
        {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("Bullet"))
        {
            isDead = true;
        }
    }
}
