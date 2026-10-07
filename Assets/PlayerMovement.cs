using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D Player;
    [SerializeField] float accel;
    [SerializeField] float friction;

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new(0, 0);
        if (Input.GetKey(KeyCode.W ))
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
        Player.AddForce(((Vector2.Normalize(direction) * accel) + (Player.linearVelocity * friction)));
        Vector2.ClampMagnitude(Player.linearVelocity, accel);
    }
}
