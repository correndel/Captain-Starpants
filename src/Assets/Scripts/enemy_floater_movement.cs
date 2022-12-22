using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_floater_movement : MonoBehaviour
{
    private GameObject playerObject;
    public bool isMagnetic = false;
    public float magRange = 5f;
    private Vector3 StartPosition;
    private int timeRate = 60 * 60;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        playerObject = GlobalVariables.PlayerObject;
    }

    // Update is called once per frame
    void Update()
    {
        // get current positions
        Vector3 newPosition = transform.position;
        if (playerObject == null)
        {
            playerObject = GlobalVariables.PlayerObject;
        }
        Vector3 playerPosition = playerObject.transform.localPosition;
        float newRotation;

        // if this is a magnetic enemy, pull toward player when within range
        if (isMagnetic == true && (Vector3.Distance(newPosition, playerPosition) < magRange))
        {
            newPosition.x = Mathf.MoveTowards(newPosition.x, playerPosition.x, Time.deltaTime * 5);
            newPosition.y = Mathf.MoveTowards(newPosition.y, playerPosition.y, Time.deltaTime * 5);
            newRotation = Mathf.MoveTowards(newPosition.z, Mathf.Atan2(playerPosition.y, playerPosition.x) * Mathf.Rad2Deg, Time.deltaTime * 5);
        }
        else
        {
            // rotate slightly
            newRotation = Mathf.MoveTowards(newPosition.z, Random.rotation.z, Time.deltaTime * 5);

            // move side to side slightly
            newPosition.x = Mathf.MoveTowards(transform.position.x, newPosition.x + Random.Range(-10f, 10f), Time.deltaTime / timeRate);
            // correct drift
            if (transform.position.x < -10f || transform.position.x > 10f)
            {
                newPosition.x = Mathf.MoveTowards(transform.position.x, -newPosition.x, Time.deltaTime);
            }
        }
        // execute movement
        transform.Rotate(0, 0, newRotation);
        transform.position = newPosition;

        // if player did not destroy, reset above player
        if (transform.position.y < -17f)
        {
            transform.position = StartPosition;
        }
    }
}
