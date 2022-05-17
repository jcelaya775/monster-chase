using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUIController : MonoBehaviour
{
    private string MAINMENU = "MainMenu";
    private string GAMEPLAY = "Gameplay";
   public void RestartGame()
    {
        // SceneManager.LoadScene(GAMEPLAY);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NavigateHome()
    {
        SceneManager.LoadScene(MAINMENU);
    }
}
