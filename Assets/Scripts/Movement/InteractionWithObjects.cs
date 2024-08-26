using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractionWithObjects : MonoBehaviour
{
    [SerializeField] private float checkDistance=0.5f;
    [SerializeField] private LayerMask WinMask;
    [SerializeField] private Transform orientation;

    private bool gameWin = false;
    
    private void FixedUpdate()
    {
        gameWin = Physics.CheckSphere(orientation.position, checkDistance, WinMask);
        if (gameWin)
        {
            Debug.Log("Win");
        }
    }
    
    

}
