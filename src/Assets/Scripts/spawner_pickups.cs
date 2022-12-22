using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner_pickups : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int numberToSpawn;
    public int limit = 20;
    public float rate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPickups", 0, rate);
    }

    void SpawnPickups()
    {
        // Randomly pick a point within the spawn object
        Vector2 spawnPoint = new Vector2(Random.Range(-10f, 10f), 17f);
        // Create at the 'spawnPoint' position
        GameObject newPickup = Instantiate(objectToSpawn, spawnPoint, Quaternion.identity);
    }
}
