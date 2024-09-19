using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //References
    Animator animator;
    PlayerCtrl playerCtrl;
    SpriteRenderer sr;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerCtrl = GetComponent<PlayerCtrl>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCtrl.movementDir.x != 0 || playerCtrl.movementDir.y != 0)
        {
            animator.SetBool("Move", true);

            SpriteDirectionChecker();
        }
        else
        {
            animator.SetBool("Move", false);
        }
    }

    void SpriteDirectionChecker()
    {
        if (playerCtrl.lastHorizontalVector < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;   
        }
    }
}
