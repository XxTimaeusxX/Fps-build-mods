using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class rotate : MonoBehaviour
{
   public Vector3 rotationchange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationchange);
       
    }
}
