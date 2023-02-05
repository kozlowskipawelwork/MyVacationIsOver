using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambienceControl : MonoBehaviour
{
    public GameObject triggerbox;
    public Collider collision1;
    public AudioSource ambience;

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            ambience.Play();
            collision1.enabled = false;
        }
    }
}
