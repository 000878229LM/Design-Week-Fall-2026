using UnityEditor;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public AudioSource source;
    public AudioClip deathClip;
    public AudioClip deathClip2;

    Collider2D playerCollider;
    Collider2D bulletCollider;

    void Start()
    {
        source = GetComponent<AudioSource>();
        
        playerCollider = GetComponent<Collider2D>();

    }

    void Update()
    {
        if (GameObject.Find("Bullet") != null)
        {
            GameObject bullet = GameObject.Find("Bullet");
            
            bulletCollider = bullet.GetComponent<Collider2D>();

            if (playerCollider.IsTouching(bulletCollider))
            {
                int number = Random.Range(1, 2);

                if (number == 0)
                {
                    source.PlayOneShot(deathClip);
                }
                else
                {
                    source.PlayOneShot(deathClip2);
                }
            }
        }
    }
}

