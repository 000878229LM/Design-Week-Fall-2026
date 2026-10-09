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
        Debug.Log("Got audio source");
        playerCollider = GetComponent<Collider2D>();
        Debug.Log("Got playerCollider");
    }

    void Update()
    {
        if (GameObject.Find("Bullet") != null)
        {
           
            GameObject bullet = GameObject.Find("Bullet");
            Debug.Log("Found bullet");
            bulletCollider = bullet.GetComponent<Collider2D>();

            if (playerCollider.IsTouching(bulletCollider))
            {
                Debug.Log("Player is touching bullet");
                int number = Random.Range(1, 2);

                if (number == 0)
                {
                    Debug.Log("Playing first deathclip");
                    source.PlayOneShot(deathClip);
                }
                else
                {
                    source.PlayOneShot(deathClip2);
                    Debug.Log("Playing second deathclip");
                }
            }
        }
    }
}

