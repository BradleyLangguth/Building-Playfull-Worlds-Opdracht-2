using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_SceneManager : MonoBehaviour 
{ 
    
    public void Exit()
    {
        Application.Quit();
    }
    
    public void ChangeScene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
    
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
        Application.LoadLevel("Menu");
        }
    }
}
