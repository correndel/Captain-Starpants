using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayer : MonoBehaviour
{
    public GameObject[] playerShip;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = Instantiate(playerShip[0]);
        GlobalVariables.PlayerObject = player;
    }
}
