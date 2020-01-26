using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Scale : MonoBehaviour {
    
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hand")
        {
            GameObject character = GameObject.FindGameObjectWithTag("Hand").transform.parent.gameObject;
            Debug.Log(character.name);
        }
        
    }
}
