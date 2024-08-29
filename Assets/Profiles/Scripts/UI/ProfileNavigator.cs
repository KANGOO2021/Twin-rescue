using UnityEngine;
using UnityEngine.SceneManagement;

public class ProfileNavigator : MonoBehaviour
{
    public void GoToNewGame()
    {
        SceneManager.LoadScene("P_NewGame");
    }

    public void GoToLoadMenu()
    {
        SceneManager.LoadScene("P_Menu");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("0-Main Menu");
    }
}
