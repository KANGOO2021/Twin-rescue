using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicVolume : MonoBehaviour

{

    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject menuSettings;
    [SerializeField] private GameObject buttonSettings;
    public Slider slider;
    private float sliderValue;

       
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumeAudio");
        AudioListener.volume = slider.value;
    }

   
   public void ChangeSlider (float value1)
    { 
        sliderValue = value1; 
        PlayerPrefs.SetFloat("volumeAudio",sliderValue);
        AudioListener.volume = slider.value;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        menuSettings.SetActive(false);
        menu.SetActive(false);
        buttonSettings.SetActive(true);
    }


    public void Exit()
    {
        menuSettings.SetActive(false);
        menu.SetActive(true);
    }
}
