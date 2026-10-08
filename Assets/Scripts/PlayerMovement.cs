using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 postion;
    public Rigidbody2D Player;
    [SerializeField] float accel;
    [SerializeField] float friction;
    [SerializeField] float max_velocity;
    Vector2 accel_vector;

    // Update is called once per frame
    void Update()
    {
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
        accel_vector = Time.deltaTime * (Vector2.Normalize(direction) * accel + (Player.linearVelocity * friction));
        Player.linearVelocity += accel_vector;
        Vector2.ClampMagnitude(Player.linearVelocity, max_velocity);
    }
}
