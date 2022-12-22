using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player_movement : MonoBehaviour
{
    public float movementSpeed = 15f;   //Movement Speed of the Player
    public int rotationSpeed = 15;
    public float shipBoundary = .025f;
    private Vector2 leftMovement;
    private Vector2 rightMovement;
    private Quaternion rotation;


    private Quaternion originalRotation;
    private Rigidbody2D rb;
    private Gamepad gamepad;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        originalRotation = rb.transform.rotation;
        gamepad = Gamepad.current;
    }

    // Update is called once per frame
    void Update()
    {
        // get the current controller movement
        leftMovement = gamepad.leftStick.ReadValue();
        rightMovement = gamepad.rightStick.ReadValue();
    }

    void FixedUpdate()
    {
        // prevent ship from leaving boundary
        if (rb.transform.localPosition.y + shipBoundary > Camera.main.orthographicSize)
        {
            leftMovement.y -= shipBoundary;
        }
        if (rb.transform.localPosition.x + shipBoundary > Camera.main.orthographicSize)
        {
            leftMovement.x -= shipBoundary;
        }
        // move the player based on controller movement
        rb.MovePosition(rb.position + leftMovement * movementSpeed * Time.fixedDeltaTime);

        // change rotation based on controller movement
        rb.MoveRotation(Mathf.MoveTowards(rb.rotation, Mathf.Atan2(rightMovement.y, rightMovement.x) * Mathf.Rad2Deg, Time.deltaTime * 5));

        //correct the player rotation
        rb.MoveRotation(Quaternion.RotateTowards(rb.transform.localRotation, originalRotation, 30f * Time.deltaTime));
    }
}
