using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            SceneManager.LoadScene(PlayerPrefs.GetInt("MaxLevelComplite"));
        }
    }
}