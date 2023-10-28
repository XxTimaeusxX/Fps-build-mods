using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorscript : MonoBehaviour
{
    public Animator anim;
   private void OnTriggerEnter(Collider other) 
   {
    if(other.gameObject.name == "Player")
    anim.SetTrigger("detection");
   }
    // Update is called once per frame
    private void OnTriggerExit(Collider other)
   {
    if(other.gameObject.name == "Player")
    anim.SetTrigger("detection");
   }
}
