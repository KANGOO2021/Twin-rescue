using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIManager : MonoBehaviour
{


    public void OnStartLevelButtonClicked() {
        SceneManager.LoadScene(1);
        
    }
    public void OnQuitLevelButtonClicked()
    {
        SceneManager.LoadScene(0);
    }

    public void OnExitButtonClicked() {
        Application.Quit();
        
    }

   

}
