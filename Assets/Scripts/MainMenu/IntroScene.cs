using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Cinemachine.DocumentationSortingAttribute;

public class IntroScene : MonoBehaviour
{
    [SerializeField] private GameObject page1ButtonBack;
    [SerializeField] private GameObject page1ButtonNext;
    [SerializeField] private GameObject skipIntro;
    [SerializeField] private GameObject page1;

    [SerializeField] private GameObject page2ButtonBack;
    [SerializeField] private GameObject page2ButtonNext;
    [SerializeField] private GameObject page2;

    [SerializeField] private GameObject page3ButtonBack;
    [SerializeField] private GameObject page3ButtonNext;
    [SerializeField] private GameObject page3;

    [SerializeField] private GameObject page4ButtonBack;
    [SerializeField] private GameObject page4ButtonNext;
    [SerializeField] private GameObject page4;

    [SerializeField] private GameObject page5ButtonBack;
    [SerializeField] private GameObject page5ButtonNext;
    [SerializeField] private GameObject playGame;
    [SerializeField] private GameObject page5;



    public void Page1Next()
    {
        page2.SetActive(true);
    }
    public void Page2Next()
    {
        page3.SetActive(true);
    } 

    public void Page3Next()
    {
        page4.SetActive(true);
    }
    public void Page4Next()
    {
        page5.SetActive(true);
    }

   


    public void Page1NextBack()
    {
        page2.SetActive(false);
    }
    public void Page2NextBack()
    {
        page3.SetActive(false);
    }

    public void Page3NextBack()
    {
        page4.SetActive(false);
    }
    public void Page4NextBack()
    {
        page5.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("1-Nivel");
    }


    public void SkipIntro()
    {
        SceneManager.LoadScene("1-Nivel");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
