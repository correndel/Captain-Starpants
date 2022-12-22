using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audio_showtitle : MonoBehaviour
{
    public AudioSource source;
    public Text currentText;

    private void Start()
    {
        //source = FindObjectOfType<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        currentText.text = ShowSongName(source.clip.ToString());
    }

    private string ShowSongName(string fileName)
    {
        const string fileType = " (UnityEngine.AudioClip)";
        //Debug.Log("filename == " + fileName);
        string songName = "loading music player...";
        switch (fileName)
        {
            case "Star_Trance_" + fileType:
                songName = "♫ Star Trance - by Michele";
                break;
            case "Chip" + fileType:
                songName = "♫ Chip - by Gage";
                break;
            case "Flower_Boss" + fileType:
                songName = "♫ Flower Boss - by Michele";
                break;
            case "Ominous_Room" + fileType:
                songName = "♫ Ominous Room - by Michele";
                break;
            case "Robot_Destruction_Suite" + fileType:
                songName = "♫ Robot Destruction Suite - by Brad";
                break;
            case "Blood_Sweat_and_Gears" + fileType:
                songName = "♫ Blood Sweat and Gears - by Michele";
                break;
            case "Its_Over" + fileType:
                songName = "♫ It's Over - by Michele";
                break;
            case "Stealth_Gone_Wrong" + fileType:
                songName = "♫ Stealth Gone Wrong - by Michele";
                break;
            case "Verglas_Cavern" + fileType:
                songName = "♫ Verglas Cavern - by Michele";
                break;
            default:
                songName = "♫ Loading next song...";
                break;
        }
        return songName;
    }
}
