﻿using System.Collections;
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
    }
    
    if (col.gameObject.tag == "Room2_Obstacles")
    {
        Debug.Log("hit");
        SceneManager.LoadScene ("Dead");
    }
    
    if (col.gameObject.name == "Finish")
    {
        Debug.Log("hit");
        SceneManager.LoadScene ("YouWin");
    }
}

}
