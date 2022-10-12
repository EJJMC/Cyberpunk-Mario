using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public static bool gameIsPaused;
    public GameObject playButton;
    public GameObject pauseButton;

    // Start is called before the first frame update
    void Start()
    {
        playButton.SetActive(false);
        pauseButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseTheGame();

        }
    }

   public void GamePaused()
    {      
            Time.timeScale = 0f;
            playButton.SetActive(true);
            pauseButton.SetActive(false);   
       
    }
   public void PlayGame()
    {
        Time.timeScale = 1f;
        playButton.SetActive(false);
        pauseButton.SetActive(true);
    }

    void PauseTheGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            playButton.SetActive(true);
            pauseButton.SetActive(false);

        }
        else
        {
            Time.timeScale = 1f;
            playButton.SetActive(false);
            pauseButton.SetActive(true);
        }
    }
}
