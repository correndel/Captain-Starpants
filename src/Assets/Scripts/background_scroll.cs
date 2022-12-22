using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_scroll : MonoBehaviour
{
    // Variables
    private Vector3 StartPosition;
    public float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -17f)
        {
            transform.position = StartPosition;
        }
    }
}
