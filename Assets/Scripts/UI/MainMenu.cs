using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        if (!PlayerPrefs.HasKey("MaxLevelComplite"))
        {
            PlayerPrefs.SetInt("MaxLevelComplite",1);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("MaxLevelComplite"));
    }

    public void ExitGame()
    {
        Debug.Log("Игра закрылась");
        Application.Quit();
    }
}
