using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D Player;
    [SerializeField] float accel;
    [SerializeField] float friction;

    // Update is called once per frame
    void Update()
    {
        if (!TimerMechanics.start && TimerMechanics.temp) { 
            Vector2 direction = new(0, 0);
            if (Input.GetKey(KeyCode.W))
            {
                direction.y += 1.0f;
            }
            if (Input.GetKey(KeyCode.S))
            {
                direction.y -= 1.0f;
            }
            if (Input.GetKey(KeyCode.A))
            {
                direction.x -= 1.0f;
            }
            if (Input.GetKey(KeyCode.D))
            {
                direction.x += 1.0f;
            }
            Player.AddForce(Vector2.Normalize(direction) * accel + (0.65f * Player.linearVelocity * friction));
        }
        else
        {
            Player.linearVelocity = Vector2.zero;
        }
    }
}
