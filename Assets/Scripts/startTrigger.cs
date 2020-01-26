using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startTrigger : MonoBehaviour {

    public GameObject[] dancers;
    public GameObject Player;

    public static bool audioStart;
    public static float audioLength;

    public float Anim_start_time;

    int count = 0;
    // Use this for initialization
    void Start()
    {
        audioStart = false;
        audioLength = this.GetComponent<AudioSource>().clip.length;
        Debug.Log(audioLength);

        for (int i = 0; i < dancers.Length; i++)
        {
            //dancers[i].GetComponent<Animator>().enabled = false;
            dancers[i].SetActive(false);
        }
        this.GetComponent<AudioSource>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            for (int i = 0; i < dancers.Length; i++)
            {
                //dancers[i].GetComponent<Animator>().enabled = true;
                dancers[i].SetActive(true);
            }
            if(count == 0)
                StartCoroutine(TemporarilyDeactivate(Anim_start_time));
        }
    }

    
    private IEnumerator TemporarilyDeactivate(float duration)
    {
        this.GetComponent<AudioSource>().enabled = false;
        yield return new WaitForSeconds(duration);
        this.GetComponent<AudioSource>().enabled = true;
        count = 1;
        audioStart = true;
    }
}
