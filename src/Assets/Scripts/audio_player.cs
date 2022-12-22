using System;
using UnityEngine;

public class audio_player : MonoBehaviour
{
    public AudioClip[] songs;
    public AudioSource source;
    private void Start()
    {
        source.clip = songs[UnityEngine.Random.Range(0, songs.Length)];
    }

    private void Update()
    {
        if (source.isPlaying == false)
        {
            source.clip = GetNextSong();
            source.Play();
        }
    }

    private AudioClip GetNextSong()
    {
        //int clipIndex = 0;
        //if (source.clip != null)
        //{
        //    clipIndex = Array.IndexOf(songs, source.clip) + 1;
        //    if (clipIndex > songs.Length) { clipIndex = 0; }
        //}
        //return songs[clipIndex];
        return songs[UnityEngine.Random.Range(0, songs.Length)];
    }
}