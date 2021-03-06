﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_LerpColour : MonoBehaviour 
{

        public float speed = 0.8f;
        public Color startColor;
        public Color endColor;
        public bool repeatable = false;
        private float startTime;
        
     void Start() 
     {
        startTime = Time.time; 
     }
 
     void Update() 
     {
     if (!repeatable)
        {
            float t = (Time.time - startTime) * speed;
            GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
        }
        else
        {
            float t = (Mathf.Sin(Time.time - startTime) * speed);
            GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);        
        }
        
     }
}
