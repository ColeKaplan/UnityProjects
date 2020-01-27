﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Challenge1");
    }

    public void credits()
    {
        SceneManager.LoadSceneAsync("credits");
    }

    public void howToPlay() 
    {
        SceneManager.LoadSceneAsync("poem1");
    }
    public void backToMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }
    public void next()
    {
        SceneManager.LoadSceneAsync("howToPlay");
    }
}
