using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockLvlButton : MonoBehaviour
{
    [SerializeField] private int thisLvlNumber;
    [SerializeField] private GameObject lockImage;
    [SerializeField] private Button lvlButton;

    private void Update()
    {
        if (thisLvlNumber > PlayerPrefs.GetInt("MaxLevelComplite"))
        {
            lockImage.SetActive(true);
            lvlButton.interactable = false;
        }
        else
        {
            lockImage.SetActive(false);
            lvlButton.interactable = true;
        }
    }
}
