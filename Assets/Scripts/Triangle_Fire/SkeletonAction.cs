using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAction : MonoBehaviour {

    public GameObject Character;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Character.GetComponent<AudioSource>().enabled = true;
            Character.GetComponent<Animator>().Play("Talking");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Character.GetComponent<AudioSource>().enabled = false;
            Character.GetComponent<Animator>().Play("Action");
            ActionStart.people_count++;
        }
    }
}
