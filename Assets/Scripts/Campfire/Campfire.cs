using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Campfire : MonoBehaviour
{

    public GameObject flashLight;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            flashLight.SetActive(true);
        }

    }
}
