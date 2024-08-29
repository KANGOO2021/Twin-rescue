using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Cinemachine.CinemachineFreeLook;
using static Cinemachine.DocumentationSortingAttribute;

public class Settings : MonoBehaviour
{
    [SerializeField] private GameObject buttonSettings;
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject menuSettings;
  
    
   
    public void Pause()
    {
        Time.timeScale = 0f;
        buttonSettings.SetActive(false);
        menu.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        buttonSettings.SetActive(true);
        menu.SetActive(false);
    }

    public void Restart()
    {
        Timer.isRunning = true;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Setting()
    {
        menuSettings.SetActive(true);
        menu.SetActive(false);
    }


    public void Exit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }


}
