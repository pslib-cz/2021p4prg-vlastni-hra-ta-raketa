using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    private float countDiff = 10;
    private float currentTime;
    void Start()
    {
        currentTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime + countDiff < Time.time)
        {
            if (Camera.main.orthographicSize == 5)
            {
                Camera.main.orthographicSize = -5;                
            }
            else
            {
                Camera.main.orthographicSize = 5;
                
            }
            currentTime = Time.time;
        }
        
    }  
}
