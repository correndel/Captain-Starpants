using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int numberToSpawn = 100; //total number for level
    public int limit = 20; //number on screen at one time
    public float rate = 1; //number of seconds between spawns 
    public int cluster = 3; //number of enemies per spawn

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, rate);
    }

    void SpawnEnemy()
    {
        // Randomly pick a point within the spawn object
        Vector2 spawnPoint = new Vector2(Random.Range(-10f, 10f), 17f);
        cluster = Random.Range(1, cluster);
        for (int i = 0; i < cluster; i++)
        {
            // Create an enemy at the 'spawnPoint' position, adjust by cluster number
            spawnPoint.y += i;
            GameObject newEnemy = Instantiate(objectToSpawn, spawnPoint, Quaternion.identity);
            // Change size
            float range = Random.Range(0.2f, 0.4f);
            Vector3 scale = new Vector3(range, range, 1f);
            newEnemy.transform.localScale = scale;
        }
    }

}