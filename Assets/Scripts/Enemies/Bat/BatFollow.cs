using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatFollow : MonoBehaviour
{
    Vector2 Enemypos;
    public GameObject playerM;
    bool perseguirP;
    public float vel;
    public Animator animator;
    private Vector2 actualPos;
    public SpriteRenderer spriteRenderer;


    void Update()
    {

        StartCoroutine(CheckEnemyMoving());

        if (perseguirP)
        {
            transform.position = Vector2.MoveTowards(transform.position, Enemypos, vel * Time.deltaTime);
        }

        if (Vector2.Distance(transform.position, Enemypos) < 2f)
        {
            perseguirP = false;

        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Enemypos = playerM.transform.position;
            perseguirP = true;
            animator.SetBool("fly", true);

        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("fly", false);
        }
    }


    IEnumerator CheckEnemyMoving()
    {
        actualPos = transform.position;

        yield return new WaitForSeconds(0.5f);

        if (transform.position.x > actualPos.x)

        {
            spriteRenderer.flipX = true;
            animator.SetBool("idle", false);
        }
        else if (transform.position.x < actualPos.x)

        {
            spriteRenderer.flipX = false;
            animator.SetBool("idle", false);
        }
        else if (transform.position.x == actualPos.x)

        {
            animator.SetBool("idle", true);
        }

    }
}
