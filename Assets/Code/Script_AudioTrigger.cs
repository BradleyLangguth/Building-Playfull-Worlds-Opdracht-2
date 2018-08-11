using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Script_AudioTrigger : MonoBehaviour 
{
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool alreadyPlayed = false;
    
    
    void Start () 
    {
        audio = GetComponent<AudioSource>();
    }
    
    void OnTriggerEnter()
    {
        audio.PlayOneShot(SoundToPlay, Volume);
        //if (!alreadyPlayed)
        //{
        //    audio.PlayOneShot(SoundToPlay, Volume);
        //    alreadyPlayed = true;
        //}
 
    }  

}
