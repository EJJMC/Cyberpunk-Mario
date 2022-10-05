using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Button startGame;
    public Button playerControls;
    public Button quitGame;
    public Button returnToMainMenu;

    public void Gamelevel()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ControlsMenu()
    {
        SceneManager.LoadScene("Controls");
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitTheGame()
    {

        #if UNITY_STANDALONE
        Application.Quit();
        #endif

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }


    
   
   
}
