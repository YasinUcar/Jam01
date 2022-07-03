using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseCanvas;
    public static bool isPaused;
    void Start()
    {
        pauseCanvas.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void PauseGame()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        isPaused=true;
    }
    public void ResumeGame()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        isPaused=false;

    }
    public void VoiceMute()
    {

    }
}
