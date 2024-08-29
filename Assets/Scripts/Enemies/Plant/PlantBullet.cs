using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBullet : MonoBehaviour
{

    public float speed = 2;
    public float lifeTime = 2;
    public bool right;

 
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        if (right)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else 
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
            Destroy(gameObject);
        }

    }

}
