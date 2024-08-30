using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractionWithObjects : MonoBehaviour
{
    [SerializeField] private float checkDistance=0.5f;
    [SerializeField] private LayerMask WinMask;
    [SerializeField] private LayerMask EndMask;
    [SerializeField] private Transform orientation;
    [SerializeField] private GameObject winGameMenu;
    [SerializeField] private GameObject endGameMenu;
    [SerializeField] private GameObject pauseGameMenu;
    [SerializeField] private GameObject optionsGameMenu;

    private bool gameWin = false;
    private bool endWin = false;
    
    private void FixedUpdate()
    {
        gameWin = Physics.CheckSphere(orientation.position, checkDistance, WinMask);
        endWin = Physics.CheckSphere(orientation.position, checkDistance, EndMask);
        if (gameWin)
        {
            Debug.Log("Win");
            winGameMenu.SetActive(true);
            pauseGameMenu.GetComponent<PauseMenu>().GameWin();
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            if (SceneManager.GetActiveScene().buildIndex == PlayerPrefs.GetInt("MaxLevelComplite"))
            {
                PlayerPrefs.SetInt("MaxLevelComplite",PlayerPrefs.GetInt("MaxLevelComplite") + 1);
            }
        }else if (endWin)
        {
            Debug.Log("end game");
            if (endGameMenu != null)
            {
                Debug.Log("end game");
                endGameMenu.SetActive(true);
                pauseGameMenu.GetComponent<PauseMenu>().GameWin();
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
    
    

}
