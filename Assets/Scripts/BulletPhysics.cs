using UnityEngine;

public class BulletPhysics : MonoBehaviour
{
    private Rigidbody2D rb;

    // temp variables for star calculations
    public static float bulletDuration = 5;
    public static bool end = false;

    void Start()
    {
        
    }

    void Update()
    {
        TempStarStuff();
        TempMovement();
    }

    void TempStarStuff()
    {
        if (TimerMechanics.start)
        {
            bulletDuration -= Time.deltaTime;
        }
        if (bulletDuration <= 0)
        {
            end = true;
            bulletDuration = 5;
        }
    }

    void TempMovement()
    {
        Vector3 mousePos = Input.mousePosition;
        transform.position = mousePos;
    }
}
