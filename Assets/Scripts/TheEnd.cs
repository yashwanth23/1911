using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour
{

    public ParticleSystem smoke;
    public float timer;
    public Material daytime_skybox;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (startTrigger.audioStart == true)
        {
            timer += Time.deltaTime;
        }
        Debug.Log(timer);

        if (timer >= startTrigger.audioLength)
        {
            GameObject[] dead = GameObject.FindGameObjectsWithTag("kill");
            foreach (GameObject character in dead)
            {
                Instantiate(smoke, character.transform.position, Quaternion.identity);
                GameObject.Destroy(character);
            }

            RenderSettings.skybox = daytime_skybox;
        }
    }
}