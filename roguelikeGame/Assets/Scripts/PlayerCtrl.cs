using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public float movSpeed;
    float posX, posY;
    Rigidbody2D rb;
    [HideInInspector]
    public float lastHorizontalVector;
    [HideInInspector]
    public float lastVerticalVector;
    [HideInInspector]
    public Vector2 movementDir;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        posX = Input.GetAxisRaw("Horizontal");
        posY = Input.GetAxisRaw("Vertical");
        movementDir = new Vector2(posX, posY).normalized;

        if (movementDir.x != 0)
        {
            lastHorizontalVector = movementDir.x;
        }

        if (movementDir.y != 0)
        {
            lastVerticalVector = movementDir.y;
        }
    }

    void FixedUpdate()
    {
        rb.velocity = movementDir * movSpeed;
    }
}
