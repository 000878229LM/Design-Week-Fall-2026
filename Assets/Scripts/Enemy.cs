using UnityEngine;

public class Enemy : MonoBehaviour

{
    public GameObject bullet;
    public AudioSource source;
    public AudioClip call;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Bullet") == null)
        {
            source.PlayOneShot(call);
            Vector3 enemyPos = transform.position;
            GameObject currentBullet = Instantiate(bullet, enemyPos, Quaternion.identity);
            currentBullet.name = "Bullet";


        }
    }
}
