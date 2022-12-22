using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calculate_shield : MonoBehaviour
{
    public Text shieldText;

    // Update is called once per frame
    void Update()
    {
        shieldText.text = player_globals.shield.ToString();
    }
}