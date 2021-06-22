using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sotesScroller : MonoBehaviour
{
    public float beatTempo;

    public bool hasStarted;
    
    void Start()
    {
        beatTempo = beatTempo / 60;  
    }


    void Update()
    {
        
            transform.position -= new Vector3(0, beatTempo * Time.deltaTime, 0);
        
    }
}
