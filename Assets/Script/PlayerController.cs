using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    float speedX, speedY = 0;
    Rigidbody2D rb;
    public bool BlockMovement;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(!BlockMovement)
        {
            speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
            speedY = Input.GetAxisRaw("Vertical") * moveSpeed;

            rb.velocity = new Vector2(speedX, speedY);
        }

    }

    public void blockControls()
    {
        BlockMovement = !BlockMovement;
        rb.velocity = Vector2.zero;
    }
}
