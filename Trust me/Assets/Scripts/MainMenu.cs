using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public void LoadDream1()
    {
        SceneManager.LoadScene("Dream1");
    }

    public void LoadStory()
    {
        SceneManager.LoadScene("Story");
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
