using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicBrightness : MonoBehaviour
{
    public Slider slider;

    public float sliderValue;

    public Image brightness;


    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("brightness");
        brightness.color = new Color(brightness.color.r, brightness.color.g, brightness.color.b, slider.value);
    }


    public void ChangeSlider(float value1)
    {
        sliderValue = value1;
        PlayerPrefs.SetFloat("brightness", sliderValue);
        brightness.color = new Color(brightness.color.r, brightness.color.g, brightness.color.b, slider.value);
    }

}
