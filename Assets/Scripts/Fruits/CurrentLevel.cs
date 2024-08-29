using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurrentLevel : MonoBehaviour
{
    public int number;
 

    void Update()
    {

        number = SceneManager.GetActiveScene().buildIndex - 1;
        

    }
}
