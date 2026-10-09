using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bullet;
    public AudioSource source;
    public AudioClip call;
    public float timerBulletLaunch;

    public static bool isDead;
    void Start()
    {
        timerBulletLaunch = 20000;
    }

    void Update()
    {
        if (timerBulletLaunch <= 0)
        {
            if (GameObject.Find("Bullet") == null)
            {
                source.PlayOneShot(call);
                Vector3 enemyPos = transform.position;
                GameObject currentBullet = Instantiate(bullet, enemyPos, Quaternion.identity);
                currentBullet.name = "Bullet";


            }
            if (isDead)
            {
                SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                spriteRenderer.enabled = false;
            }
        }
        else { timerBulletLaunch--; }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("Bullet"))
        {
            isDead = true;

         }

    }
}
