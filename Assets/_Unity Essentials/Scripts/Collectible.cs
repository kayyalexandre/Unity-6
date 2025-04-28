using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationalSpeed = 50f;           // Speed of collectible rotation
    public GameObject onCollectEffect;            // Particle effect prefab to play on collection

    void Update()
    {
        // Rotate the collectible object
        transform.Rotate(0, rotationalSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
{
    Debug.Log("Triggered with: " + other.name);

    if (other.CompareTag("Player"))
    {
        Debug.Log("Collected by Player!");
        Destroy(gameObject);
    }
}

}
