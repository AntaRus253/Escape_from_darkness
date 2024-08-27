using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private bool pauseGame;
    public bool winGame;
    [SerializeField] private GameObject pauseGameMenu;

    private void Update()
    {
        if (!winGame)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (pauseGame)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("MaxLevelComplite"));
    }

    public void GameWin()
    {
        winGame = true;
    }

    public void OpenOptions()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        pauseGame = true; 
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        pauseGame = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        pauseGame = true; 
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
