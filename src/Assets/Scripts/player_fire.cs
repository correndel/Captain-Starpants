using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player_fire : MonoBehaviour
{
    public Transform firePoint_left;
    public Transform firePoint_right;
    public GameObject bulletPrefab;
    public AudioSource fireAudioSource;
    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Gamepad.current.aButton.wasPressedThisFrame == true)
        {
            Fire(firePoint_left);
            Fire(firePoint_right);
        }
    }
    void Fire(Transform firePoint)
    {
        fireAudioSource.enabled = true;
        //fireAudioSource.Play();
        GameObject bullet = Instantiate(bulletPrefab, firePoint);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
