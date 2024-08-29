using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;
using UnityEngine.SceneManagement;

public class LoadSave : MonoBehaviour
{
    //private int level;
    // Start is called before the first frame update
    void Start()
    {
       // level = SceneManager.GetActiveScene().buildIndex;
    }

    public void SaveGame()
    {
        //PlayerPrefs.SetInt("Level", level);
        ProfileStorage.StorePlayerProfile();
    }


    public void LoadGame()
    {
       
        //level = PlayerPrefs.GetInt("Level");
        //SceneManager.LoadScene(level);
    }


}
