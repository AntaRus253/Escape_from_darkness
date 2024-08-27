using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    private int maxLevel;

    private void Start()
    {
        maxLevel = PlayerPrefs.GetInt("MaxLevelComplite");
    }

    public void ResetLvl()
    {
        maxLevel = 1;
        PlayerPrefs.SetInt("MaxLevelComplite",maxLevel);
    }

    public void OpenLvl(int levelIndex)
    {
        if (levelIndex <= PlayerPrefs.GetInt("MaxLevelComplite"))
        {
            SceneManager.LoadScene(levelIndex);
        }
    }
    
}
