using UnityEngine;
using System.Collections;

public class DestructiblePlatform : MonoBehaviour {
    public float destructionDelay = 2.1f;
    public float additionalDelayAfterSound = 5f;
    private bool isPlayerInContact = false;

    public AudioClip destructionSound;
    private AudioSource audioSource;

    private MeshRenderer meshRenderer;
    private Collider platformCollider;

    void Start() {
        audioSource = GetComponent<AudioSource>();
        meshRenderer = GetComponent<MeshRenderer>();
        platformCollider = GetComponent<Collider>();
    }

    public void StartDestruction() {
        if (!isPlayerInContact) {
            isPlayerInContact = true;
            StartCoroutine(DestroyPlatform());
        }
    }

    private IEnumerator DestroyPlatform() {
        yield return new WaitForSeconds(destructionDelay);
        PlayDestructionSound();
        HidePlatform();
        yield return new WaitForSeconds(additionalDelayAfterSound);
        Destroy(gameObject);
    }

    private void PlayDestructionSound() {
        if (destructionSound != null && audioSource != null) {
            audioSource.PlayOneShot(destructionSound);
        }
    }

    private void HidePlatform() {
        if (meshRenderer != null) {
            meshRenderer.enabled = false;
        }
        if (platformCollider != null) {
            platformCollider.enabled = false;
        }
    }
}
