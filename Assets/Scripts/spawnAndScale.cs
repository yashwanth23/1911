using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnAndScale : MonoBehaviour {

    public GameObject side_character;
    public ParticleSystem spawn;
    public GameObject reference;
    float scale;
    Vector3 pos;
    // Use this for initialization
    void Start () {

        scale = Random.Range(0.5f, 2.0f);

        if (side_character == null)
            side_character = GameObject.FindGameObjectWithTag("sideChar1");

        if (reference == null)
            reference = GameObject.FindGameObjectWithTag("reference");

        pos = side_character.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            side_character.transform.position = reference.transform.position;
            side_character.transform.localScale = new Vector3(scale, scale, scale);
            Instantiate(spawn, side_character.transform.position, Quaternion.LookRotation(Vector3.up));
        }
            
    }
}
