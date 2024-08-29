using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeBullet : MonoBehaviour
{

    public float speed = 2;
    public float lifeTime = 2;

   
    void Start()
    { 
        Destroy(gameObject,lifeTime);
    }


    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);  
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        Destroy(gameObject);
    }
}
