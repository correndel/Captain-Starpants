using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class jungle_boss_eye_movement : MonoBehaviour
{
    private GameObject playerObject;
    private Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        playerObject = GlobalVariables.PlayerObject;
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObject == null)
        {
            playerObject = GlobalVariables.PlayerObject;
        }
        transform.up = -(playerObject.transform.position - transform.position);
    }
}
