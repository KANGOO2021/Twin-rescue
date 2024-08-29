using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private GameObject buttonSettings;
    [SerializeField] private GameObject menuControls;
    [SerializeField] private GameObject menuCollectFruit;



    public void Ok()
    {

        menuControls.SetActive(false);
        menuCollectFruit.SetActive(true);
    }

  

    public void StartGame()
    {
        menuCollectFruit.SetActive(false);
        buttonSettings.SetActive(true);
    }


}
