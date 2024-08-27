using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerParent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Controller>(out Controller player))
        {
            player.transform.parent = transform;
            Debug.Log("1");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<Controller>(out Controller player))
        {
            player.transform.parent = null;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
    }
}
