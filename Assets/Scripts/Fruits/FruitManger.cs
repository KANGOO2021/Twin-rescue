using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class FruitManger : MonoBehaviour
{


    public TMP_Text levelCleared;
    public TMP_Text totalFruits;
    public TMP_Text collectedFruits;
    public int totalFruitsInLevel;
    public GameObject audioSource;
    public GameObject audioSourceJumpPlayer;
    public TMP_Text level;
    

    void Start()
    {
        totalFruitsInLevel = transform.childCount;
        int ID = PlayerPrefs.GetInt("LocaleKey", 0);
     
        if (ID == 0) 
        {
            level.text = $"Level {SceneManager.GetActiveScene().buildIndex - 3}";
        }
       else if (ID == 1)
        {
            level.text = $"Nivel {SceneManager.GetActiveScene().buildIndex - 3}";
        }
        else if (ID == 2)
        {
            level.text = $"Niveau {SceneManager.GetActiveScene().buildIndex - 3}";
        }
        else if (ID == 3)
        {
            level.text = $"{SceneManager.GetActiveScene().buildIndex - 3}级";
        }
        else if (ID == 4)
        {
            level.text = $"Nível {SceneManager.GetActiveScene().buildIndex - 3}";
        }
        else if (ID == 5)
        {
            level.text = $"レベル {SceneManager.GetActiveScene().buildIndex - 3}";
        }
        else if (ID == 6)
        {
            level.text = $"레벨 {SceneManager.GetActiveScene().buildIndex - 3}";
        }
        else if (ID == 7)
        {
            level.text = $"स्तर {SceneManager.GetActiveScene().buildIndex - 3}";
        }
    }


    void Update()
    {
        AllFruitCollectec();
        totalFruits.text = totalFruitsInLevel.ToString();
        collectedFruits.text = transform.childCount.ToString();
    }

    public void AllFruitCollectec()
    {
        
        if (transform.childCount == 0)
        {
            int ID = PlayerPrefs.GetInt("LocaleKey", 0);
            if (ID == 0)
            {
                levelCleared.text = $"Level {SceneManager.GetActiveScene().buildIndex - 3} Complete";
            }
            else if (ID == 1)
            {
                levelCleared.text = $"Nivel {SceneManager.GetActiveScene().buildIndex - 3} Completo";
            }
            else if (ID == 2)
            {
                levelCleared.text = $"Niveau {SceneManager.GetActiveScene().buildIndex - 3} Terminé";
            }
            else if (ID == 3)
            {
                levelCleared.text = $"{SceneManager.GetActiveScene().buildIndex - 3}级完成";
            }
            else if (ID == 4)
            {
                levelCleared.text = $"Nível {SceneManager.GetActiveScene().buildIndex - 3} Concluído";
            }
            else if (ID == 5)
            {
                levelCleared.text = $"レベル {SceneManager.GetActiveScene().buildIndex - 3} を終えた";
            }
            else if (ID == 6)
            {
                levelCleared.text = $"레벨 {SceneManager.GetActiveScene().buildIndex - 3} 완료";
            }
            else if (ID == 7)
            {
                levelCleared.text = $"समाप्त स्तर {SceneManager.GetActiveScene().buildIndex - 3}";
            }
            levelCleared.gameObject.SetActive(true);
            audioSource.SetActive(false);
            Time.timeScale = 0f;
            audioSourceJumpPlayer.GetComponent<Player>().enabled = false;
            StartCoroutine(ChangeScene());
        }
    }
 

    private IEnumerator ChangeScene()
    {
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }


}
