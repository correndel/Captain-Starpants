using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlay_load : MonoBehaviour
{
    public static string gameState = "play";
    public GameObject gameHUD;
    // Start is called before the first frame update
    void Start()
    {
        switch (gameState)
        {
            case "play":
                Instantiate(gameHUD);
                break;
            case "pause":
                //load pause menu
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
