using UnityEngine;

public class DistanceBasedAudio : MonoBehaviour {
    public Transform playerTransform;
    public AudioSource audioSource;

    public float maxDistance = 10f;
    public float minDistance = 1f;
    public float minVolume = 0.1f;
    public float maxVolume = 1.0f;

    void Update() {
        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);
        float volume = Mathf.Clamp01((maxDistance - distanceToPlayer) / (maxDistance - minDistance));
        audioSource.volume = Mathf.Lerp(minVolume, maxVolume, volume);
    }
}