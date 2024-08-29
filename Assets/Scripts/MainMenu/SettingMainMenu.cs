using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class SettingMainMenu : MonoBehaviour
{

    [SerializeField] private GameObject menuSettings;
    [SerializeField] private GameObject menuLanguages;
    [SerializeField] private GameObject menuPlay;
    public Slider sliderVol;
    private float sliderValueVol;


    void Start()
    {
        sliderVol.value = PlayerPrefs.GetFloat("volumeAudio");
        AudioListener.volume = sliderVol.value;
    }


    public void ChangeSlider(float value1)
    {
        sliderValueVol = value1;
        PlayerPrefs.SetFloat("volumeAudio", sliderValueVol);
        AudioListener.volume = sliderVol.value;
    }

    public void SettingOn()
    {
        menuSettings.SetActive(true);
       
    }
    public void SettingOff()
    {
        menuSettings.SetActive(false);

    }

    public void LanguageOn()
    {
        menuLanguages.SetActive(true);

    }
    public void LanguageOff()
    {
        menuLanguages.SetActive(false);

    }

    public void MenuPlayOn()
    {
        menuPlay.SetActive(true);

    }
    public void MenuPlayOff()
    {
        menuPlay.SetActive(false);

    }



}
