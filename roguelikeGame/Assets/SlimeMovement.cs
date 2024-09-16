using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
    public Transform player;  // Reference to the player's position
    public float moveSpeed = 2f;  // Speed at which the slime moves

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Calculate the direction to the player
        Vector2 direction = player.position - transform.position;
        direction.Normalize();  // Normalize to get only the direction, not the magnitude

        // Store the movement direction
        movement = new Vector2(direction.x, direction.y);
    }

    void FixedUpdate()
    {
        // Move the slime towards the player using Rigidbody2D
        rb.MovePosition((Vector2)transform.position + (movement * moveSpeed * Time.fixedDeltaTime));
    }
}