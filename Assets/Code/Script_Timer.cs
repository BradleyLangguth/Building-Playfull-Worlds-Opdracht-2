using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_Timer : MonoBehaviour 
{
    public Text timerText;
    public GameObject VerdwijnMuur;
    public GameObject RoomOneLights;
    public GameObject RoomOnePath;
    
    
    
    public GameObject ValObject;
    
    public GameObject FeestGanger;
    public GameObject Object;
    
    private float startTime;
    private float elapsedTime;
    
    public Vector3 center;
    public Vector3 size;
    
    public Vector3 center2;
    public Vector3 size2;

	void Start () 
    {
        startTime = Time.timeSinceLevelLoad;
        
    
	}
    

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(center, size);
        
        Gizmos.DrawCube(center2, size2);
    }
    
    public void SpawnFeestGanger()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2 , size.x / 2), Random.Range(-size.y / 2 , size.y / 2), Random.Range(-size.z / 2 , size.z / 2));
        
        Instantiate(FeestGanger, pos, Random.rotation);      
    }
    
    public void SpawnObject()
    {
        Vector3 pos2 = center2 + new Vector3(Random.Range(-size2.x / 2 , size2.x / 2), Random.Range(-size2.y / 2 , size2.y / 2), Random.Range(-size2.z / 2 , size2.z / 2));
        
        Instantiate(Object, pos2, Quaternion.identity);      
    }
    
	void Update () 
    {
    
        elapsedTime = Time.timeSinceLevelLoad - startTime;

        float t = Time.timeSinceLevelLoad - startTime;
        
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        
        timerText.text = minutes + ":" + seconds;
        
        //Debug.Log(Time.timeSinceLevelLoad);
            
        if (Time.timeSinceLevelLoad > 4.8 & Time.timeSinceLevelLoad < 20)
        
        {
           VerdwijnMuur.SetActive(false);
           SpawnObject();
           
        }
                
        if (Time.timeSinceLevelLoad > 73 & Time.timeSinceLevelLoad < 110)
        
        {
            SpawnFeestGanger();
            RoomOneLights.SetActive(false);
            RoomOnePath.SetActive(true);
        }
        
        if (Time.timeSinceLevelLoad > 110)
        
        {
            //RoomOneLights.SetActive(true);
        }
        
        if (Time.timeSinceLevelLoad > 160 & Time.timeSinceLevelLoad < 170)
        
        {
            SpawnObject();
        }
        
        if (Time.timeSinceLevelLoad > 165)
        {
            ValObject.GetComponent<Rigidbody>().useGravity = true;
            
        }
                

        
	}
    
}
