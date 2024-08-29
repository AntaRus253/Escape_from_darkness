using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour {
    public int sceneToLoad = 1;

    void Start() {

    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {


            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
