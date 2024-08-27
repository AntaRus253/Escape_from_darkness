using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject objectToSpawn;

    private void Start() {
        if (spawnPoint != null && objectToSpawn != null) {
            Instantiate(objectToSpawn, spawnPoint.transform.position, spawnPoint.transform.rotation);
        }
    }
}
    