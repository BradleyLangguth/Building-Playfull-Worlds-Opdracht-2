using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Manager : MonoBehaviour {

    public static Script_Manager Instance { get; private set; }
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
