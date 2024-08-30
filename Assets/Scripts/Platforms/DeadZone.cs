using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    [SerializeField] private GameObject deathMenu;
    
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            deathMenu.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}