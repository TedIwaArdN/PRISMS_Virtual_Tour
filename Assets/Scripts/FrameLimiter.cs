 using UnityEngine;
 using System.Collections;
 using System;
 
 public class FrameLimiter : MonoBehaviour {
         
 
     void Awake()
     {
        QualitySettings.vSyncCount = 0;  // VSync must be disabled
        Application.targetFrameRate = 45;
     }
 }