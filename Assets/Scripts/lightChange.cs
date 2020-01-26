using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightChange : MonoBehaviour {

    public Light spotLight;
    float duration = 1.0f;
    Color color0 = Color.red;
    Color color1 = Color.blue;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hand")
        {

            //float t = Mathf.PingPong(Time.time, duration) / duration;
            //spotLight.color = Color.Lerp(color0, color1, t);
            spotLight.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            Debug.Log(spotLight.color);
        }
    }
}
