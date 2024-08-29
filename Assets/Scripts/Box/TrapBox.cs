using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBox : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public GameObject brokenParts;
    public float jumpForce = 4f;
    public int lifes = 2;
    public GameObject trap;
    public GameObject boxCollider;
    public Collider2D col2D;
    void Start()
    {
        trap.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.CompareTag("Player"))

        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
            LosseLifeAndHit();
        }

    }

    public void LosseLifeAndHit()
    {
        lifes--;
        CheckLife();
    }

    public void CheckLife()
    {
        if (lifes <= 0)
        {
            boxCollider.SetActive(false);
            col2D.enabled = false;
            trap.SetActive(true);
            brokenParts.SetActive(true);
            spriteRenderer.enabled = false;
            Invoke("DestroyBox", 2f);
        }
    }

    public void DestroyBox()
    {
        Destroy(transform.parent.gameObject); 
    }
}
