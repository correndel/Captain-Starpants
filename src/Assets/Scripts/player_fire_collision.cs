using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_fire_collision : MonoBehaviour
{
    public GameObject hitEffect;
    //Handle any collision triggers here
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.localPosition, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);
    }
}
