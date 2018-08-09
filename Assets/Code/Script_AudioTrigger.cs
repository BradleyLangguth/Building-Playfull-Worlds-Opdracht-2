using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Script_AudioTrigger : MonoBehaviour 
{
    public AudioClip yourAudioClip;
    
    public float Afstand;
    public GameObject Obstakel;
    public GameObject Player;
    
 void Update()
 {
    Afstand = Vector3.Distance(Obstakel.transform.position,Player.transform.position);
    
    if(Afstand < 3)
    {
            Debug.Log(Afstand);
            GetComponent<AudioSource> ().clip = yourAudioClip;
            GetComponent<AudioSource> ().Play ();
    }
 
 }

}
