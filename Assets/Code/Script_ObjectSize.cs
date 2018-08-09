using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_ObjectSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        Vector3 boxSize = GetComponent<Collider>().bounds.size;
        Debug.Log(boxSize.x);
        Debug.Log(boxSize.y);
        Debug.Log(boxSize.z);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
