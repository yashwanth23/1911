using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionStart : MonoBehaviour
{
    public static int people_count;
    public GameObject building;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(people_count > 1){
            building.GetComponent<Animator>().enabled = true;
            building.GetComponent<AudioSource>().enabled = true;
        }
    }
}
