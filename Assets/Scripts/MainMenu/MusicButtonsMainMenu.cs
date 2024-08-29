using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicButtonsMainMenu : MonoBehaviour
{

    private AudioSource source;
    public AudioClip clip;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void ClickButton()
    {
        source.PlayOneShot(clip);
    }
}
