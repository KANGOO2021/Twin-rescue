using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantDamage : MonoBehaviour
{

    private float waitedTime;
    public float waitTimeToAttack = 3;
    public Animator animator;
    public GameObject bulletPrefeb;
    public Transform launchSpawnPoint;


    void Start()
    {
        waitedTime = waitTimeToAttack;
    }

    void Update()
    {
        if (waitedTime <= 0) 
        {
            waitedTime = waitTimeToAttack;
            animator.Play("AttackPlant");
            Invoke("LaunchBullet", 0.2f);
        }
        else 
        {
            waitedTime -= Time.deltaTime;
        }
    }

    public void LaunchBullet() 
    {
        GameObject newBullet;

        newBullet = Instantiate(bulletPrefeb, launchSpawnPoint.position, launchSpawnPoint.rotation);
    }

   
}
