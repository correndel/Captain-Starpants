using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_fire_movement : MonoBehaviour
{
    public float fireSpeed = 100f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position * fireSpeed * Time.fixedDeltaTime);
    }
}
