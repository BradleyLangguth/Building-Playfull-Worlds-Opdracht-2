using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_ObjectRotation : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        GetComponent<GameObject>();
        
	    float xSpin = Random.Range(0,360);
        float ySpin = Random.Range(0,360);
        float zSpin = Random.Range(0,360);
        
        transform.rotation=Quaternion.Euler(xSpin,ySpin,zSpin);	
	}
	


    void Update () 
    {


    }
}
