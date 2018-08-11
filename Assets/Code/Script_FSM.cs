using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_FSM : MonoBehaviour 
{

    private float startTime;

    public string state = "NEUTRAL";
    
    
    
    
    void Start () 
    {
        startTime = Time.timeSinceLevelLoad;
	}
    
	void Update () 
    {
		switch (state)  
        {
            case "NEUTRAL":
            
            
                if (Time.timeSinceLevelLoad > 10)
                {
                    state = "ATTACK";
                }
        
                break;
        
        
            case "ATTACK":
            
                Debug.Log("ATTACK");
        
                break;
        }
	}
}
