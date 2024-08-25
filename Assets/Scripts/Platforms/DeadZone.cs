using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {
    public Transform respawnPoint;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            other.transform.position = respawnPoint.position;
            // тут надо добавить логику остановки, со спавна игрок не оказался например в полёте
        }
    }
}