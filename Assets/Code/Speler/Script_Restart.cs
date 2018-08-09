using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class Script_Restart : MonoBehaviour 
{

void Start () 
{
    
}


public void OnCollisionEnter(Collision col)
{
    if (col.gameObject.tag == "Respawn_Border")
    {
        

        Debug.Log("hit");
        SceneManager.LoadScene ("Dead");
        
	    //transform.localPosition = new Vector3(-7, 2, 0);
    }
    
    if (col.gameObject.tag == "Room2_Obstacles")
    {
        

        Debug.Log("hit");
        SceneManager.LoadScene ("Dead");
        
	    //transform.localPosition = new Vector3(-7, 2, 0);
    }
}

}
