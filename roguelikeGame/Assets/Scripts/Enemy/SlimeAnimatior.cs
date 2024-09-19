using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeAnimation : MonoBehaviour
{
    EnemyMovement enemyMov;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        enemyMov = GetComponent<EnemyMovement>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        SpriteDirectionChecker();
    }

    void SpriteDirectionChecker()
    {
        if (enemyMov.player.transform.position.x < transform.position.x)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }
}
