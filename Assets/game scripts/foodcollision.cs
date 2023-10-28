using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class foodcollision : MonoBehaviour
{
    void OnTriggerEnter(Collider colliding) 
    {
        if(colliding.gameObject.name == "Player")
        {
        AudioSource thesound = GetComponent<AudioSource>();
        thesound.Play();
        Debug.Log("we hit something");
        this.gameObject.GetComponent<Renderer>().enabled =false;
        this.gameObject.GetComponent<BoxCollider>().enabled =false;
        Destroy(this.gameObject, 1.0f);
        }

    }
    
}
