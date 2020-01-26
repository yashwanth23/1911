using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStart : MonoBehaviour
{
    public ParticleSystem fire;
    public ParticleSystem smoke;
    int count;
    float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Time.time + 3.0f;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime && count < 20){

            float x = Random.Range(-11, 11);
            float z = Random.Range(-10, 10);
            Instantiate(fire, new Vector3(x, 0.5f, z), Quaternion.LookRotation(Vector3.up));
            count++;
            spawnTime+=3.0f;
        }
        if(count == 13){
            Instantiate(smoke, new Vector3(0, 0.5f, 0), Quaternion.LookRotation(Vector3.up));
        }
        
    }
}
