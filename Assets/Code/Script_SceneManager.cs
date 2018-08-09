using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_SceneManager : MonoBehaviour {
    



    
 public void Exit()
 {
  Application.Quit();
 }
    
 public void ChangeScene(string scenename)
 {
  Application.LoadLevel(scenename);
 }

}
