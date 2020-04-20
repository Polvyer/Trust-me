using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public Color loadToColor = Color.white;
    public float fadeSpeed;

    public void LoadDream1()
    {
        Initiate.Fade("Dream1", loadToColor, fadeSpeed);
        //SceneManager.LoadScene("Dream1");
    }

    public void LoadStory()
    {
        Initiate.Fade("Story", loadToColor, fadeSpeed);
        //SceneManager.LoadScene("Story");
    }

    public void LoadCredits()
    {
        Initiate.Fade("Credits", loadToColor, fadeSpeed);
        //SceneManager.LoadScene("Credits");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
