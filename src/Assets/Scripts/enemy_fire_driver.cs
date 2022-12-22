using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_fire_driver : MonoBehaviour
{
    public Transform[] firePoints;
    public GameObject bulletPrefab;
    public AudioSource fireAudioSource;
    public float bulletForce = 20f;
    public float fireRate = 10f;
    private float shootingTime;
    private GameObject playerObject;
    // Update is called once per frame
    private void Start()
    {
        playerObject = GlobalVariables.PlayerObject;
    }
    void Update()
    {
        float randomFire = Random.Range(0, 60 * fireRate);
        if (randomFire < fireRate)
        {
            for (var i = 0; i < firePoints.Length; i++)
            {
                Fire(firePoints[i]);
            }
        }
    }
    void Fire(Transform firePoint)
    {
        if (playerObject == null)
        {
            playerObject = GlobalVariables.PlayerObject;
        }
        if (Time.time > shootingTime)
        {
            //fireAudioSource.Play();
            shootingTime = Time.time + fireRate;
            Vector2 currentPosition = new Vector2(firePoint.position.x, firePoint.position.y);
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            //Vector2 direction = currentPosition - (Vector2)playerObject.transform.position;
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.forward * bulletForce, ForceMode2D.Impulse);
            //rb.velocity = direction * bulletForce;
        }
    }
}
