using System;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class ObjectDetection : MonoBehaviour
{
    private GameObject heldObject;
    bool isHolding = false;
    bool canInteract = true;

    bool isOnCooldown = false;
    float interactCooldown = 0f;
    float interactCooldownDuration = 1f;

    float speed = 2f; // temp

    void Start()
    {

    }

    void Update()
    {
        if (!TimerMechanics.start && TimerMechanics.temp)
        {
            InteractionCooldown();
            ObjectPlacement();
            movementTemp(); // temp

            #region HoldingObject
            if (isHolding)
            {
                heldObject.transform.position = transform.position;
            }

            if (heldObject != null && canInteract && !isHolding)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    SpriteRenderer spriteRenderer = heldObject.GetComponent<SpriteRenderer>();
                    spriteRenderer.enabled = false;

                    ColliderChecker();

                    isHolding = true;
                    isOnCooldown = true;
                }
            }
            #endregion
        }
    }

    public void movementTemp() // temp
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(h, v, 0);
        transform.Translate(movement * speed * Time.deltaTime);
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (!isHolding && collision.tag.Contains("box"))
        {
            heldObject = collision.gameObject;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (!isHolding)
        {
            heldObject = null;
        }
    }

    void ObjectPlacement()
    {
        if (isHolding)
        {
            if (Input.GetKeyDown(KeyCode.E) && canInteract)
            {
                SpriteRenderer spriteRenderer = heldObject.GetComponent<SpriteRenderer>();
                spriteRenderer.enabled = true;

                ColliderChecker();

                isHolding = false;
                heldObject = null;
                isOnCooldown = true;
            }
        }
    }

    void InteractionCooldown()
    {
        if (isOnCooldown)
        {
            canInteract = false;
            interactCooldown += Time.deltaTime;
        }

        if (interactCooldown >= interactCooldownDuration)
        {
            isOnCooldown = false;
            interactCooldown = 0;
            canInteract = true;
        }
    }

    void ColliderChecker()
    {
        if (heldObject.GetComponent<Collider2D>() is BoxCollider2D)
        {
            BoxCollider2D collider = heldObject.GetComponent<BoxCollider2D>();
            collider.enabled = !collider.enabled;
        }

        if (heldObject.GetComponent<Collider2D>() is PolygonCollider2D)
        {
            PolygonCollider2D collider = heldObject.GetComponent<PolygonCollider2D>();
            collider.enabled = !collider.enabled;
        }
    }
}
