﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void ButtonHandlerMainMenu()
    {
        AsyncOperation MenuButton = SceneManager.LoadSceneAsync("TitleScreen");
    }
}