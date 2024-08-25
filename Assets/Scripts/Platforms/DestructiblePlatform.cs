using UnityEngine;
using System.Collections;

public class DestructiblePlatform : MonoBehaviour {
    public float destructionDelay = 2.1f;
    private bool isPlayerInContact = false;

    public void StartDestruction() {
        if (!isPlayerInContact) {
            isPlayerInContact = true;
            StartCoroutine(Destroy());
        }
    }

    private IEnumerator Destroy() {
        yield return new WaitForSeconds(destructionDelay);
        Destroy(gameObject);
    }
}
