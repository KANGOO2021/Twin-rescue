using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEditor;
using TMPro;


public class PlayerRespawn : MonoBehaviour
{
    public Animator animator;

    public GameObject[] hearts;
    private int life;
    public AudioSource clip;
    public AudioSource death;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject player;
    public Player script;
    //public Timer script;

    void Start()
    {
        life= hearts.Length;  
    }

    public void CheckLife()
    {
        if (life < 1)
        {
           
            Destroy(hearts[0].gameObject);
            animator.Play("Death");
            death.Play();
            script.enabled = false;
            Timer.isRunning = false;
            Invoke("GameOver", 1);
            

        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
            animator.Play("Hit");
            clip.Play();
            
        }
        else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
            animator.Play("Hit");
            clip.Play();
            

        }

    }

    public void PlayerDied()
    {
        Destroy(hearts[0].gameObject);
        Destroy(hearts[1].gameObject);
        Destroy(hearts[2].gameObject);
        life =0;
        CheckLife();

    }
    public void PlayerDamaged()
    {
        life--;
        CheckLife();

    }

    void GameOver()
    {
        player.SetActive(false);
        gameOver.SetActive(true);
        

    }

}
