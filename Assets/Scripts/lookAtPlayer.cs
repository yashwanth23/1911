using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtPlayer : MonoBehaviour {

    public Transform target;
    float speed = 2.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetDir = target.position - transform.position;

        float step = speed * Time.deltaTime;

        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        Debug.DrawRay(transform.position, newDir, Color.red);

        transform.rotation = Quaternion.LookRotation(newDir);
 	}
}
