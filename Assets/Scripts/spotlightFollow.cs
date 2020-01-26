using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spotlightFollow : MonoBehaviour {

    public GameObject character;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(character.transform);
	}
}
