using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_DestroyObject : MonoBehaviour 
{

    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.tag=="Rain") 
        {
            Destroy(col.gameObject);
        }
        
        if(col.gameObject.tag=="Room2_Obstacles") 
        {
            Destroy(col.gameObject);
        }

    }

}
