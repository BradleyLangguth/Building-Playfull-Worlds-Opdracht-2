using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Script_Timer : MonoBehaviour 
{
    public Text timerText;
    public Text InScene_timerText;
    
    public GameObject Room05_Muur;
    public GameObject Room05_Text;
    
    public GameObject Room1_Lights;
    public GameObject Room1_Path;
    
    
    
    public GameObject ValObject;
    
    public GameObject Room1_Rain;
    public GameObject Room2_Obstacles;
    
    private float startTime;
    private float elapsedTime;
    
    public Vector3 center;
    public Vector3 size;
    
    public Vector3 center2;
    public Vector3 size2;
    
    
    
    
    public AudioMixer mixer;
	private AudioMixerSnapshot NormalSnapshot;
	private AudioMixerSnapshot BigRoomsSnapshot;

	void Start () 
    {
        startTime = Time.timeSinceLevelLoad;
        
        NormalSnapshot = mixer.FindSnapshot("Normal");
		BigRoomsSnapshot = mixer.FindSnapshot("Big Rooms");
	}
    

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(center, size);
        
        Gizmos.DrawCube(center2, size2);
    }
    
    public void Room1_SpawnRain()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2 , size.x / 2), Random.Range(-size.y / 2 , size.y / 2), Random.Range(-size.z / 2 , size.z / 2));
        
        Instantiate(Room1_Rain, pos, Random.rotation);      
    }
    
    public void Room2_SpawnObstacles()
    {
        Vector3 pos2 = center2 + new Vector3(Random.Range(-size2.x / 2 , size2.x / 2), Random.Range(-size2.y / 2 , size2.y / 2), Random.Range(-size2.z / 2 , size2.z / 2));
        
        Instantiate(Room2_Obstacles, pos2, Quaternion.identity);    
    }
    
    
    
    
	void Update () 
    {
    
        elapsedTime = Time.timeSinceLevelLoad - startTime;

        float t = Time.timeSinceLevelLoad - startTime;
        
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        
        timerText.text = minutes + ":" + seconds;
        InScene_timerText.text = minutes + ":" + seconds;
        
        //Debug.Log(Time.timeSinceLevelLoad);
            
        if (Time.timeSinceLevelLoad > 4.8 & Time.timeSinceLevelLoad < 20)
        
        {
           Room05_Muur.SetActive(false);
           Room05_Text.SetActive(true);
        }
        
        else
        
        {
            Room05_Text.SetActive(false);
        }
                
        if (Time.timeSinceLevelLoad > 73 & Time.timeSinceLevelLoad < 110)
        
        {      
            Room1_SpawnRain();
            Room1_Lights.SetActive(false);
            Room1_Path.SetActive(true);
        }        
        
        if (Time.timeSinceLevelLoad > 160 & Time.timeSinceLevelLoad < 230) //165 begint de muziek
        {
            ValObject.GetComponent<Rigidbody>().useGravity = true;
            Room2_SpawnObstacles();
            
        }
        
        if (Time.timeSinceLevelLoad > 245)
        {
            BigRoomsSnapshot.TransitionTo (5.0f);  
        }
        
        
        
        //Audio
        
        
        
        
        //if(Input.GetKeyDown(KeyCode.Space))
		//{
		//	mixer.ClearFloat ("MasterVolume"); //met dit stukje code reset hij weer nr het original zodat de transition naar de nieuwe snapshot werkt
		//	BigRoomsSnapshot.TransitionTo (.5f);
		//}

		//if(Input.GetMouseButton(0))
		//{
		//	float currentVolume;
		//	mixer.GetFloat("MasterVolume", out currentVolume);			//eerste is de exposed var

		//	mixer.SetFloat("MasterVolume", currentVolume + 0.1f);
		//}
                

        
	}
    
}
