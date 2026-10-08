using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform player;
    public bool yInc, xInc;
    Vector2 direction;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = player.position - transform.position;
    }

        // Update is called once per frame
        void Update()
    {
   
    }
}
