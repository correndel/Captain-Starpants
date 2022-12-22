using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_repair_movement : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -17f)
        {
            Destroy(gameObject);
        }
    }
}
