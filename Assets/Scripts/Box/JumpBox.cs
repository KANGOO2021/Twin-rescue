using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBox : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public GameObject brokenParts;
    public float jumpForce = 4f;
    public int lifes = 1;
    public GameObject boxCollider;

    public Collider2D col2D;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.transform.CompareTag("Player")) 
        
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
        if(lifes<=0) 
        {
            boxCollider.SetActive(false);
            col2D.enabled = false;
            //fruit.SetActive(true);
            brokenParts.SetActive(true);
            spriteRenderer.enabled = false;
            Invoke("DestroyBox", 0.5f);
        }
    }

    public void DestroyBox()
    { 
        Destroy(transform.parent.gameObject);
    }


}
