using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;  // Reference to the player's position
    public float moveSpeed;  // Speed at which the slime moves

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerCtrl>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed *Time.deltaTime);
    }
}
