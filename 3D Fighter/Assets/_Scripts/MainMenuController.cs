using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void ButtonHandlerOptions()
    {
        AsyncOperation OptionsButton = SceneManager.LoadSceneAsync("OptionsScreen");
    }

    public void ButtonHandlerSingleStart()
    {
        AsyncOperation tutorialButton = SceneManager.LoadSceneAsync("Tutorial");
    }

    public void ButtonHandlerQuit()
    {
        Application.Quit();
    }
}
