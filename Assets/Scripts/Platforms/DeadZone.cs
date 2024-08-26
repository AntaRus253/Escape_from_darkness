using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour {
    public int sceneToLoad = 1;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}