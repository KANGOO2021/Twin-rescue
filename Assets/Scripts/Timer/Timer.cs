using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;
    private float timerElapsed;
    private int minutes, seconds, cents;

    /*
    // Update is called once per frame
    void Update()
    {
        timerElapsed += Time.deltaTime;
        minutes = (int)(timerElapsed/60f);
        seconds = (int)(timerElapsed - minutes * 60f);
        cents = (int)((timerElapsed - (int)timerElapsed) * 100f);
        
        timerText.text=string.Format("{0:00}:{1:00}:{2:00}",minutes,seconds,cents);
    }*/
    public static bool isRunning = true;
    
    
    private void Start()
    {
        StartCoroutine(StartTimer());
    }
    // Update is called once per frame
    private IEnumerator StartTimer()
    {
        while (isRunning)
        {
            timerElapsed += Time.deltaTime;
            minutes = (int)(timerElapsed / 60f);
            seconds = (int)(timerElapsed - minutes * 60f);
            cents = (int)((timerElapsed - (int)timerElapsed) * 100f);

            timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);

            yield return null;
        }
    }
}
