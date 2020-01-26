using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomTriggers : MonoBehaviour {
    
    public GameObject trigger;
    private Vector3 ref_pos;
	// Use this for initialization
	void Start () {
        ref_pos = this.transform.position;
        for (int i = 0; i < 8; i++)
        {
            float radius = Random.Range(0.2f, 2.0f);
            float theta = Random.Range(45f*i, 45f*(i+1));

            float randX = ref_pos.x + radius * Mathf.Cos(theta * Mathf.Deg2Rad);
            float randY = Random.Range(0.25f*i, 0.25f*(i+1));
            float randZ = ref_pos.z + radius * Mathf.Sin(theta * Mathf.Deg2Rad);

            GameObject new_trigger = Instantiate(trigger, new Vector3(randX, randY, randZ), Quaternion.identity);
            new_trigger.gameObject.tag = "Trigger" + i.ToString();
            new_trigger.name = "Trigger" + i.ToString();

        }
    }
	
	// Update is called once per frame
	void Update () {
	}
}
