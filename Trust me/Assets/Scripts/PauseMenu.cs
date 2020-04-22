using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject firstPersonCam;

    void Start()
    {
        ResumeGame();
    }

    // Update is called once per frame
    void Update()
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
    }//end of Update

    public void ResumeGame()
    {
        // Resume time and hide the pause menu UI
        pauseMenuUI.SetActive(false);
        firstPersonCam.GetComponent<MouseLook>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        isPaused = false;
    }

    void PauseGame()
    {
        // Freeze time and bring up pause menu UI
        pauseMenuUI.SetActive(true);
        firstPersonCam.GetComponent<MouseLook>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Quit()
    {
        SceneManager.LoadScene("Credits");
        //Application.Quit();
    }
}
