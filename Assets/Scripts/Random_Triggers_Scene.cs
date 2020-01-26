using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Triggers_Scene : MonoBehaviour {

    public GameObject trigger;
    public int Trigger_number;
    // Use this for initialization
    void Start () {
        for (int i = 0; i < Trigger_number; i++)
        {

            float randX = Random.Range(-20.0f, 20.0f);
            float randY = Random.Range(0.8f, 2.5f);
            float randZ = Random.Range(-25.0f, 10.0f);

            GameObject new_trigger = Instantiate(trigger, new Vector3(randX, randY, randZ), Quaternion.identity);
            new_trigger.gameObject.tag = "Trigger" + i.ToString();
            new_trigger.name = "Trigger" + i.ToString();

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
